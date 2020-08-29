export interface Course {
  id: string;
  name: string;
}

export interface CourseApiResponse {
  courses: Array<Course>;
}
