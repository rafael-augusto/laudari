import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Baco } from '../../../core/models/ultrassom/baco/baco';
import { BacoClassificacao, BacoEcoTextura } from '../../../core/models/ultrassom/baco/baco.enum';

@Component({
  selector: 'app-us-baco',
  templateUrl: './us-baco.component.html',
  styleUrls: ['./us-baco.component.css']
})
export class UsBacoComponent implements OnInit {

  @Input() baco: Baco;
  @Output() bacoChange = new EventEmitter();

  constructor() { }
  
  ecotextura: Object[] = [
    { ID: BacoEcoTextura.homogenea, Nome: 'Ecotextura Homogênea' },
    { ID: BacoEcoTextura.heterogenea, Nome: 'Ecotextura Heterogênea' }
  ];

  ngOnInit() {

    this.baco = {
      Classificacao: BacoClassificacao.Normal,
      Ecotextura: BacoEcoTextura.homogenea,
      DimensaoA: 90,
      DimensaoB: 60,
      DimensaoAcessorioA: 20,
      DimensaoAcessorioB: 10,
  
      DimensaoCalcificacao: 4
    } as Baco;

    this.bacoChange.emit(this.baco);
  }

}
