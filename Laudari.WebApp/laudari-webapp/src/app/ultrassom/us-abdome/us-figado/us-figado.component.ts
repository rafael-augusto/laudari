import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { Figado } from '../../../core/models/ultrassom/figado/figado';
import { FigadoClassificacao, DimensoesDescritivo, GrauEsteatose, TipoHepatopatiaCronica,
   ClassificacaoNoduloFigado, ClassificacaoContorno, EnfaseMultiplosNodulos, SegmentoFigado, FluxoPortal } from '../../../core/models/ultrassom/figado/figado.enum';

@Component({
  selector: 'app-us-figado',
  templateUrl: './us-figado.component.html',
  styleUrls: ['./us-figado.component.css']
})
export class UsFigadoComponent implements OnInit {


  @Input() figado: Figado;
  @Output() figadoChange = new EventEmitter();


  grausEsteatose: Object[] = [
    { ID: GrauEsteatose.NaoEspecificado, Nome: 'grau não especificado' },
    { ID: GrauEsteatose.Discreta, Nome: 'discreta' },
    { ID: GrauEsteatose.Moderada, Nome: 'moderada' },
    { ID: GrauEsteatose.Acentuada, Nome: 'acentuada' }
  ];

  tiposHepatopatia: Object[] = [
    { ID: TipoHepatopatiaCronica.Incipiente, Nome: 'incipiente' },
    { ID: TipoHepatopatiaCronica.Avancada, Nome: 'avançada' },
  ];

  ClassificacaoNodulo: Object[] = [
    { ID: ClassificacaoNoduloFigado.Hiperecogenico, Nome: 'Hiperecogenico' },
    { ID:  ClassificacaoNoduloFigado.Hipoecogenico, Nome: 'Hipoecogenico' },
    { ID:  ClassificacaoNoduloFigado.HiperecogenicoHemangioma, Nome: 'Hiperecogenico (Hemangioma)' },
  ];

  EnfaseMultiplosNodulos: Object[] = [
    { ID: EnfaseMultiplosNodulos.DoisTotal, Nome: 'Dois' },
    { ID:  EnfaseMultiplosNodulos.DoisMaiores, Nome: 'Dois Maiores' },
  ]

  ClassificacaoContornoNodulo: Object[] = [
    { ID: ClassificacaoContorno.Regulares, Nome: 'Regulares' },
    { ID:  ClassificacaoContorno.Lobulados, Nome: 'Lobulados' },
    { ID:  ClassificacaoContorno.Irregulares, Nome: 'Irregulares' },    
  ]

  SegmentoFigado: Object[] = [
    { ID: SegmentoFigado.Segmento1, Nome: 'Segmento I' },
    { ID: SegmentoFigado.Segmento2, Nome: 'Segmento II' },
    { ID: SegmentoFigado.Segmento3, Nome: 'Segmento III' },
    { ID: SegmentoFigado.Segmento4, Nome: 'Segmento IV' },
    { ID: SegmentoFigado.Segmento5, Nome: 'Segmento V' },
    { ID: SegmentoFigado.Segmento6, Nome: 'Segmento VI' },
    { ID: SegmentoFigado.Segmento7, Nome: 'Segmento VII' },
    { ID: SegmentoFigado.Segmento8, Nome: 'Segmento VIII' },
  ];

  dimensoesDescritivo: Object[] = [
    { ID: DimensoesDescritivo.Normais, Nome: 'normais' },
    { ID: DimensoesDescritivo.Aumentadas, Nome: 'aumentadas' },
    { ID: DimensoesDescritivo.AumentadasACustaLoboDireito, Nome: 'aumentadas à custa do lobo direito' },
    { ID: DimensoesDescritivo.AumentadasACustaLoboEsquerdo, Nome: 'aumentadas à custa do lobo esquerdo' },
    { ID: DimensoesDescritivo.Reduzidas, Nome: 'Reduzidas' },
  ];

  FluxosPortal: Object[] = [
    { ID: FluxoPortal.Hepatofugal, Nome: 'hepatofugal' },
    { ID: FluxoPortal.Hepatopetal, Nome: 'hepatopetal' }
  
  ];


  changeCalibreVeiaPorta()
  {
    if(this.figado.IncluirDoppler)
    {
      this.figado.IncluirDoppler = this.figado.CalibreVeiaPorta;
    }
  }

  changeIncluirDoppler()
  {
    if(this.figado.IncluirDoppler)
    {
      this.figado.CalibreVeiaPorta = true;
    }
  }

  constructor() { 
    

  }

  ngOnInit() {

    this.figado =  {
      Classificacao: FigadoClassificacao.Homogeneo,
      DimensaoDescritivo: DimensoesDescritivo.Normais,
      GrauEsteatose: GrauEsteatose.NaoEspecificado,
      SegmentoANodulo : SegmentoFigado.Segmento1,
      SegmentoBNodulo : SegmentoFigado.Segmento1,
      SegmentoCalcificacao : SegmentoFigado.Segmento1,
      SegmentoCisto : SegmentoFigado.Segmento1,
      EnfaseNodulo : EnfaseMultiplosNodulos.DoisTotal,
      ClassificacaoNodulo : ClassificacaoNoduloFigado.Hiperecogenico,
      ClassificacaoContornoNodulo : ClassificacaoContorno.Regulares,
      TipoHepatopatiaCronica: TipoHepatopatiaCronica.Incipiente,
      
      DimensaoLoboDireito: 150,
      DimensaoLoboEsquerdo: 120,
      DimensaoLoboCaudado: 100,
      DimensaoCisto: 4,
      DimensaoANodulo: 10,
      DimensaoBNodulo: 10,
      DimensaoCalcificacao: 4,
      DimensaoCalibreVeiaPorta: 10,
      DimensaoCalibreVeiaEsplenica: 7,
      FluxoPortal : FluxoPortal.Hepatopetal,
      VelocidadeVeiaPorta: 20,
      VelocidadeVeiaEsplenica: 18,
    } as Figado;

    this.figadoChange.emit(this.figado);

  }

}
