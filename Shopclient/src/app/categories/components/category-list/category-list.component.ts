import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../../common/models/category';
import { FeaturedCategory } from '../../common/models/featuredCategory';
import { CategoryService } from '../../services/category.service';

@Component({
  selector: 'CategoryList',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.scss']
})
export class CategoryListComponent implements OnInit{
  public categories$ : Observable<FeaturedCategory[]> | undefined = undefined;

  constructor(private categoryService: CategoryService) {}

  ngOnInit(): void {
    this.categories$ = this.categoryService.getFeaturedCategories();
  }
}
