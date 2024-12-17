import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  constructor(private authService: AuthService) {}


  isUserAuthenticated() {
    return this.authService.isAuthenticated();
  }
  NotAuthenticated(){
    return this.authService.logout();
  }

}
