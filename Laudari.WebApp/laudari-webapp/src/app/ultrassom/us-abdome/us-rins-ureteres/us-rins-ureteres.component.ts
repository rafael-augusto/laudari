import { Component, OnInit, Input, Output, EventEmitter, ViewChild, ElementRef } from '@angular/core';
import { RinsUreteres } from '../../../core/models/ultrassom/rinsUreteres/rins-ureteres';
import { RinsClassificacaoNefropatia, RinsClassificacaoNoduloSolido, RinsContornoNoduloSolido, RinsPosicao, RinsEsquerdoDireito, RinsAlturaPosicao, RinsDilatacaoPielocalcinal, RinsPosicaoCalculoUretral } from '../../../core/models/ultrassom/rinsUreteres/rins-ureteres.enum';
import { Aorta } from '../../../core/models/ultrassom/aorta/aorta';

@Component({
  selector: 'app-us-rins-ureteres',
  templateUrl: './us-rins-ureteres.component.html',
  styleUrls: ['./us-rins-ureteres.component.css']
})
export class UsRinsUreteresComponent implements OnInit {

  @Input() rinsUreteres: RinsUreteres;
  @Input() aorta: Aorta;
  @Output() rinsUreteresChange = new EventEmitter();

  ausenciaUmDosRins: boolean;
  requireVPSAorta: boolean;

  changeAusenciaRimDireito() {
    if (this.rinsUreteres.AusenciaRimDireito) {
      this.ausenciaUmDosRins = true;

      this.rinsUreteres.RimCisto1 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCisto2 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCisto3 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCisto4 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCistosBilaterais = RinsEsquerdoDireito.RimEsquerdo;

      this.rinsUreteres.RimCalculo1 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCalculo2 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCalculo3 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCalculo4 = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.RimCalculosBilaterais = RinsEsquerdoDireito.RimEsquerdo;

      this.rinsUreteres.RimNoduloSolido = RinsEsquerdoDireito.RimEsquerdo;
      this.rinsUreteres.PosicaoNefropatiaParenquimatosaCronica = RinsClassificacaoNefropatia.RimEsquerdo;

      this.rinsUreteres.CalculoUretralDireitoEsquerdo = RinsEsquerdoDireito.RimEsquerdo;
    }
    else
      this.ausenciaUmDosRins = false;
    this.rinsUreteres.AusenciaRimEsquerdo = false;



  }

  changeAusenciaRimEsquerdo() {
    if (this.rinsUreteres.AusenciaRimEsquerdo) {
      this.ausenciaUmDosRins = true;

      this.rinsUreteres.RimCisto1 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCisto2 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCisto3 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCisto4 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCistosBilaterais = RinsEsquerdoDireito.RimDireito;

      this.rinsUreteres.RimCalculo1 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCalculo2 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCalculo3 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCalculo4 = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.RimCalculosBilaterais = RinsEsquerdoDireito.RimDireito;

      this.rinsUreteres.RimNoduloSolido = RinsEsquerdoDireito.RimDireito;
      this.rinsUreteres.PosicaoNefropatiaParenquimatosaCronica = RinsClassificacaoNefropatia.RimDireito;

      this.rinsUreteres.CalculoUretralDireitoEsquerdo = RinsEsquerdoDireito.RimDireito;
    }
    else
      this.ausenciaUmDosRins = false;
    this.rinsUreteres.AusenciaRimDireito = false;
  }


  clickVPSAorta(){
    const tmp = document.getElementById("citarVpsAorta");
    tmp.focus();
  }

  changeCitarRelacaoVPSAorta() {
    if (this.rinsUreteres.CitarRelacaoVPSArteriasRenais) {
        this.requireVPSAorta = true;
    }
    else {
      this.requireVPSAorta = false;
    }
  }

