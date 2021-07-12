import { NgModule } from '@angular/core';
import { SharedModule } from '../shared';
import { UsAbdomeComponent } from './us-abdome/us-abdome.component';
import { UltrassomRoutingModule} from './ultrassom-routing.module';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { AngularEditorModule } from '@kolkov/angular-editor';
import { UsPancreasComponent } from './us-abdome/us-pancreas/us-pancreas.component';
import { UsFigadoComponent } from './us-abdome/us-figado/us-figado.component';
import { UsBacoComponent } from './us-abdome/us-baco/us-baco.component';
import { UsViasbiliaresComponent } from './us-abdome/us-viasbiliares/us-viasbiliares.component';
import { LimitacoesTecnicasComponent } from './us-abdome/limitacoes-tecnicas/limitacoes-tecnicas.component';
import { UsIntestinoComponent } from './us-abdome/us-intestino/us-intestino.component';
import { UsBexigaComponent } from './us-abdome/us-bexiga/us-bexiga.component';
import { UsRinsUreteresComponent } from './us-abdome/us-rins-ureteres/us-rins-ureteres.component';
import { UsLiquidoLivreComponent } from './us-abdome/us-liquido-livre/us-liquido-livre.component';
import { UsVolumeVesicalComponent } from './us-abdome/us-volume-vesical/us-volume-vesical.component';
@NgModule({
  imports: [
    NgbModule,
    SharedModule,
    UltrassomRoutingModule,
    AngularEditorModule
  ],
    declarations: [UsAbdomeComponent, UsPancreasComponent, UsFigadoComponent, UsBacoComponent, UsViasbiliaresComponent, LimitacoesTecnicasComponent, UsIntestinoComponent, UsBexigaComponent, UsRinsUreteresComponent, UsLiquidoLivreComponent, UsVolumeVesicalComponent]
})
export class UltrassomModule { }
