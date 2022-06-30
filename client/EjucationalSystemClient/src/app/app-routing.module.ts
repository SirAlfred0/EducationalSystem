import { CreateClassComponent } from './Components/create-class/create-class.component';
import { DefineClassComponent } from './Components/define-class/define-class.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: '', component: DefineClassComponent},
  {path: 'defineclass', component: DefineClassComponent},
  {path: 'createclass', component: CreateClassComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
