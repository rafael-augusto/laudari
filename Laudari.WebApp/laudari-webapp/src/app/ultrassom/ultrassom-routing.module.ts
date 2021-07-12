import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UsAbdomeComponent } from './us-abdome/us-abdome.component';
import { AuthGuard } from '../core';

const routes: Routes = [
  {
    path: '',
    component: UsAbdomeComponent
    //canActivate: [AuthGuard]
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UltrassomRoutingModule { }
