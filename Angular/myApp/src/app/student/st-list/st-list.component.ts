import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/models/student';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-st-list',
  templateUrl: './st-list.component.html',
  styleUrls: ['./st-list.component.css']
})
export class StListComponent implements OnInit {
   students: Student[];
  constructor(private stService :StudentService) { }

  ngOnInit(): void {
    this.getStudentList();
  }

  getStudentList(){
    this.stService.getStudents().subscribe(data => {
      this.students = data;
    });
  }

}