  PosicaoNefropatiaParenquimatosaCronica: Object[] = [
    { ID: RinsClassificacaoNefropatia.Bilateral, Nome: 'bilateral' },
    { ID: RinsClassificacaoNefropatia.RimDireito, Nome: 'do rim direito' },
    { ID: RinsClassificacaoNefropatia.RimEsquerdo, Nome: 'do rim esquerdo' }

  ];

  ClassificacaoNoduloSolido: Object[] = [
    { ID: RinsClassificacaoNoduloSolido.Hipoecogenico, Nome: 'hipoecogênico' },
    { ID: RinsClassificacaoNoduloSolido.Hiperecogenico, Nome: 'hiperecogênico' },
    { ID: RinsClassificacaoNoduloSolido.Isoecogenico, Nome: 'isoecogênico' }

  ];

  ContornoNoduloSolido: Object[] = [
    { ID: RinsContornoNoduloSolido.Regulares, Nome: 'contornos regulares' },
    { ID: RinsContornoNoduloSolido.Irregulares, Nome: 'contornos irregulares' }

  ];

  PosicaoRim: Object[] = [
    { ID: RinsPosicao.TercoSuperior, Nome: 'terço superior' },
    { ID: RinsPosicao.TercoMedio, Nome: 'terço médio' },
    { ID: RinsPosicao.TercoInferior, Nome: 'terço inferior' },
    { ID: RinsPosicao.PoloSuperior, Nome: 'pólo superior' },
    { ID: RinsPosicao.PoloInferior, Nome: 'pólo inferior' },


  ];


  RimEsquerdoDireito: Object[] = [
    { ID: RinsEsquerdoDireito.RimDireito, Nome: 'rim direito' },
    { ID: RinsEsquerdoDireito.RimEsquerdo, Nome: 'rim esquerdo' }

  ];


  DilatacaoPielocalcinal: Object[] = [
    { ID: RinsDilatacaoPielocalcinal.Ausente, Nome: 'ausente' },
    { ID: RinsDilatacaoPielocalcinal.Discreta, Nome: 'discreta' },
    { ID: RinsDilatacaoPielocalcinal.DiscretaModerada, Nome: 'discreta/moderada' },
    { ID: RinsDilatacaoPielocalcinal.Moderada, Nome: 'moderada' },
    { ID: RinsDilatacaoPielocalcinal.Acentuada, Nome: 'acentuada' },
  ];

  PosicaoCalculoUretral: Object[] = [
    { ID: RinsPosicaoCalculoUretral.JuncaoPieloureteral, Nome: 'na junção pieloureteral' },
    { ID: RinsPosicaoCalculoUretral.TercoProximalUreter, Nome: 'no terço proximal do uréter' },
    { ID: RinsPosicaoCalculoUretral.TercoMedioUreter, Nome: 'no terço médio do  uréter' },
    { ID: RinsPosicaoCalculoUretral.TercoDistalUreter, Nome: 'no terço distal do  uréter' },
    { ID: RinsPosicaoCalculoUretral.MeatoUreteral, Nome: 'no meato ureteral' }
  ];

  CalculoUretralEsquerdaDireita: Object[] = [
    { ID: RinsEsquerdoDireito.RimDireito, Nome: 'à direita' },
    { ID: RinsEsquerdoDireito.RimEsquerdo, Nome: 'à esquerda' }

  ];


