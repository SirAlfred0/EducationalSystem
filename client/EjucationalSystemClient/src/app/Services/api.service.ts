import { Events } from '../Enums/Events';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


const headers = {
  "Content-Type": "application/json",
};

const api = "https://localhost:7053/";


@Injectable({
  providedIn: 'root'
})

export class ApiService {


  constructor(private http: HttpClient) { }


  public Send(e: Events, message: any): Promise<any>
  {
    var url = api;
    var result = null;
    switch(e)
    {
      case Events.DefineClass:
        url += "defineclass";
        result =  this.Fetch(url,JSON.stringify(message));
        break;
      case Events.GetTeachers:
        url += "getteacherlist";
        result = this.Fetch(url,JSON.stringify(message));
        break;
      case Events.GetStudents:
        url += "getstudentlist";
        result = this.Fetch(url,JSON.stringify(message));
        break;
      case Events.GetClasses:
        url += "getclasslist";
        result = this.Fetch(url,JSON.stringify(message));
        break;
      case Events.CreateClass:
        url += "createclass";
        result = this.Fetch(url,JSON.stringify(message));
        break;
    }
    return result;
  }


  private async Fetch(url: string,data: any)
  {
    let res =  await this.http.post<any>(url,data,{headers: headers}).toPromise();

    return res;
  }
}
