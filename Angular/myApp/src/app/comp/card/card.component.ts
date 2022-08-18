import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  
  @Input('cardTitle') cardTitle: string = "Card Title";
  @Input('display') display:boolean=false ;
  @Input('cardText') cardText: string = "Card Text";
  @Input('cardsubTitle') cardsubTitle: string = "Some quick example text to build on the card title and make up the bulk of the card's content.";
  constructor() { 
    

  }

  ngOnInit(): void {
  }

}
