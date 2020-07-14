import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}; // object created for storing form values 

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  // login method
  login() {
    this.authService.login(this.model).subscribe(
      next => console.log('logged in successfully'),
      err => console.log(err)
    )
  }; 

  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

  logout() {
    localStorage.removeItem('token');
    console.log('logged out');
  }

}
