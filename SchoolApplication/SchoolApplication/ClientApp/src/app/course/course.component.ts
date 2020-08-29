import { Component, OnInit, Inject } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { CourseModel } from './course.model';
@Component({
  selector: 'app-course',
  templateUrl: './course.component.html'
})

export class CourseComponent implements OnInit {
  title = 'School App';
  baseUrl: string;
  httpClient: HttpClient;

  courses: CourseModel[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
    this.httpClient = http;
  }

  ngOnInit() {
        const url = `${this.baseUrl}api/Course`;

        //this.httpClient.get<CourseModel[]>(url).subscribe((result: CourseModel[]) => {
        //  this.courses = result;
        //}, error => console.error(error));

    this.httpClient.get<CourseModel[]>(url).subscribe((result: CourseModel[]) => {
        this.courses = result;
      }, error => console.error(error));
  }
}
