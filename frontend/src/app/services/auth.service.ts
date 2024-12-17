import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private authUrl = '/api/auth'; // Proxy path
  private readonly TOKEN_KEY = 'token';


  constructor(private http: HttpClient, private router: Router) {}


  login(credentials: { username: string; password: string }): Observable<any> {
    return this.http.post(`${this.authUrl}/login`, credentials).pipe(
      tap((response: any) => {
        if (response.token) {
         this.setToken(response.token);
          this.router.navigate(['/']); // or wherever you want to redirect after login
        }
      })
    );
  }

  isAuthenticated(): boolean {
    return !!this.getToken();
  }
 
  logout(): void {
    this.clearToken();
    this.router.navigate(['/login']);
  }

  getToken(): string | null {
    return localStorage.getItem(this.TOKEN_KEY);
  }

  private setToken(token: string): void {
    localStorage.setItem(this.TOKEN_KEY, token);
  }

  private clearToken(): void {
    localStorage.removeItem(this.TOKEN_KEY);
  }
  
}

