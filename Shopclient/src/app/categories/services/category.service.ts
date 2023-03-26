import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { Category } from '../common/models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private categories$ = new BehaviorSubject<Category[]>([]);

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
        (a,b) => a.name.localeCompare(b.name)
      ))
    );
  }

}
