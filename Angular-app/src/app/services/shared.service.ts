import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl="http://localhost:34814/api";
  header: any;

  constructor(private http:HttpClient) { 
    const headerSettings: {[name: string]: string | string[]; } = {};  
    this.header = new HttpHeaders(headerSettings);
  }

  getBuyers():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/buyers');    
  }

  getBuyerProfile(buyerinfo: Array<string>){
    return this.http.get(this.APIUrl + '/buyers/'+ buyerinfo[0]);    
  }

  loginUser(logininfo: Array<string>){
    return this.http.post(this.APIUrl + '/users/login', {
      LoginName: logininfo[0],
      PasswordHash: logininfo[1],
      EmpType: logininfo[2]
    },
    {
      responseType: "text",
    })
  }

  getCars():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/cars');    
  }
}
