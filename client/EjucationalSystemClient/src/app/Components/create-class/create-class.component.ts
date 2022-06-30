import { Router } from '@angular/router';
import { CreateClassDto } from './../../Dtos/CreateClassDto';
import { FormControl } from '@angular/forms';
import { ApiService } from './../../Services/api.service';
import { StudentDomain } from './../../domains/StudentDomain';
import { ClassDomain } from './../../domains/ClassDomain';
import { TeacherDomain } from './../../domains/TeacherDomain';
import { Component, OnInit } from '@angular/core';
import { Events } from 'src/app/Enums/Events';


@Component({
  selector: 'app-create-class',
  templateUrl: './create-class.component.html',
  styleUrls: ['./create-class.component.css']
})
export class CreateClassComponent implements OnInit {

  times = [{id: 0, name: "Monday"},{id: 1, name: "Tuesday"},{id: 2, name: "Wednesday"},{id: 3, name: "Thursday"},{id: 4, name: "Friday"},{id: 5, name: "Saturday"}]
  locations = [{id: 0, name: "Hall A"},{id: 1, name: "Hall B"},{id: 2, name: "Hall C"}]

  hallValue;
  timeValue;
  teacherValue;
  classValue;

  public teachers: TeacherDomain[] = [];
  public classes: ClassDomain[] = [];
  private students: StudentDomain[] = [];


  public unsignedStudents: StudentDomain[] = [];
  public signedStudents: StudentDomain[] = [];

  constructor(private api: ApiService,private router: Router) { }

  ngOnInit(): void {
    this.api.Send(Events.GetTeachers, null).then(data => {
      this.teachers = data;
    });
    this.api.Send(Events.GetClasses, null).then(data => {
      this.classes = data;
    });
    this.api.Send(Events.GetStudents, null).then(data => {
      this.students = data;
      this.unsignedStudents = data;
    });
  }

  SignStudent(item: StudentDomain)
  {
    const index = this.unsignedStudents.indexOf(item, 0);
    if (index > -1) {
    this.unsignedStudents.splice(index, 1);
    }

    this.signedStudents.push(item);
  }

  UnsignStudent(item: StudentDomain)
  {
    const index = this.signedStudents.indexOf(item, 0);
    if (index > -1) {
    this.signedStudents.splice(index, 1);
    }

    this.unsignedStudents.push(item);
  }

  CreateClass()
  {
    var cls = new CreateClassDto();

    var stuIds: string[] = [];

    this.signedStudents.forEach(item => {
      stuIds.push(item.id);
    });

    cls.ClassId = this.classValue;
    cls.TeacherId = this.teacherValue;
    cls.Location = this.hallValue;
    cls.Day = this.timeValue;
    cls.StudentsList = stuIds;

    this.api.Send(Events.CreateClass,cls);

    let cU = this.router.url;
    this.router.navigateByUrl('/', {skipLocationChange: true}).then(() => {
        this.router.navigate([cU]);
    });
  }


  NewTeacher(id: any)
  {
    this.teacherValue = id;
  }

  NewClass(id: any)
  {
    this.classValue = id;
  }

  NewTime(id: any)
  {
    this.timeValue = id;
  }

  NewLoc(id: any)
  {
    this.hallValue = id;
  }
}
