import { TestBed } from '@angular/core/testing';
import { MeasurementService } from './services/measurement.service';
import { RestService } from '@abp/ng.core';

describe('MeasurementService', () => {
  let service: MeasurementService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(MeasurementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
