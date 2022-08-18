import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Student } from 'src/app/models/student';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-st-create',
  templateUrl: './st-create.component.html',
  styleUrls: ['./st-create.component.css']
})
export class StCreateComponent implements OnInit {
  forms=new FormGroup({
    name:new FormControl(''),
    email:new FormControl(''),
    phoneNumber:new FormControl(''),
    classId:new FormControl('')

  });
  constructor(private studentService:StudentService) { }

  ngOnInit(): void {
  }
  CreateStudent(){
    let student=new Student();
    student.name=this.forms.value.name;
    student.email=this.forms.value.email;
    student.phoneNumber=this.forms.value.phoneNumber;
    student.classId=this.forms.value.classId;

    this.studentService.createStudent(student).subscribe(data=>{
      if(data.status){
        window.location.reload();
      }
      else{
        alert(data.message);
      }
    });
  }

}
