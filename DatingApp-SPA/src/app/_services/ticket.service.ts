import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';

// this service will allow us to retrieve users from the API
const httpOptions = { // to ensure our calls have the auth header necessary
  headers: new HttpHeaders({
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class TicketService {
  baseUrl = environment.apiUrl;

constructor(private http: HttpClient) { }

addTicket(model: any) {
  return this.http.post(this.baseUrl + "ticket", model, httpOptions);
}

}


