# Restaurant Web Application

This is a simple **ASP.NET MVC** project designed to showcase the frontend of a restaurant's website along with a basic backend form for data management. The backend is powered by **SQL Server Management Studio**.

---

## Features

### Frontend
- Responsive webpages built using **ASP.NET MVC Razor Views**.
- Includes the following pages:
  - **Catering** (`Catering.cshtml`)
  - **Feedback** (`Feedback.cshtml`)
  - **Galley** (`Galley.cshtml`)
  - **Menu** (`Menu.cshtml`)
  - **Home** (`Index.cshtml`)
- Master page implementation via `_Layout.cshtml` for a consistent UI structure.

### Backend
- A simple backend form to handle user or restaurant-related data.
- Integrated with **SQL Server Management Studio** for database handling.

---

## Project Structure
- **Controllers**: Contains `HomeController.cs` to manage routing and view rendering.
- **Views**:
  - `Home`: Contains the main pages of the application.
  - `Shared`: Contains shared components like `_Layout.cshtml` and error handling.
- **Models**: Placeholder for potential future data models.
- **Content**: Static assets like CSS files.
- **Scripts**: JavaScript files to enhance interactivity.

---

## Requirements
- **Visual Studio 2022** or higher.
- **SQL Server Management Studio** for database management.
- **ASP.NET MVC Framework**.

---

## How to Run
1. Clone the repository to your local system.
2. Open the solution file (`Restaurant.sln`) in Visual Studio.
3. Configure the connection string in `Web.config` to point to your SQL Server database.
4. Build the solution and run the project.

---

## Acknowledgements
This project is built as a practice application to understand the implementation of **ASP.NET MVC** with a simple frontend and backend integration.
