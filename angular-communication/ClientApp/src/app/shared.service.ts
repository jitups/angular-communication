import { Injectable } from '@angular/core';
import { Subject, Observable, BehaviorSubject } from 'rxjs';

@Injectable()
export class SharedService {
  public message$ = new Subject<string>();

  constructor() {
    this.message$.next('default');
  }


  setMessage(message: string) {
    this.message$.next(message);
  }

  getMessage(): Observable<any> {
    let test = this.message$.asObservable();
    return test;
  }
}
