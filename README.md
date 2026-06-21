Storage Management Module
Description

- Storage Management Module is an ASP.NET Core MVC application developed in C# for managing inventory in a warehouse system.

The application allows users to:

- Add new products
- Edit existing products
- Delete products
- Search products by name
- Filter products by quantity
- View inventory reports
- Store and retrieve data from SQL Server database
- Technologies Used:
*.NET 8
*ASP.NET Core MVC
*Entity Framework Core
*SQL Server
*Repository Pattern
*Service Layer Architecture
*Product Information

Each product contains:

Id,
Name,
ImageUrl,
Supplier,
Manufacturer,
Product Type,
Description,
Quantity,
Price,
CreatedOn,
UpdatedOn,

- Setup Instructions:

* Open the solution in Visual Studio.
* Update the connection string in appsettings.json if necessary.
* Run the following commands:
  Add-Migration "Initial"
  Update-Database
* Open the application in your browser.

- Additional Information:

* Initial product data is automatically seeded from:

* StorageManagement.Infrastructure/Seeding/SeedData/products.json

- The application follows a layered architecture consisting of:

* Web Layer
* Service Layer
* Repository Layer
Data Layer
Infrastructure Layer
