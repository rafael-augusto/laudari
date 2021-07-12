import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-form-combobox',
  templateUrl: './form-combobox.component.html',
  styleUrls: ['./form-combobox.component.css']
})
export class FormComboboxComponent implements OnInit {

  @Input() desabilitado: boolean;

  @Input() itens: Object[]; 
  @Input() model: number;
  @Output() modelChange = new EventEmitter();
  @Output() desabilitadoChange =  new EventEmitter();


  onChange(newValue) {
    this.model = newValue;
    this.modelChange.emit(newValue);
  }

  constructor() { }

  ngOnInit() {
  }

}
