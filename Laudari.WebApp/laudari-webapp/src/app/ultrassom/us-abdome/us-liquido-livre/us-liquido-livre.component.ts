import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { LiquidoLivre } from '../../../core/models/ultrassom/liquidoLivre/liquido-livre';
import { liquidoLibreClassificacao, liquidoLivreQtd } from '../../../core/models/ultrassom/liquidoLivre/liquido-livre.enum';

@Component({
  selector: 'app-us-liquido-livre',
  templateUrl: './us-liquido-livre.component.html',
  styleUrls: ['./us-liquido-livre.component.css']
})
export class UsLiquidoLivreComponent implements OnInit {

  @Input() liquidoLivre: LiquidoLivre;
  @Output() liquidoLivreChange = new EventEmitter();

  constructor() { }

  classificacaoLiquidoLivre: Object[] = [
    { ID: liquidoLibreClassificacao.Ausente, Nome: 'ausente' },
    { ID: liquidoLibreClassificacao.Abdome, Nome: 'no abdome' },
    { ID: liquidoLibreClassificacao.Pelve, Nome: 'na pelve' },
    { ID: liquidoLibreClassificacao.FossaHepatorrenal, Nome: 'na fossa hepatorrenal' },
    { ID: liquidoLibreClassificacao.FlancoDireito, Nome: 'no flanco direito' },
    { ID: liquidoLibreClassificacao.FlancoEsquerdo, Nome: 'no flanco esquerdo' },
    { ID: liquidoLibreClassificacao.FossaIliacaDireita, Nome: 'na fossa ilíaca direita' },  
    { ID: liquidoLibreClassificacao.FossaIliacaEsquerda, Nome: 'na fossa ilíaca esquerda' }

  ];

  quantidadeLiquidoLivre: Object[] = [
    {ID: liquidoLivreQtd.PequenaQtd, Nome: 'pequena quantidade'},
    {ID: liquidoLivreQtd.ModeradaQtd, Nome: 'moderada quantidade'},
    {ID: liquidoLivreQtd.GrandeQtd, Nome: 'grande quantidade'}
  ];

  ngOnInit() {
    this.liquidoLivre = {
      Classificacao: liquidoLibreClassificacao.Ausente,
      Quantidade: liquidoLivreQtd.PequenaQtd
    } as LiquidoLivre;

    this.liquidoLivreChange.emit(this.liquidoLivre);
  }

}
