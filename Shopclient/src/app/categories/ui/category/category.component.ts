import { Component, Input } from '@angular/core';
import { Category } from '../../common/models/category';
import { FeaturedCategory } from '../../common/models/featuredCategory';

@Component({
  selector: 'Category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent {

  @Input() category! : FeaturedCategory;
}
