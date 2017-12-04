import { Component, OnInit } from '@angular/core';
import { Event } from '../event';
import { EventFetchService } from '../event-fetch.service';
import { Data } from '@angular/router/src/config';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  
  events : Event[];
  lastMonday : Date;
  nextSunday : Date;
  referDate  : Date;

  constructor(
    private eventFetchService : EventFetchService
  ) { }

  getMondaySunday(){
    var temp = new Date(this.referDate);

    var lastMonday = temp.getDate() - temp.getDay() + 1;
    if(temp.getDay() === 0){
      this.lastMonday = new Date(temp.setDate(lastMonday - 7));
      this.nextSunday = new Date(temp.setDate(this.lastMonday.getDate() + 6));
    } else {
      this.lastMonday = new Date(temp.setDate(lastMonday));
      this.nextSunday = new Date(temp.setDate(this.lastMonday.getDate() + 6));
    }
  }

  nextWeek(){
    this.referDate = new Date(this.referDate.setDate(this.referDate.getDate() + 7));
    this.getMondaySunday();
  }

  prevWeek(){
    this.referDate = new Date(this.referDate.setDate(this.referDate.getDate() - 7));
    this.getMondaySunday();
  }
  getEvents(): void {
    this.eventFetchService.getEvents()
      .then(events => this.events = events);
  }

  getByWeek(date: Date) : void {
    
  }

  ngOnInit() {
    this.referDate = new Date();
    this.getMondaySunday();
    this.getEvents();
  }
}
