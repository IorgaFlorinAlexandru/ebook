import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryMenuComponent } from './components/category-menu/category-menu.component';
import { HttpClientModule } from '@angular/common/http';
import { MatListModule } from '@angular/material/list';


@NgModule({
  declarations: [
    CategoryMenuComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MatListModule
  ],
  exports: [
    CategoryMenuComponent
  ]
})
export class CategoriesModule { }
