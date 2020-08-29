import { CourseListComponent } from "./Components/course-list/course-list.component";
import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { CourseDetailsComponent } from "./Components/course-details/course-details.component";

const routes: Routes = [
  // {
  //   path: "",
  //   component: CourseListComponent,
  // },
  // {
  //   path: "/:id",
  //   component: CourseDetailsComponent,
  // },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CoureseRoutingModule {}