  ngOnInit() {

    this.rinsUreteres = {
      UsAorta : this.aorta,
      AspectoNormal: true,
      AusenciaRimDireito: false,
      AusenciaRimEsquerdo: false,
      IncluirMedidaRins: false,
      RimDireitoL: 100,
      RimDireitoT: 40,
      RimDireitoAP: 30,
      RimDireitoParenquima: 13,
      RimEsquerdoL: 100,
      RimEsquerdoT: 40,
      RimEsquerdoAP: 30,
      RimEsquerdoParenquima: 13,
      IncluirDopplerArteriasRenais: false,
      VPSDireita: 100,
      VPSEsquerda: 100,
      CitarRelacaoVPSArteriasRenais: false,
      ArteriaRenalDireitaInacessivel: false,
      ArteriaRenalEsquerdaInacessivel: false,
      CitarAASegmentaresDireita: false,
      SuperiorDireita: 30,
      MediaDireita: 30,
      InferiorDireita: 30,
      CitarAASegmentaresEsquerda: false,
      SuperiorEsquerda: 30,
      MediaEsquerda: 30,
      InferiorEsquerda: 30,
      PossuiNefropatiaParenquimatosaCronica: false,
      PosicaoNefropatiaParenquimatosaCronica: RinsClassificacaoNefropatia.Bilateral,
      PossuiNoduloSolido: false,
      ClassificacaoNoduloSolido: RinsClassificacaoNoduloSolido.Hiperecogenico,
      ContornoNoduloSolido: RinsContornoNoduloSolido.Regulares,
      DimensaoANoduloSolido: 10,
      DimensaoBNoduloSolido: 10,
      PosicaoNoduloSolido: RinsPosicao.TercoSuperior,
      RimNoduloSolido: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCisto1: false,
      DimensaoCisto1: 10,
      PosicaoCisto1: RinsPosicao.TercoSuperior,
      RimCisto1: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCisto2: false,
      DimensaoCisto2: 10,
      PosicaoCisto2: RinsPosicao.TercoSuperior,
      RimCisto2: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCisto3: false,
      DimensaoCisto3: 10,
      PosicaoCisto3: RinsPosicao.TercoSuperior,
      RimCisto3: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCisto4: false,
      DimensaoCisto4: 10,
      PosicaoCisto4: RinsPosicao.TercoSuperior,
      RimCisto4: RinsEsquerdoDireito.RimEsquerdo,

      PossuiVariosCistosBilaterais: false,
      DimensaoCistosBilaterais: 10,
      PosicaoCistosBilaterais: RinsPosicao.TercoSuperior,
      RimCistosBilaterais: RinsEsquerdoDireito.RimEsquerdo,


      PossuiCalculo1: false,
      DimensaoCalculo1: 10,
      PosicaoCalculo1: RinsAlturaPosicao.Superior,
      RimCalculo1: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCalculo2: false,
      DimensaoCalculo2: 10,
      PosicaoCalculo2: RinsAlturaPosicao.Superior,
      RimCalculo2: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCalculo3: false,
      DimensaoCalculo3: 10,
      PosicaoCalculo3: RinsAlturaPosicao.Superior,
      RimCalculo3: RinsEsquerdoDireito.RimEsquerdo,

      PossuiCalculo4: false,
      DimensaoCalculo4: 10,
      PosicaoCalculo4: RinsAlturaPosicao.Superior,
      RimCalculo4: RinsEsquerdoDireito.RimEsquerdo,

      PossuiVariosCalculosBilaterais: false,
      DimensaoCalculosBilaterais: 10,
      PosicaoCalculosBilaterais: RinsAlturaPosicao.Superior,
      RimCalculosBilaterais: RinsEsquerdoDireito.RimEsquerdo,

      PossuiMicroCalculosBilaterais: false,

      DilatacaoPielocalcinalDireita: RinsDilatacaoPielocalcinal.Ausente,
      DilatacaoPielocalcinalEsquerda: RinsDilatacaoPielocalcinal.Ausente,

      AdicionarUretralDilatacaoDireita: false,
      AdicionarUretralDilatacaoEsquerda: false,

      PossuiCalculoUretral: false,
      DimensaoCalculoUretral: 6,

      PosicaoCalculoUretral: RinsPosicaoCalculoUretral.TercoDistalUreter,
      CalculoUretralDireitoEsquerdo: RinsEsquerdoDireito.RimEsquerdo
    } as RinsUreteres;

    this.rinsUreteresChange.emit(this.rinsUreteres);
  }




  constructor() { }



}
