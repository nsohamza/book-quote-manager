
import { Component, OnInit } from '@angular/core';
import { QuoteService } from '../../services/quote.service';
import { Quote } from '../../models/quote.model';
import { quoteDTO } from '../../models/quoteDTO.model';  // Import the DTO

@Component({
  selector: 'app-quotes',
  templateUrl: './quotes.component.html',
  styleUrls: ['./quotes.component.css']

})
export class QuotesComponent implements OnInit {
  quotes: Quote[] = [];
  newQuote: quoteDTO = { text: '' };  // Initialize newQuote with text only

  constructor(private quoteService: QuoteService) {}

  ngOnInit() {
    this.loadQuotes();
  }

  loadQuotes() {
    this.quoteService.getQuotes().subscribe(quotes => this.quotes = quotes);
  }
addQuote() {
  if (this.newQuote.text) {
    this.quoteService.addQuote({ text: this.newQuote.text }).subscribe({
      next: (quote) => {
        this.quotes.push(quote); // Add the newly created quote to the list
        this.newQuote = { text: '' }; // Clear the input field
      },
      error: (err) => {
        console.error('Error adding quote:', err); // Handle errors (e.g., show a toast notification)
      }
    });
  }
}
     
}