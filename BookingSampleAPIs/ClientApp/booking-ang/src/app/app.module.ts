import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ResourcesComponent } from './components/resources/resources.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import {TableModule} from 'primeng/table';
import {ButtonModule} from 'primeng/button';
import {DialogModule} from 'primeng/dialog';
import { RxReactiveFormsModule } from '@rxweb/reactive-form-validators';
import { CalendarModule } from 'primeng/calendar';
import{DynamicDialogModule}from 'primeng/dynamicdialog'
import { NewBookingFormComponent } from './components/booking/newbooking.component';


@NgModule({
  declarations: [
    AppComponent,
    ResourcesComponent,
    NewBookingFormComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    RxReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
    ToastrModule.forRoot(),
    TableModule,
    ButtonModule,
    DialogModule,
    DynamicDialogModule,
    CalendarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 

}
