
Responsive CRUD application with token management and built in Angular 18 and .NET 8 C# API
You have two weeks to complete this task. The goal is to create a responsive CRUD web application using Angular 18 for the front-end and .NET 8 C# for the back-end API. 

In addition, you will need to implement token management for user verification, use Bootstrap and Font Awesome icons for styling, and add a “My Quotes” page where users can add and view their favorite quotes.

Requirements:
Implement a web application with a page that displays a list of all books. 
Create a home page with a button to add a new book.
Clicking on the “Add new book” button should redirect the user to a form where they can enter information about a new book (e.g. title, author, publication date). 
After submitting the form, the user should be redirected back to the home page, where they can see the new book added to the list. 
Each book in the list should have an 'Edit' button that takes the user to a form where they can edit the details of the book.
After submitting the form, the user should be redirected back to the home page, where they can see the updated book details in the list. 
Each book in the list should have a “Delete” button that allows the user to delete the book. 
After deleting a book, the user should see the book removed from the list.

Token management:
Implement user authentication with JWT (JSON Web Tokens). 
Create a simple login page where users can enter their credentials (e.g. username and password). 
After successful login, the back-end should generate a token and send it back to the front-end. 
The front-end should store the token securely (e.g. in local storage or a cookie) and use it for subsequent API requests to the back-end. Implement token validation on the back-end to ensure that only authenticated users can access the CRUD operations. 

My Citations page:
Create a separate view called “My Quotes”. Display the list of quotes you like. 
There should be a menu so that you can switch between the book view and the quote view


Responsive design testing:
Ensure that the application's layout and components adapt smoothly to different screen sizes, including desktops, tablets, and mobile devices. Test the application by resizing the browser window and verify that all elements adjust correctly. Verify that navigation menus collapse to a responsive mobile menu on smaller screens. Verify that form fields, buttons, and other UI elements maintain proper spacing and alignment across different viewports. Test the application on different devices (e.g. smartphones, tablets) and browsers to ensure consistent behavior.
Bootstrap and Font Awesome:
Use Bootstrap to create a responsive and visually appealing layout for the application. Use Bootstrap classes to design buttons, forms, and other UI components. Include Font Awesome icons to enhance the visual elements of the application. Verify that the Font Awesome icons are displayed correctly and used properly throughout the application.