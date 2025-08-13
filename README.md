# 🚚 eShift Desktop Application

## 📌 Overview
eShift is a **C# WinForms** based **3-Tier Architecture** desktop application designed to streamline logistics and transport operations.  
The system manages customers, jobs, job loads, transport units, dashboard analytics, and generates detailed reports.  
It is built with a **MySQL** backend for secure and reliable data management.

---

## 🛠 Tech Stack
- **Frontend (UI Layer)**: C# WinForms
- **Business Logic Layer (BLL)**: Service classes for handling business rules
- **Data Access Layer (DAL)**: MySQL database with Repository pattern
- **Database**: MySQL (local instance)
- **Architecture**: 3-Tier Layered Architecture
- **Reporting**: PDF Export via PdfSharp

---

## ✨ Features
- 🔐 **Secure Login & Authentication** (Default admin: `admin` / `admin123`)
- 👥 **Customer Management** (Add, update, delete customers)
- 📋 **Jobs Management** (Track job status & details)
- 📦 **Job Load Management** (Assign loads to jobs with transport units)
- 🚛 **Transport Unit Management** (Manage lorry plates, drivers, assistants)
- 📊 **Dashboard Analytics** (Recent jobs, statistics)
- 📑 **Reports** (Export Customers, Jobs, Loads, Units to PDF)
- 🔄 **Live Updates** across all modules when data changes

---

## 📂 Project Structure
eShiftApp/
│
├── BusinessLogic/
│ ├── Interfaces/ # Interfaces for service contracts
│ └── Services/ # Implementation of business logic
│
├── DataAccess/
│ ├── Interfaces/ # Repository interfaces
│ └── Repositories/ # MySQL repository implementations
│
├── Entities/
│ └── Models/ # POCO classes (Entities, DTOs)
│
├── eShiftApp/Forms/ # WinForms UI (LoginForm, MainForm, etc.)
│
└── Database/
└── eShift.sql # MySQL database schema & sample data

---

## ⚙️ Installation & Setup
1. **Clone the repository**  
   ```bash
   git clone https://github.com/YOUR-USERNAME/eShift.git
   cd eShift
2.**Import the Database**
Open MySQL Workbench or phpMyAdmin
Create a database:
  CREATE DATABASE eshift;
Import the provided eShift.sql file into the eshift database.
3.**Configure Connection String**
Open DataAccess/Repositories/DbConnection.cs
Update:
  private const string CONNECTION_STRING = "Server=localhost;Database=eshift;User=root;Password=;";
4.**Run the Application**
Open the solution in Visual Studio
Set eShiftApp as the startup project
Press F5 to build and run.

## 🔑 Default Login
Username: admin
Password: admin123

## 👩‍💻 Author
Developed by Sanki Kavindhya

