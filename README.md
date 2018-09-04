# MVC-Book-Rental-Store
ASP .NET project using MVC pattern.
This project has been completed following up "Complete ASP.NET MVC course in C#" by Bhrugen Patel at Udemy.com with some customization.
The goal of project was to create a full-featered web-application of Book Library, who offers to users the opportunity to rent a book.

The project utilizes:
1. Front-end:
- bootstrap design based on external template, not the one that is default in Visual Studio MVC project;
- customized buttons implemented as shared views;
- several customized css styles, buttons, divs etc, in additional .css files;
- javascript for drop-down menues and text-autocompletion in login forms.

2. MVC and SQL part:
- database tables and respective models for Book, Genre, BookRental status, customized UserAccount table;
- code-first approach in database management;
- implementation of foreign keys and viewmodels;
- implementation of all CRUD operations.

3. Registration and Authorization:
- regular Users and Admin accounts;
- differentiated views for guest (not signed in), user and admin, with different UI;
- opportunity to sign in using Facebook or Google.

The logic of application is following:
The Library offers rental service for books. Guest cat view the books available in the Library.
Registered user can choose and apply for rent of the book/books. Administrator must approve the users request,
mark it as picked up, returned or lost. Database keeps track of number of books available.

Enjoy!
Alex B
