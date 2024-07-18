```markdown
# Contacts Management Web Application
[![image](https://github.com/user-attachments/assets/4b035758-d91e-4e96-8110-62de58c9064c)
](https://private-user-images.githubusercontent.com/117737888/350019813-4b035758-d91e-4e96-8110-62de58c9064c.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3MjEzMTU2MjUsIm5iZiI6MTcyMTMxNTMyNSwicGF0aCI6Ii8xMTc3Mzc4ODgvMzUwMDE5ODEzLTRiMDM1NzU4LWQ5MWUtNGU5Ni04MTEwLTYyZGU1OGM5MDY0Yy5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjQwNzE4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI0MDcxOFQxNTA4NDVaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT03MjhlNTVkMTgyYTE5ZjJjODljOTdiZjE0ZDRhMDc0NzE2ODU3ZDk5MzE2MGEzZTk0YmZjNzlhYjM4YTQ5ZDdhJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCZhY3Rvcl9pZD0wJmtleV9pZD0wJnJlcG9faWQ9MCJ9.8k1gYbvlrsPv7DJhMURrSKbWHD0UnQJV1KDUnVQ7VZw)

This project is a web application built using Angular for the front end and ASP.NET Core for the back end. The application allows users to efficiently manage their contacts by adding and deleting them through a seamless interface using Web APIs.

## Features

- **Add Contacts**: Users can add new contacts to their contact list.
- **Delete Contacts**: Users can delete existing contacts from their contact list.
- **Responsive UI**: The application is designed to work smoothly on various devices and screen sizes.

## Technologies Used

### Front End

- **Angular**: A platform and framework for building single-page client applications using HTML and TypeScript.
- **HTML/CSS**: For structuring and styling the web application.
- **TypeScript**: For enhancing JavaScript with static types.

### Back End

- **ASP.NET Core**: A cross-platform, high-performance framework for building modern, cloud-based, internet-connected applications.
- **Web API**: For creating RESTful services that are used by the front end to manage contacts.

## Prerequisites

- **Node.js** (v14.x or higher)
- **Angular CLI** (v12.x or higher)
- **.NET Core SDK** (v5.0 or higher)
- **SQL Server** (or any other database supported by Entity Framework Core)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/BharghavaKumarPurru/ContactsApp.git
cd ContactsApp
```

### Set Up the Front End

Navigate to the `ClientApp` directory:

```bash
cd ContactsWeb
```

Install the required npm packages:

```bash
npm install
```

Start the Angular development server:

```bash
ng serve
```

### Set Up the Back End

Navigate to the root directory of the project:

```bash
cd ..
```

Restore the required .NET packages:

```bash
dotnet restore
```

Update the database connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your-Database-Connection-String"
  }
}
```

Apply any pending migrations to the database:

```bash
dotnet ef database update
```

Start the .NET development server:

```bash
dotnet run
```

## Usage

1. Open your web browser and navigate to `http://localhost:4200` to access the application.
2. Use the interface to add and delete contacts as needed.


## Contact

If you have any questions or suggestions, feel free to reach out!

- Email: [bhargavbhargav995@gmail.com](mailto:bhargavbhargav995@gmail.com)
- LinkedIn: [Bharghava Kumar Purru](https://www.linkedin.com/in/bharghavakumarpurru)
- GitHub: [BharghavaKumarPurru](https://github.com/BharghavaKumarPurru)
```

Make sure to replace `Your-Database-Connection-String` with the actual connection string for your database and `YourUsername` with your GitHub username. This README file provides a comprehensive overview of the project, setup instructions, usage, and contribution guidelines.
