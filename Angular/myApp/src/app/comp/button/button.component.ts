import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  //text to show in button
  text: string = "Click me";
  // string Text="Click me";
  @Input('btnText') btnText="Click Me";

  constructor() { }

  ngOnInit(): void {
  }

}
