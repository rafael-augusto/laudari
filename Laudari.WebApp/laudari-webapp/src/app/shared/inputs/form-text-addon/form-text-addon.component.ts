import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-form-text-addon',
  templateUrl: './form-text-addon.component.html',
  styleUrls: ['./form-text-addon.component.css']
})
export class FormTextAddonComponent implements OnInit {


  @Input() desabilitado: boolean;

  @Input() inputType: string; 
  @Input() append: string;
  @Input() model: string;
  @Output() modelChange = new EventEmitter();
  @Input() desabilitadoChange =  new EventEmitter();


  onChange(newValue) {
    this.model = newValue;
    this.modelChange.emit(newValue);
  }
  
  constructor() { }

  ngOnInit() {
  }

}
