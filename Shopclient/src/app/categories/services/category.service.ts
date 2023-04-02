import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, map, delay, take, first, Observable, concatAll, skip } from 'rxjs';
import { Category } from '../common/models/category';
import { FeaturedCategory } from '../common/models/featuredCategory';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private categories$ = new BehaviorSubject<Category[]>([{ name: "nice", description: "da", id: "asda", isFeatured: false }]);

  constructor(private httpClient: HttpClient) { }

  public init(): void {
    this.httpClient
      .get<Category[]>("http://localhost:5088/api/Category")
      .subscribe((categories) => {
        this.categories$.next(categories);
      });
  }

  public getCategories(): Observable<Category[]> {
    return this.categories$.pipe(
      map((categories) => categories.sort(
        (a, b) => a.name.localeCompare(b.name)
      )),
      // delay(1000)
    );
  }

  public getFeaturedCategories(): Observable<FeaturedCategory[]> {
    return this.categories$.pipe(
      map((categories) => this.convertArray(categories.filter(c => c.isFeatured))),
    );
  }

  private convertArray(categories: Category[]): FeaturedCategory[] {
    let featured: FeaturedCategory[] = [];
    categories.forEach(c => {
      let icon = "";
      let color = "";
      let iconColor = "";
      if(c.name.includes("Health")){
        icon = "monitor_heart";
        color = "#e6f2f4";
        c.name = "Health";
        iconColor = "#00cdef";
      }
      else if(c.name.includes("Arts")){
        icon = "palette";
        color = "#faf1ff";
        iconColor = "#f79e19";
        c.name = "Arts";
      }
      else if(c.name.includes("History")){
        icon = "map";
        iconColor = "#a200fc";
        color = "rgb(228, 226, 230)";
      }
      else if(c.name.includes("Romance")){
        icon = "favorite";
        iconColor = "#f01000";
        color = "#f4e6e5";
      }
      else if(c.name.includes("Travel")){
        icon = "flight";
        iconColor = "#ff8e8e";
        color = "#fff6f6";
      }
      featured.push({id: c.id,name: c.name,icon: icon,color:color,iconColor: iconColor});
    });
    return featured;
  }
}
