import { Component, OnInit } from '@angular/core';
import { MeasurementService } from '../services/measurement.service';

@Component({
  selector: 'lib-measurement',
  template: ` <p>measurement works!</p> `,
  styles: [],
})
export class MeasurementComponent implements OnInit {
  constructor(private service: MeasurementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
