import { Component, Input } from '@angular/core';

@Component({
    selector: 'paragraph-component',
    templateUrl: './paragraph.html'
})
export class ParagraphComponent {

    @Input()
    paragraph: string = "";

}