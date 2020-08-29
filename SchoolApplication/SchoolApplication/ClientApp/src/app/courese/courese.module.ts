import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { CoureseRoutingModule } from "./courese-routing.module";
import { CourseListComponent } from "./Components/course-list/course-list.component";
import { CourseDetailsComponent } from "./Components/course-details/course-details.component";
import { SharedModule } from "../shared/shared.module";

@NgModule({
  imports: [CommonModule, CoureseRoutingModule, SharedModule],
  declarations: [CourseListComponent, CourseDetailsComponent],
})
export class CoureseModule {}
