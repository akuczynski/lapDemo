import { ModuleWithProviders, NgModule } from '@angular/core';
import { MEASUREMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class MeasurementConfigModule {
  static forRoot(): ModuleWithProviders<MeasurementConfigModule> {
    return {
      ngModule: MeasurementConfigModule,
      providers: [MEASUREMENT_ROUTE_PROVIDERS],
    };
  }
}
