import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DefineClassComponent } from './Components/define-class/define-class.component';
import { CreateClassComponent } from './Components/create-class/create-class.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CustomSelectComponent } from './Components/SharedComponents/custom-select/custom-select.component';

@NgModule({
  declarations: [
    AppComponent,
    DefineClassComponent,
    CreateClassComponent,
    CustomSelectComponent,

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
