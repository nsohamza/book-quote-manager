import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from './services/auth.service';


@Injectable({
  providedIn: 'root',
})
export class AuthInterceptor implements HttpInterceptor {

  constructor(private authService: AuthService) {}
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

   const token = this.authService.getToken();

    console.log('Token retrieved:', token);

    // If a token exists, clone the request and set the Authorization header
     if (token) {
      const cloned = request.clone({
        setHeaders: {
          Authorization:`Bearer ${token}`
        }
      });
       console.log('Cloned Request with Authorization Header:', cloned);
       return next.handle(cloned);
    }
    // Pass the cloned request instead of the original request to the next handler
   return next.handle(request);
  }

}



