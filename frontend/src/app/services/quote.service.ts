import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Quote } from '../models/quote.model';
import { quoteDTO } from '../models/quoteDTO.model';  // Import the DTO

@Injectable({
  providedIn: 'root'
})
export class QuoteService {
  private apiUrl = '/api/quotes'; // Adjust to your API endpoint

  constructor(private http: HttpClient) {}

  getQuotes(): Observable<Quote[]> {
    return this.http.get<Quote[]>(this.apiUrl);
  }

 /* addQuote(quoteDto: quoteDTO): Observable<Quote> { // Change parameter to QuoteDTO
    return this.http.post<Quote>(this.apiUrl, quoteDto);
  }*/
    addQuote(quoteDto: { text: string }): Observable<Quote> {
      return this.http.post<Quote>(this.apiUrl, quoteDto);
    }
}