import { Course, CourseApiResponse } from "./course.classes";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root",
})
export class CourseService {
  private readonly url: string;
  constructor(private httpClient: HttpClient) {
    this.url = `url`;
  }

  getCourses(): Observable<Course[]> {
    return this.httpClient
      .get<Course>(this.url)
      .pipe(map((response: CourseApiResponse) => response.data));
  }
}
