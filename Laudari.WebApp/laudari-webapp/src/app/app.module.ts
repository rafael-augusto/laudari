import { ModuleWithProviders, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AuthModule } from './auth/auth.module';
import { HomeModule } from './home/home.module';
import {
  FooterComponent,
  HeaderComponent,
  SharedModule
} from './shared';

import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormCheckboxComponent } from './shared/inputs/form-checkbox/form-checkbox.component';
import { AngularEditorModule } from '@kolkov/angular-editor';


@NgModule({
  declarations: [AppComponent, FooterComponent, HeaderComponent],
  imports: [
    NgbModule,
    BrowserModule,
    CoreModule,
    SharedModule,
    HomeModule,
    AuthModule,
    AppRoutingModule,
    AngularEditorModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
