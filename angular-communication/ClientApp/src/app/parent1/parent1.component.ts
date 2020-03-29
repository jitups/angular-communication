import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-parent1',
  templateUrl: './parent1.component.html',
  styleUrls: ['./parent1.component.scss']
})
/** parent1 component*/
export class Parent1Component implements OnInit {
  message: string;
  /** parent1 ctor */
  constructor(private service: SharedService) {

  }

  ngOnInit() {
    this.getMessage();
  }

  getMessage() {
    this.service.currentMessage.subscribe(message => {
      this.message = message;
    });
  }
}
