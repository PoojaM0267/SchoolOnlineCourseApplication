export interface Course {
  id: string;
  name: string;
}

export interface CourseApiResponse {
  data: Array<Course>;
}
