import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  
  constructor(private authService : AuthService){

  }   
  
  ngOnInit(): void{

  }

  registerForm = new FormGroup({
    firstname: new FormControl('', [Validators.required]),
    lastname: new FormControl('', [Validators.required]),
    loginName: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required, Validators.minLength(6), Validators.maxLength(24)]),
    repPass: new FormControl('', [Validators.required])
  });

  onSubmit(){
    console.log(this.registerForm)
    this.authService.registerUser([
      // this.registerForm.value.firstname,
      // this.registerForm.value.lastname,
      // this.registerForm.value.loginName,
      // this.registerForm.value.password,
      // this.registerForm.value.repPass,
    ]).subscribe(res=>{
      console.log(res);
    })
    // if(this.password.value == this.repPass.value)
  }
  get FirstName(): FormControl{
    return this.registerForm.get("firstname") as FormControl;
  }
}
