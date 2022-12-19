import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { SharedService } from 'src/app/services/shared.service'; 

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  buyerData: any=[];

  constructor(private authsService: AuthService, private router:Router, private sharedService: SharedService){}
  ngOnInit(){ 
    this.sharedService.getBuyers().subscribe((data)=>{
      
    console.log(data)
      this.buyerData = data;  
    });
   }

  logout(){
    this.authsService.removeToken();
    this.router.navigateByUrl('login')
  }

  visitProfile(id:any){
    this.sharedService
    .getBuyerProfile([id.value])
    .subscribe(res=>{
      console.log(id)
      this.router.navigateByUrl('/buyer/:id')
      // if(res == 'Failure'){
      //   console.log(res)
      // }
      // else{
      //   console.log(res)
      //   this.isUserValid = true;
      //   // this.loginAuth.setToken(res)
      //   this.router.navigateByUrl('/home')
      //   console.log(this.router.url)
      // }
    });
  }
  

}
