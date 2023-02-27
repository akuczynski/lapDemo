import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class MeasurementService {
  apiName = 'Measurement';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/Measurement/sample' },
      { apiName: this.apiName }
    );
  }
}
