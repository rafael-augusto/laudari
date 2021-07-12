import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { LimitTecnica } from '../../../core/models/ultrassom/limitTecnica/limit-tecnica';
import { LimitTecnicaClassificacao } from '../../../core/models/ultrassom/limitTecnica/limit-tecnica.enum';


@Component({
  selector: 'app-limitacoes-tecnicas',
  templateUrl: './limitacoes-tecnicas.component.html',
  styleUrls: ['./limitacoes-tecnicas.component.css']
})
export class LimitacoesTecnicasComponent implements OnInit {


  @Input() limitacaoTecnica: LimitTecnica;
  @Output() limitacaoTecnicaChange = new EventEmitter();


  ngOnInit() {

   this.limitacaoTecnica = {
    Classificacao: undefined
    } as LimitTecnica;

    this.limitacaoTecnicaChange.emit(this.limitacaoTecnica);
  }

  constructor() { }


}
