import { CoureseModule } from "./courese/courese.module";
import { CourseListComponent } from "./courese/Components/course-list/course-list.component";
import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { HomeComponent } from "./home/home.component";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { CourseDetailsComponent } from "./courese/Components/course-details/course-details.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    CoureseModule,
    RouterModule.forRoot([
      // { path: "", component: HomeComponent, pathMatch: "full" },
      // { path: "counter", component: CounterComponent },
      // { path: "fetch-data", component: FetchDataComponent },
      {
        path: "",
        component: CourseListComponent,
      },
      {
        path: ":id",
        component: CourseDetailsComponent,
      },
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
