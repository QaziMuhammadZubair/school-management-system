# School Management System (Windows Forms)

A desktop **School Management System** built with **C#**, **Windows Forms (.NET Framework 4.7.2)**, and **SQL Server LocalDB**. It provides a clean graphical interface for managing student admissions and employee records with full CRUD (Create, Read, Update, Delete) and search capabilities.

---

## Features

- **Authentication (`Form1`)**
  - Sign-in screen protecting access to the main dashboard.
- **Main Dashboard (`Menu`)**
  - Centralized navigation for **Student** and **Employee** modules.
- **Student Management**
  - **Admission (`addmission`)**: Register new students with Roll No, Name, Father's Name, Phone Number, Date of Birth, Gender, Class Name, and Address.
  - **Directory, Search & Delete (`stusho`)**: View all students in a `DataGridView`, search by Roll Number, or delete student records.
  - **Update (`stuup`)**: Edit existing student details by Roll Number.
- **Employee Management**
  - **Add Employee (`emad`)**: Register staff/employees with ID, Name, Father's Name, Phone Number, Experience, Gender, Qualification, and Address.
  - **Directory, Search & Delete (`emsho`)**: View all employees in a `DataGridView`, search by Employee ID, or remove records.
  - **Update (`emup`)**: Modify existing employee information by ID.

---

## Tech Stack

- **Language:** C#
- **UI Framework:** Windows Forms (WinForms)
- **Target Framework:** .NET Framework 4.7.2
- **Database:** Microsoft SQL Server LocalDB (`(LocalDB)\MSSQLLocalDB`) with attached `.mdf` database (`schadd.mdf`)
- **Data Access:** ADO.NET (`System.Data.SqlClient`)
- **IDE:** Visual Studio 2017 / 2019 / 2022

---

## Project Structure

```text
WindowsFormsApp1/
├── WindowsFormsApp1.sln              # Visual Studio Solution file
└── WindowsFormsApp1/
    ├── Program.cs                    # Application entry point
    ├── Form1.cs                      # Sign-In / Login form
    ├── Menu.cs                       # Main navigation menu
    ├── addmission.cs                 # Student admission (Create)
    ├── stusho.cs                     # View, search & delete students (Read/Delete)
    ├── stuup.cs                      # Update student details (Update)
    ├── emad.cs                       # Add new employee (Create)
    ├── emsho.cs                      # View, search & delete employees (Read/Delete)
    ├── emup.cs                       # Update employee details (Update)
    ├── schadd.mdf                    # SQL Server LocalDB database file
    ├── schadd_log.ldf                # SQL Server LocalDB transaction log
    ├── App.config                    # Runtime configuration
    └── WindowsFormsApp1.csproj       # C# project file
```

---

## Database Schema

The local database (`schadd.mdf`) uses two main tables:

### 1. `stuadd` (Students)
| Column | Description |
| :--- | :--- |
| `Rollno` | Student Roll Number (`int`, Primary Key / Identifier) |
| `Name` | Student Full Name |
| `Fathername` | Father's Name |
| `Phoneno` | Contact Phone Number |
| `Dateofbirth` | Date of Birth |
| `Gender` | Gender (`Male` / `Female`) |
| `Classname` | Enrolled Class |
| `Address` | Residential Address |

### 2. `emp` (Employees)
| Column | Description |
| :--- | :--- |
| `Id` | Employee ID (`int`, Primary Key / Identifier) |
| `Name` | Employee Full Name |
| `Fathername` | Father's Name |
| `Phoneno` | Contact Phone Number |
| `Exp` | Work Experience |
| `Gender` | Gender (`Male` / `Female`) |
| `Qualification` | Academic / Professional Qualification |
| `Address` | Residential Address |

---

## Getting Started

### Prerequisites

1. **Windows OS**
2. **Visual Studio** (2017, 2019, or 2022) with the **.NET desktop development** workload installed.
3. **SQL Server Express LocalDB** (included with Visual Studio's Data storage and processing / .NET desktop workload).
4. **.NET Framework 4.7.2** Developer Pack / Runtime.

### Installation & Setup

1. **Open the Solution**
   - Open `WindowsFormsApp1.sln` in Visual Studio.

2. **Configure the Database Connection String**
   - The database forms (`addmission.cs`, `stusho.cs`, `stuup.cs`, `emad.cs`, `emsho.cs`, `emup.cs`) reference `schadd.mdf` via `AttachDbFilename`.
   - Update the `AttachDbFilename` path in the connection string to match the location of `schadd.mdf` on your machine, or use `|DataDirectory|\schadd.mdf`:
     ```csharp
     Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\schadd.mdf;Integrated Security=True
     ```

3. **Build and Run**
   - Press **F5** (or click **Start**) in Visual Studio to build and launch the application.

---

## Default Login Credentials

Use the following credentials on the Sign-In screen:

- **Username:** `user`
- **Password:** `123`

