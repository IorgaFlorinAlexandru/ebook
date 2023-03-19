import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryMenuComponent } from './components/category-menu/category-menu.component';



@NgModule({
  declarations: [
    CategoryMenuComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CategoryMenuComponent
  ]
})
export class CategoriesModule { }
