import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { ShowAuthedDirective } from './show-authed.directive';
import { FormCheckboxComponent } from './inputs/form-checkbox/form-checkbox.component';
import { FormRadioboxComponent } from './inputs/form-radiobox/form-radiobox.component';
import { FormTextAddonComponent } from './inputs/form-text-addon/form-text-addon.component';
import { FormComboboxComponent } from './inputs/form-combobox/form-combobox.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule
  ],
  declarations: [
    ShowAuthedDirective,
    FormCheckboxComponent,
    FormRadioboxComponent,
    FormTextAddonComponent,
    FormComboboxComponent
  ],
  exports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
    ShowAuthedDirective,
    FormCheckboxComponent,
    FormRadioboxComponent,
    FormTextAddonComponent,
    FormComboboxComponent
  ]
})
export class SharedModule {}
