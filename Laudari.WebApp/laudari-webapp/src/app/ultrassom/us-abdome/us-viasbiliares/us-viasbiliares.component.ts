import { Component, OnInit, EventEmitter, Input, Output } from '@angular/core';
import { ViasBiliares } from '../../../core/models/ultrassom/viasBiliares/viasBiliares';
import { ViasBiliaresColedoco } from '../../../core/models/ultrassom/viasBiliares/viasBiliares.enum';
import { BilisColedoco } from '../../../core/models/ultrassom/bilis/bilis.enum';

@Component({
  selector: 'app-us-viasbiliares',
  templateUrl: './us-viasbiliares.component.html',
  styleUrls: ['./us-viasbiliares.component.css']
})
export class UsViasbiliaresComponent implements OnInit {
  @Input() viasBiliares: ViasBiliares;
  @Output() viasBiliaresChange = new EventEmitter();

  constructor() { }


  changeCitarCalibre(){
    if(this.viasBiliares.Coledoco == 1)
        this.viasBiliares.CitarCalibre = true;
  }


  ngOnInit() {

   this.viasBiliares = {
      Coledoco: ViasBiliaresColedoco.Normal,
      Calibre: 6,
      DimensaoCalculo: 4
    } as ViasBiliares;

    this.viasBiliaresChange.emit(this.viasBiliares);
  }

}
