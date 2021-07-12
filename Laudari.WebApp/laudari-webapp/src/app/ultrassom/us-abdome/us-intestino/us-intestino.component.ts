import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Intestino } from '../../../core/models/ultrassom/Intestino/intestino';
import { TipoDiverticulite } from '../../../core/models/ultrassom/Intestino/intestino.enum';

@Component({
  selector: 'app-us-intestino',
  templateUrl: './us-intestino.component.html',
  styleUrls: ['./us-intestino.component.css']
})
export class UsIntestinoComponent implements OnInit {

  @Input() intestino: Intestino;
  @Output() intestinoChange = new EventEmitter();

  constructor() { }

  tipoDiverticulite: Object[] = [
    { ID: TipoDiverticulite.Sigmoide, Nome: 'sigmoide' },
    { ID: TipoDiverticulite.ColonDescendente, Nome: 'cólon descendente' }
  ];

  ngOnInit() {
    this.intestino = {
      Apendicite : false,
      Calibre:7,
      ApendiceColecao: false,
      Diverticulite: false,
      TipoDiverticulite : TipoDiverticulite.Sigmoide,
      ColecaoDiversiculite: false,
    } as Intestino;

    this.intestinoChange.emit(this.intestino);
  }

}
