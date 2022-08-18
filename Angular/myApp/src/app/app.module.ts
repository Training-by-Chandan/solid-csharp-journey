import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ButtonComponent } from './comp/button/button.component';
import { CardComponent } from './comp/card/card.component';
import { HeaderComponent } from './comp/header/header.component';
import { SidebarComponent } from './comp/sidebar/sidebar.component';
import { StCreateComponent } from './student/st-create/st-create.component';
import { StListComponent } from './student/st-list/st-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SidebarComponent,
    ButtonComponent,
    CardComponent,
    StListComponent,
    StCreateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule, 
    ReactiveFormsModule, 
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
