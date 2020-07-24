import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TicketListComponent } from './ticket-list/ticket-list.component';

// define app routes in Routes array
export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent},
    { path: 'tickets', component: TicketListComponent},
    { path: '**', redirectTo: 'home', pathMatch: 'full'}
   
]

