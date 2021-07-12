import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-form-radiobox',
  templateUrl: './form-radiobox.component.html',
  styleUrls: ['./form-radiobox.component.css']
})
export class FormRadioboxComponent implements OnInit {

  @Input() text: string;
  @Input() nome: string;
  @Input() valor: object;
  @Input() model: number;
  @Output() modelChange = new EventEmitter();



  onChange(newValue) {
    if (newValue == this.model){
      this.model = undefined;
      this.modelChange.emit(undefined);
    }
    else {
      this.model = newValue;
      this.modelChange.emit(newValue);
    }
  }

 
  click() {
    if (this.model == <number><any>this.valor){
      this.model = undefined;
      this.modelChange.emit(undefined);
    }

  }

  constructor() { }

  ngOnInit() {
  }

}
