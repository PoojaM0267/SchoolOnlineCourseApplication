import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { Course, CourseService } from "src/app/shared/api/course";

@Component({
  selector: "app-course-list",
  templateUrl: "./course-list.component.html",
  styleUrls: ["./course-list.component.css"],
})
export class CourseListComponent implements OnInit {
  courseList: Observable<Course[]>;
  constructor(private courseService: CourseService) {}

  ngOnInit() {
    this.courseList = this.courseService.getCourses();
  }
}
