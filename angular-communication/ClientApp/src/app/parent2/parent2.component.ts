import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-parent2',
  templateUrl: './parent2.component.html',
  styleUrls: ['./parent2.component.scss']
})
/** parent2 component*/
export class Parent2Component implements OnInit {
  @ViewChild("textMessage", { static: false }) textMessage: ElementRef;
  message: string;

  /** parent2 ctor */
  constructor(private service: SharedService) {

  }

  ngOnInit() {
    this.service.message$.subscribe(message => {
      this.message = message;
    });
  }

  newMessage() {
    this.service.setMessage(this.textMessage.nativeElement.value);
  }
}
