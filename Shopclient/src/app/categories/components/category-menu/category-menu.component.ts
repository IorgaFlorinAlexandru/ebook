import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../../common/models/category';
import { CategoryService } from '../../services/category.service';

@Component({
  selector: 'CategoryMenu',
  templateUrl: './category-menu.component.html',
  styleUrls: ['./category-menu.component.scss']
})
export class CategoryMenuComponent implements OnInit {
  public categories$ : Observable<Category[]> | undefined = undefined;

  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.categories$ = this.categoryService.getCategories();

    this.categoryService.init();
  }
}
