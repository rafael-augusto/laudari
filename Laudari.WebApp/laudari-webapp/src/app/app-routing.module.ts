import { NgModule } from '@angular/core';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';
import { UltrassomModule } from './ultrassom/ultrassom.module';

const routes: Routes = [
  {
    path: 'usabdome',
    loadChildren: () => import('./ultrassom/ultrassom.module').then(m=> m.UltrassomModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)
],
  exports: [RouterModule]
})
export class AppRoutingModule {}
