import { Component, OnInit, OnDestroy } from '@angular/core';
import { SharedService } from '../shared.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-parent1',
  templateUrl: './parent1.component.html',
  styleUrls: ['./parent1.component.scss']
})
/** parent2 component*/
export class Parent1Component implements OnInit, OnDestroy {
  message: string = "ABC";
  subscription: Subscription;

  /** parent2 ctor */
  constructor(private sharedService: SharedService) {
    
  }

  ngOnInit() {
    this.watchMessage();
  }

  //getMessage() {
  //  this.service.message.subscribe(message => {
  //    this.message = message;
  //  });
  //}

  watchMessage() {
    this.subscription = this.sharedService.message$.subscribe(response => {
      console.log('response', response);
      this.message = response;
    });
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
