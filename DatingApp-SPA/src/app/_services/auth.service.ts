import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = 'http://localhost:5000/api/auth/';

constructor(private http: HttpClient) { }

// pipe allows us to chain 
login(model: any) {
  return this.http.post(this.baseUrl + 'login', model) // returns the response body as a JSON object 
    .pipe( // allows us to chain rxjs operators 
      map((response: any) => {
        const user = response;
        if (user) {
          localStorage.setItem('token', user.token); // stores token locally
        }
      })
    );
}
}
