import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TicketListComponent } from './ticket-list/ticket-list.component';
import { AuthGuard } from './_guards/auth.guard';
import { MemberListComponent } from './members/member-list/member-list.component'

// define app routes in Routes array
export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent},
    { path: 'tickets', component: TicketListComponent, canActivate: [AuthGuard]},
    { path: 'lists', component: MemberListComponent, canActivate: [AuthGuard]},
    { path: '**', redirectTo: 'home', pathMatch: 'full'}
   
]

