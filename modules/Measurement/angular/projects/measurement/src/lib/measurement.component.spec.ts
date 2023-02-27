import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { MeasurementComponent } from './components/measurement.component';
import { MeasurementService } from '@lab/measurement';
import { of } from 'rxjs';

describe('MeasurementComponent', () => {
  let component: MeasurementComponent;
  let fixture: ComponentFixture<MeasurementComponent>;
  const mockMeasurementService = jasmine.createSpyObj('MeasurementService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [MeasurementComponent],
      providers: [
        {
          provide: MeasurementService,
          useValue: mockMeasurementService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MeasurementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
