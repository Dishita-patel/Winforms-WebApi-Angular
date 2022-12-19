import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute  } from '@angular/router';
import { SharedService } from 'src/app/services/shared.service';
import { HomeComponent } from '../home/home.component';


@Component({
  selector: 'app-cars-list',
  templateUrl: './cars-list.component.html',
  styleUrls: ['./cars-list.component.css']
})
export class CarsListComponent implements OnInit{

  constructor(
    private sharedService:SharedService, 
    private router:Router, 
    private home:HomeComponent
    ){}   

  ngOnInit(): void{
  }

}
