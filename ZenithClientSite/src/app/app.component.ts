import { Component } from '@angular/core';
import { EventFetchService } from './event-fetch.service'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [EventFetchService]
})
export class AppComponent {
  title = 'Brain-Train';
}
