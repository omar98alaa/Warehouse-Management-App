# 📦 Warehouse Management System

A Windows desktop application built with **.NET 8.0**, **MS SQL Server**, **Entity Framework Core** ,and **Winforms** for managing warehouses, products, inventory movements, and generating insightful reports.

---

## 🚀 Features

This system allows users to efficiently manage warehouse operations, including:

### 🔧 Core Modules
- **Warehouses:** Create and manage multiple warehouse locations.
- **Products:** Register products with relevant metadata (e.g., name, code, expiry date, etc.).
- **Stocks:** Monitor stock levels across warehouses.
- **Imports/Exports:** Record product entries and exits per warehouse.
- **Transfers:** Handle product transfers between warehouses.
- **Suppliers & Clients:** Maintain a database of suppliers and customers.

### 📊 Reporting
- **Warehouse Reports:** View stock and transaction history per warehouse.
- **Product Reports:** Analyze product distribution and stock in selected warehouses.
- **Transaction Reports:** Filter and view transactions in a selected time period across warehouses.
- **Storage Duration:** Track how long items have been stored in a warehouse.
- **Expiration Alerts:** Identify products nearing expiry in a warehouse.

---

## 🛠️ Tech Stack

| Tech            | Description                          |
|-----------------|--------------------------------------|
| .NET 8.0        | Application framework (WinForms)     |
| MS SQL Server   | Relational database backend          |
| EF Core         | ORM for database interaction         |
| WinForms        | UI framework for desktop applications |

---

## 💾 Database

- **Entity Framework Core Migrations** are included in the project for easy setup and updates.
- Ensure MS SQL Server is installed and running before launching the application.

### 🧭 Getting Started

1. **Clone the repository**

2. Configure the database connection string

	Update the connection string in `AppDbContext.cs` in your project with your MS SQL Server connection string.

3. Apply Migrations and Create Database

	```bash
	dotnet ef database update
	```
	Or using `Package manager console`:
	```bash
	update-database
	```

4. Run the application
	- Open the solution in Visual Studio 2022
	- Set the startup project.
	- Press F5 to run.


## 🧪 Screenshots

![app screenshot](./screenshots/app-screenshot.png)
