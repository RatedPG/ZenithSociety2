import { TestBed, inject } from '@angular/core/testing';

import { EventFetchService } from './event-fetch.service';

describe('EventFetchService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EventFetchService]
    });
  });

  it('should be created', inject([EventFetchService], (service: EventFetchService) => {
    expect(service).toBeTruthy();
  }));
});
