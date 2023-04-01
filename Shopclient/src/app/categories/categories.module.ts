import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryMenuComponent } from './components/category-menu/category-menu.component';
import { HttpClientModule } from '@angular/common/http';
import { MatListModule } from '@angular/material/list';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatRippleModule } from '@angular/material/core';
import { CategoryComponent } from './ui/category/category.component';
import { CategoryListComponent } from './components/category-list/category-list.component';


@NgModule({
  declarations: [
    CategoryMenuComponent,
    CategoryComponent,
    CategoryListComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MatListModule,
    MatGridListModule,
    MatRippleModule,
    MatIconModule,
    MatButtonModule
  ],
  exports: [
    CategoryMenuComponent,
    CategoryListComponent
  ]
})
export class CategoriesModule { }
