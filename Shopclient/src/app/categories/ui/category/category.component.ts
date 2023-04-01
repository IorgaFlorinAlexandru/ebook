import { Component, Input } from '@angular/core';
import { Category } from '../../common/models/category';

@Component({
  selector: 'Category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent {

  @Input() category! : Category
}
