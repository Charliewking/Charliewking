import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { CardNamePipe } from '../../pipes/card-name.pipe';
import { CardTextPipe } from '../../pipes/card-text.pipe';
import { HttpCardService } from '../../services/http-service';
import { ScryfallService } from '../../services/scryfall.service';
import { Card, PreviewCard } from '../../interfaces/interfaces';

@Component({
    selector: 'preview',
    templateUrl: './preview.component.html',
    providers: [HttpCardService, ScryfallService]
})
export class PreviewComponent {
    public queryString: string = '';
    public setQuery: string = '';
    public cards: Card[] = [];
    public errorText: string = "Not enough to search on"
    public showError: boolean = false;
    public ISScore: string = '2';
    public MPScore: string = '3';
    public TotalScore: string = '';
    public previewCardURI: string = '';
    public previewCardName: string = '';
    public rarityString: string = '';

    public _httpCardService: HttpCardService;
    public _scryfallService: ScryfallService;

    constructor(private httpCardService: HttpCardService, private scryfallService: ScryfallService) {
        this._httpCardService = httpCardService;
        this._scryfallService = scryfallService;
    }

    ngOnInit() {
        // call some function that gets either a cache or new cards if no cache
        // this._scryfallService.getCard("Nicol Bolas, Dragon God");
        this._httpCardService.getPreviewCards();
    }

    getCard(name: string) {
        this._scryfallService.getCard(name);
        this.previewCardName = this._scryfallService.returnCards[0].name
        this.previewCardURI = this._scryfallService.returnCards[0].image_Normal
        this.ISScore = '';
        this.MPScore = '';
    }

    setMPScore() {

    }
    setISScore() {

    }

    setPreviewCard(previewCard: PreviewCard) {
        this.previewCardName = previewCard.name;
        this.previewCardURI = previewCard.image_Normal;
        this.ISScore = previewCard.ironstreamRating;
        this.MPScore = previewCard.ajSnipsRating;
    }
}


interface ImageBinding {
    Name: string;
    Image_URI: string;
}

//interface Card {
//    PartitionKey: string;
//    RowKey: string;
//    name: string;
//    set: string;
//    colors: string[];
//    rarity: string;
//    mana_cost: string;
//    added: boolean;
//    power: string;
//    type_line: string;
//    color_identity: string;
//    toughness: string;
//    Image_URI: string;
//    card_text: string;
//    flavor_text: string;
//    numberInCollection: number;
//    cmc: string;
//    image_uris: any;
//    set_name: string;
//    oracle_text: string;
//    full_cost: string[];
//}