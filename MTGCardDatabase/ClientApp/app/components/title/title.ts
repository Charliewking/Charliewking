import { Component, Input } from '@angular/core';

@Component({
    selector: 'title-component',
    templateUrl: './title.html',
    styleUrls: ['./title.css']
})
export class TitleComponent {

    @Input()
    title: string = "";

}