Responsive CRUD Application with Token Management

Built with Angular 18 (Frontend) and .NET 8 C# API (Backend)

Overview
This project aims to create a responsive CRUD web application using Angular 18 for the frontend and .NET 8 C# for the backend API. The application will include token management for user authentication, utilize Bootstrap for styling, and Font Awesome for icons. Additionally, the application will feature a "My Quotes" page where users can view and add their favorite quotes.

Features
1. Book CRUD Functionality
Home Page: Displays a list of books with the following operations:
Add New Book: Button that redirects to a form to add a new book (fields: title, author, publication date).
Edit Book: Each book has an "Edit" button that redirects to a form where users can modify book details.
Delete Book: Each book has a "Delete" button to remove it from the list.

2. Token Management (JWT Authentication)
User Authentication: Implement login functionality using JWT (JSON Web Tokens).
Simple login page where users enter their credentials (username, password).
After successful login, the backend generates a token and sends it to the frontend.
Frontend stores the token securely (local storage or cookies) and uses it for subsequent API requests.
Token Validation: The backend validates the token to ensure only authenticated users can perform CRUD operations.

3. My Quotes Page
A separate view called “My Quotes” where users can view and manage their favorite quotes.
Include a menu to toggle between the book view and the quote view.

4. Responsive Design
Ensure the application is fully responsive across all screen sizes (desktops, tablets, and mobile devices).
Test the application by resizing the browser window to ensure proper layout adjustment.
Ensure navigation menus collapse into a mobile-friendly version on smaller screens.
Verify proper spacing and alignment of form fields, buttons, and UI elements on different viewports and devices (e.g., smartphones, tablets).

5. Bootstrap and Font Awesome Integration
Bootstrap: Use Bootstrap to create a responsive, visually appealing layout with responsive grids, buttons, and forms.
Font Awesome: Use Font Awesome icons to enhance the UI elements (e.g., for buttons, actions).
Ensure that all icons are properly displayed and used in accordance with the design.

Requirements
Backend: .NET 8 C# API for handling CRUD operations and JWT authentication.
Frontend: Angular 18 for creating the responsive interface and handling API requests.
UI Framework: Bootstrap for responsive design and Font Awesome for icons.