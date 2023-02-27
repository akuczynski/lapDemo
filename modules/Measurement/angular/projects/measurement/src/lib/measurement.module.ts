import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { MeasurementComponent } from './components/measurement.component';
import { MeasurementRoutingModule } from './measurement-routing.module';

@NgModule({
  declarations: [MeasurementComponent],
  imports: [CoreModule, ThemeSharedModule, MeasurementRoutingModule],
  exports: [MeasurementComponent],
})
export class MeasurementModule {
  static forChild(): ModuleWithProviders<MeasurementModule> {
    return {
      ngModule: MeasurementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<MeasurementModule> {
    return new LazyModuleFactory(MeasurementModule.forChild());
  }
}
