
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Book } from '../models/book.model'; // Importing the Book model

@Injectable({
  providedIn: 'root',
})
export class BookService {
  private apiUrl = '/api/books'; // Proxy path

  constructor(private http: HttpClient) {}

  // Method to get all books
  getBooks(): Observable<Book[]> {
    return this.http.get<Book[]>(this.apiUrl).pipe(
      catchError(error => {
        console.error('Error fetching books', error);
        return of([]); // Return an empty array on error
      })
    );
  }

  // Method to get a specific book by ID
  getBookById(id: number): Observable<Book> {
    return this.http.get<Book>(`${this.apiUrl}/${id}`).pipe(
      catchError(error => {
        console.error('Error fetching book', error);
        return of({} as Book); // Return an empty book object on error
      })
    );
  }

  // Method to add a new book
  addBook(book: Book): Observable<Book> {
    return this.http.post<Book>(this.apiUrl, book);
  }

  // Method to update an existing book
  updateBook(id: number, book: Book): Observable<Book> {
    return this.http.put<Book>(`${this.apiUrl}/${id}`, book);
  }

  // Method to delete a book by ID
  deleteBook(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
  
  // Method to validate book details
  validateBook(book: Book): boolean {
    return book.title.trim() !== '' && book.author.trim() !== '';
  }
}
