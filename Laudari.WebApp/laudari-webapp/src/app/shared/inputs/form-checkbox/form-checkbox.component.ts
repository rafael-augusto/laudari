import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-form-checkbox',
  templateUrl: './form-checkbox.component.html',
  styleUrls: ['./form-checkbox.component.css']
})
export class FormCheckboxComponent implements OnInit {

  @Input() desabilitado: boolean;
  @Input() IdInput: string;
  @Input() text: string;
  @Input() model: boolean;
  @Output() modelChange = new EventEmitter();
  @Output() desabilitadoChange =  new EventEmitter();

  onChange(newValue) {
    this.model = newValue;
    this.modelChange.emit(newValue);
  }

  constructor() {
   }

  ngOnInit() {
  }

}
