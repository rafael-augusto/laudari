import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { VolumeVesical } from '../../../core/models/ultrassom/volumeVesical/volume-vesical';


@Component({
  selector: 'app-us-volume-vesical',
  templateUrl: './us-volume-vesical.component.html',
  styleUrls: ['./us-volume-vesical.component.css']
})
export class UsVolumeVesicalComponent implements OnInit {


  @Input() volumeVesical: VolumeVesical;
  @Output() volumeVesicalChange = new EventEmitter();

  constructor() { }

  ngOnInit() {

    this.volumeVesical = {
      DimensaoAVolMiccional: 80,
    DimensaoBVolMiccional:80,
    DimensaoCVolMiccional: 80,
    EspessuraVolMiccional: 268,
    
    NaoCitarVolMiccional : true,

    DimensaoAResiduo: 0,
    DimensaoBResiduo:0,
    DimensaoCResiduo: 0,
    EspessuraResiduo: 0,

    NaoCitarResiduo:true,

    } as VolumeVesical;

    this.volumeVesicalChange.emit(this.volumeVesical);    

  }

}
