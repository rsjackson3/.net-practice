import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}; // object created for storing form values 

  constructor() { }

  ngOnInit() {
  }

  // login method
  login() {
    console.log(this.model);
  }

}
