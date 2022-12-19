import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SharedService } from 'src/app/services/shared.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private sharedService:SharedService, private router:Router){}   

  ngOnInit(): void{}

  loginform = new FormGroup({
    loginName:new FormControl("", [Validators.required]),
    password: new FormControl("", [Validators.required, Validators.minLength(6)])
  });
  
  
  isUserValid :boolean =false;

  loginSubmitted(){
    this.sharedService
    .loginUser([this.LoginName.value, this.Password.value, 'Sales'])
    .subscribe(res=>{
      console.log(res)
      if(res == "User successfully logged in"){
        this.isUserValid = true;
        // this.loginAuth.setToken(res)
        this.router.navigateByUrl('/home')
      }
      else{       
        this.isUserValid = false;
        alert('Invalid Username/Password');
      }
    });
  }

  setToken(token:string){
    localStorage.setItem("access_token", token);
  }

  get LoginName(): FormControl{
    return this.loginform.get('loginName') as FormControl;
  }
  get Password(): FormControl{
    return this.loginform.get('password') as FormControl;
  }
}

