import { Component, OnInit } from '@angular/core';

import { Pancreas } from '../../core/models/ultrassom/pancreas/pancreas'
import { PancreasClassificacao } from '../../core/models/ultrassom/pancreas/pancreas-classificacao.enum'
import { UsAbdomeService } from './us-abdome.service';
import { Combobox } from '../../core/models/common/combobox';
import { Figado } from '../../core/models/ultrassom/figado/figado';
import { Aorta } from '../../core/models/ultrassom/aorta/aorta';
import { FigadoClassificacao, GrauEsteatose, TipoHepatopatiaCronica, DimensoesDescritivo, SegmentoFigado, ClassificacaoNoduloFigado, ClassificacaoContorno, EnfaseMultiplosNodulos } from '../../core/models/ultrassom/figado/figado.enum';
import { AortaClassificacao, AortaAneurisma, AortaLocalAneurisma } from '../../core/models/ultrassom/aorta/aorta.enum';
import { Baco } from '../../core/models/ultrassom/baco/baco';
import { BacoEcoTextura, BacoClassificacao } from '../../core/models/ultrassom/baco/baco.enum';
import { ViasBiliares } from '../../core/models/ultrassom/viasBiliares/viasBiliares';
import { ViasBiliaresColedoco } from '../../core/models/ultrassom/viasBiliares/viasBiliares.enum';
import { Intestino } from '../../core/models/ultrassom/Intestino/intestino';

import { Vesicula } from '../../core/models/ultrassom/vesicula/vesicula';
import { VesiculaClassificacao } from '../../core/models/ultrassom/vesicula/vesicula.enum';
import { LimitTecnica } from '../../core/models/ultrassom/limitTecnica/limit-tecnica';
import { NgbModal } from '../../../../node_modules/@ng-bootstrap/ng-bootstrap';
import { Bexiga } from '../../core/models/ultrassom/bexiga/bexiga';
import { RinsUreteres } from '../../core/models/ultrassom/rinsUreteres/rins-ureteres.enum';
import { LiquidoLivre } from '../../core/models/ultrassom/liquidoLivre/liquido-livre';
import { VolumeVesical } from '../../core/models/ultrassom/volumeVesical/volume-vesical';



@Component({
  selector: 'app-us-abdome',
  templateUrl: './us-abdome.component.html',
  styleUrls: ['./us-abdome.component.css']
})

export class UsAbdomeComponent implements OnInit {
  laudo: string = "";


  figado: Figado;

  intestino: Intestino;

  bexiga: Bexiga;

  liquidoLivre: LiquidoLivre;

  volumeVesical: VolumeVesical;

  aorta: Aorta = {
    Classificacao: AortaClassificacao.Normal,
    Calibre: 16,
    TipoAneurisma: AortaAneurisma.Fusiforme,
    LocalAneurisma: AortaLocalAneurisma.Infrarenal,
    VPS: 100,
    CalibreAneurisma: 31,
    ExtensaoAneurisma: 40,

  } as Aorta;

  tipoAneurisma: Object[] = [
    { ID: AortaAneurisma.Fusiforme, Nome: 'Fusiforme' },
    { ID: AortaAneurisma.Secular, Nome: 'Secular' }
  ];

  localAneurisma: Object[] = [
    { ID: AortaLocalAneurisma.Infrarenal, Nome: 'Infrarenal' },
    { ID: AortaLocalAneurisma.TercoMedio, Nome: 'Terco Medio' },
    { ID: AortaLocalAneurisma.TercoProximal, Nome: 'Terco Proximal' },
    { ID: AortaLocalAneurisma.TercoDistal, Nome: 'Terco Distal' },
    { ID: AortaLocalAneurisma.JuntoBifurcacao, Nome: 'Junto à Bifurcacao' }
  ];


  vesicula: Vesicula = {
    Classificacao: VesiculaClassificacao.Normal,
    DimensaoCalculo: 7,
    DimensaoCalculoA: 3,
    DimensaoCalculoB: 4,
    DimensaoPolipo: 3,
    DimensaoPolipoMaior: 4
  } as Vesicula;

  limitacaoTecnica: LimitTecnica;

  rinsUreteres: RinsUreteres;

  viasBiliares: ViasBiliares;

  pancreas: Pancreas;

  baco: Baco;


  constructor(
    private usAbdomeService: UsAbdomeService,
    private modalService: NgbModal
  ) { }


  openModal(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title',size: 'lg' }).result.then((result) => {
        if(result == "Print")
        {
          var w=window.open();
          w.document.write(this.laudo);
          w.print();
          w.close();
        }
    }, (reason) => {

    });
  }




  novoLaudo(){
    window.location.reload();
  }

  gerarLaudo(content) {

      var a = this.usAbdomeService.gerar(
      { 
          UsLimitacoesTecnicas: this.limitacaoTecnica, 
          UsPancreas: this.pancreas, 
          UsFigado: this.figado, 
          UsBaco: this.baco, 
          UsVesiculaBiliar: this.vesicula, 
          UsViasBiliares : this.viasBiliares, 
          UsAorta : this.aorta,
          UsIntestino: this.intestino,
          UsBexiga: this.bexiga,
          UsRinsUreteres: this.rinsUreteres,
          UsVolumeVesical: this.volumeVesical,
          UsliquidoLivre: this.liquidoLivre
      }).subscribe(data => 
      {
            this.laudo = data.toString();
            this.openModal(content);
      });


  }

  ngOnInit() {

  }

}
