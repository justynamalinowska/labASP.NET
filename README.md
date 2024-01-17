# Laboratorium3 Product Management System - ASP.NET Core

This repository contains a product management system developed using ASP.NET Core. The application enables users to handle products, producers, and countries. Additionally, users can interact with the system by adding products to their favorites.

### Technologies

The Laboratorium3 Product Management System was built using the following technologies:

- **ASP.NET**: Version 7.0
- **Database**: SQLite
- **Additional Libraries**: Entity Framework Core, xUnit, FontAwesome (for icons)

### Sample User Data

To facilitate testing of the application, sample user data is available:

1. **Admin**:
   - **Username**: justyna
   - **Email**: justyna.malinowska2001@op.pl
   - **Password**: 123ABC!@#

2. **User**:
   - **Username**: marek
   - **Email**: marek@wsei.pl
   - **Password**: 123ABC!@#

### Running the Application (Developer Version)

1. **Clone the project from the GitHub repository:**

   ```bash
   git clone https://github.com/your-username/Laboratorium3_Product.git
   ```
   
1. Open the project in Visual Studio.
2. Execute migrations and update the database:

  ```bash
  dotnet tool install --global dotnet-ef
  ```

3. Open the project in Visual Studio.
4. Execute migrations and update the database:
   
  ```bash
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet ef migrations add NewMigration
  dotnet ef database update
  ```

5. Run the application:
  - Press F5 in Visual Studio or
  - Use the command:
    
  ```bash
  dotnet run
  ```

### Features

The Laboratorium3 Product Management System offers the following features:

- **Product Management**: Adding, editing, and deleting products from the database.
- **Producer Management**: Adding, editing, and deleting producers from the database.
- **Country Management**: Adding, editing, and deleting countries from the database.
- **Favorite Products**: Users can add products to favorites and remove them from the favorites list.

### Usage

Upon launching the application, you will be presented with a main window interface. The main window contains several buttons to navigate to different sections of the application:

- **Products**: Clicking this button will open the product management section where you can add, edit, or delete product records.
- **Producers**: Clicking this button will open the producer management section where you can manage producer records.
- **Countries**: This button allows you to access the country management section where you can view and manage country details.
- **Favorites**: Clicking this button will take you to the favorites section where you can view and manage your favorite products.

To perform specific actions within each section, follow the instructions provided on the respective screens. You can add, edit, and delete records as needed.

### License

This project is licensed under the MIT License.



