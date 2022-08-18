import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Response } from '../models/response';
import { Student } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  private baseurl: string = 'https://localhost:7264/';
  constructor(private http:HttpClient) { }

  getStudents() {
    return this.http.get<Student[]>(this.baseurl + 'api/student/get-all');
  }

  createStudent(student: Student) {
    return this.http.post<Response>(this.baseurl + 'api/student/create-student', student);
  }

}
