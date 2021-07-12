import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Pancreas } from '../../../core/models/ultrassom/pancreas/pancreas';
import { PancreasClassificacao } from '../../../core/models/ultrassom/pancreas/pancreas-classificacao.enum';

@Component({
  selector: 'app-us-pancreas',
  templateUrl: './us-pancreas.component.html',
  styleUrls: ['./us-pancreas.component.css']
})
export class UsPancreasComponent implements OnInit {

  @Input() pancreas: Pancreas;
  @Output() pancreasChange = new EventEmitter();

  constructor() { }


  validaDesabilitado(checkBox) : boolean
  {
     
      return !checkBox && this.isPancreasInacessivel();
  }


  isPancreasInacessivel():boolean{
    return this.pancreas.Classificacao == PancreasClassificacao.Inacessivel;
  }

  ngOnInit() {

   this.pancreas = {
      Classificacao: PancreasClassificacao.Normal,
      CheckCabeca: false,
      TamanhoCabeca: 10,
      CheckCorpo: false,
      TamanhoCorpo: 10,
      CheckCauda: false,
      TamanhoCauda: 10
    } as Pancreas;

    this.pancreasChange.emit(this.pancreas);
  }

}
