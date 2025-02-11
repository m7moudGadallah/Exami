# Exami

## Overview

This project is a desktop application for an Examination System. It has three user roles: **admins, teachers, and students**. **Teachers** can create exams and questions. **Students** can log in securely and take **practice or final exams**. The system also generates exam result reports in different formats.

## Features

### Admin Features

- Manage **subjects, teachers, and students**.
- Assign exams to students.
- Generate exam reports.

### Teacher Features

- Create, edit, and delete **exams**.
- Add, edit, and remove **exam questions**.
- View exam reports.

### Student Features

- **Login** securely.
- View and start available exams.
- Mark **questions inside the exam** with bookmarks for review.
- See **scores and correct answers** after practice exams.

_For more details, Please review [System Requirements Specification Document](./attachments/docs/examination-system-requirements-doc.pdf)_

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core (Windows Forms)
- **Database**: SQL Server (Using ADO.NET for interaction)

## High-Level Architecture

Our project follows a **multi-tier architecture** for better organization:

- **Entities (Data Model)** – Classes that map to database tables.
- **Repository Layer (Data Access Layer)** – Handles database operations using **Entities**.
- **Service Layer (Business Logic)** – Contains the core logic of the system.
- **Presentation Layer (UI)** – The **Windows Forms** application that interacts with users.

![High-Level Architecture](./attachments/imgs/iti-examination-system-architecture.png)

## File Structure

We use a **single .NET solution** with multiple projects, ensuring **a clear separation of concerns** and making development **structured and intuitive**.

### Project Structure

- **Presentation Layer** – A Windows Forms project that handles the user interface.
- **Data Access Layer (Repos)** – Manages database interactions using repositories.
- **Entities (Types/Models)** – Defines data models mapped to database tables.
- **Business Logic Layer (Services)** – Contains the core application logic.
- **Utilities** – A helper project for common functionalities like logging, validation, or configuration.

### Benefits of This Structure

- **Separation of Concerns** – Each layer has a distinct responsibility.
- **Scalability** – Makes future enhancements easier.
- **Maintainability** – Changes in one layer do not affect others.

## Database Design

![Database Design](./attachments/imgs/iti-examination-system-erd.png)

_For more details, Please review [Database Schema in detail using DBML](./attachments/docs/database-erd.dbml)_

## Class Diagram

// will be added later

## UI Design

We designed a **simple and user-friendly** Windows Forms interface, with separate screens for **Admins, Teachers, and Students**.

Each role gets an **easy-to-use interface** tailored to their tasks:

- **Admin Panel** – Manage users, subjects, and assign exams.
- **Teacher Panel** – Create exams, add questions, and view reports.
- **Student Panel** – View and take exams, bookmark questions, and see results.

Check out our [**prototype sketches on Figma**](https://www.figma.com/design/ZzDNDuK7cYCWJH04KFx1Gl/C%23-Project-UI?m=auto&t=BsQYRQdJ5xg0YcA6-1) for a preview of the design.

## Deployment

After development, we will **publish the application as a single executable file**, making installation **simple and user-friendly**.

### Deployment Steps

- **Build the application** in **Release mode**.
- **Use .NET’s Single-File Publishing** to generate a standalone executable.
- **Package the app** with an installer for easy setup.
- **Ensure dependencies** (like SQL Server) are correctly configured.
- **Distribute the installer** to users.

## Conclusion

This **Examination Management System** makes exams **easier to create, take, and manage**. It has a **clear structure** with different roles for **admins, teachers, and students**.

With **secure logins, exam reports, and question bookmarking**, it helps students and teachers **use exams smoothly**. Built with **C#, SQL Server, and Windows Forms**, it is **simple, fast, and reliable**.

## License

This repository is licensed under the MIT License - see the [LICENSE](./LICENSE) file for details.
