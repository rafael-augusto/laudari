import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Bexiga } from '../../../core/models/ultrassom/bexiga/bexiga';
import { BexigaClassificacao } from '../../../core/models/ultrassom/bexiga/bexiga.enum';

@Component({
  selector: 'app-us-bexiga',
  templateUrl: './us-bexiga.component.html',
  styleUrls: ['./us-bexiga.component.css']
})
export class UsBexigaComponent implements OnInit {

  @Input() bexiga: Bexiga;
  @Output() bexigaChange = new EventEmitter();

  constructor() { }

  ngOnInit() {
    this.bexiga = {
      Classificacao : BexigaClassificacao.Normal,
      NaoCitar : false
    } as Bexiga;

    this.bexigaChange.emit(this.bexiga);
  }

}
