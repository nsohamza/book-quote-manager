import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookListComponent } from './components/book-list/book-list.component';
import { BookFormComponent } from './components/book-form/book-form.component';
import { QuotesComponent } from './components/quotes/quotes.component';
import { LoginComponent } from './components/login/login.component';
import { AuthGuard } from './auth.guard';

const routes: Routes = [
  { path: 'login', component: LoginComponent, title: "Login" },
  { path: 'books', component: BookListComponent,canActivate:[AuthGuard], title: "Book List" },
  { path: 'books/new', component: BookFormComponent, canActivate:[AuthGuard],title: "Add New Book" },
  { path: 'books/edit/:id', component: BookFormComponent,canActivate:[AuthGuard],title: "Edit Book" },
  { path: 'quotes', component: QuotesComponent, canActivate:[AuthGuard],title: "My Quotes" },
  { path: '', redirectTo: '/books',pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }