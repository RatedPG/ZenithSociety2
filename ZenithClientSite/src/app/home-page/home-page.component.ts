import { Component, OnInit } from '@angular/core';
import { Event } from '../event';
import { EventFetchService } from '../event-fetch.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  
  events : Event[];

  constructor(
    private eventFetchService : EventFetchService,
    private router : Router
  ) { }

  getEvents(): void {
    this.eventFetchService.getEvents()
      .then(events => this.events = events);
    console.log(this.events);
  }

  ngOnInit() {
    this.getEvents();
  }
}
