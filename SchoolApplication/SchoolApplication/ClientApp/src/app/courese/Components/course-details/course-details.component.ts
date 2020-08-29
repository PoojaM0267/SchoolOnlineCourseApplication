import { Course } from "src/app/shared/api/course";
import { CourseService } from "src/app/shared/api/course";
import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { Route } from "@angular/compiler/src/core";
import { ActivatedRoute, Router } from "@angular/router";
import { switchMap } from "rxjs/operators";

@Component({
  selector: "app-course-details",
  templateUrl: "./course-details.component.html",
  styleUrls: ["./course-details.component.css"],
})
export class CourseDetailsComponent implements OnInit {
  courese: Observable<Course>;
  constructor(
    private courseService: CourseService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.courese = this.route.paramMap.pipe(
      switchMap((route) => {
        return this.courseService.getCourseById(route.get("id"));
      })
    );
  }
}
