import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  currentUser: BehaviorSubject<any> = new BehaviorSubject(null);

  serverUrl = "https://localhost:34814/api/"

  jwtHelperService = new JwtHelperService();

  registerUser(user : Array<String>){
    return this.http.post(this.serverUrl + "UserControler/CreateUser",{
      FirstName: user[0]
    }, 
    {responseType:'text',
  });
  }
  loginUser(logininfo:Array<string>){
    return this.http.post(this.serverUrl + 'users/login',{
      LoginName:logininfo[0],
      Password: logininfo[1],
      EmpType: logininfo[2]
    },
    {
      responseType:'text',
    })
  }

  setToken(token:string){
    localStorage.setItem("access_token", token);
    this.loadCurrentuser()
  }

  loadCurrentuser(){
    const token = localStorage.getItem("access_token");
    const userInfo = token != null ? this.jwtHelperService.decodeToken(token) : null;

    this.currentUser.next(userInfo);
  }

  isLoggedin(){
    return localStorage.getItem("access_token")? true : false;
  }

  removeToken(){
    localStorage.removeItem("access_token");
  }
}
