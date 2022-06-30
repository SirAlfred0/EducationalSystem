import { ApiService } from './../../Services/api.service';
import { DefineClassDto } from './../../Dtos/DefineClassDto';
import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Events } from 'src/app/Enums/Events';

@Component({
  selector: 'app-define-class',
  templateUrl: './define-class.component.html',
  styleUrls: ['./define-class.component.css']
})
export class DefineClassComponent implements OnInit {

  className = new FormControl();
  classCapacity = new FormControl();

  constructor(private api: ApiService) { }

  ngOnInit(): void {
  }


  DefineClass()
  {
    var cls = new DefineClassDto();

    cls.Name = this.className.value;
    cls.Capacity = this.classCapacity.value;

    this.api.Send(Events.DefineClass,cls);
  }
}
