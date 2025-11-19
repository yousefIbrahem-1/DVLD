# DVLD – Driver & Vehicle Licensing Department System

Welcome to the **DVLD Management System** — a complete multi-layer .NET application for managing driver licensing and vehicle-related services. This project provides end-to-end functionality for driver management, license issuance/renewal, exam scheduling, application workflows, and administrative reporting.

---

## Table of Contents
1. [Project Overview](#project-overview)  
2. [Architecture](#architecture)  
3. [Technology Stack](#technology-stack)  
4. [Project Structure](#project-structure)  
5. [Features](#features)  
6. [Getting Started](#getting-started)  
7. [Configuration](#configuration)  
8. [Modules & Endpoints](#modules--endpoints)  
9. [Authentication](#authentication)  
10. [Database Setup](#database-setup)  
11. [Services & Integrations](#services--integrations)  
12. [Error Handling](#error-handling)  
13. [Testing](#testing)  
14. [Support](#support)

---

## Project Overview

This project is a full-featured Driver & Vehicle Licensing Management System that implements a **layered architecture** pattern, separating concerns into distinct layers for maintainability, testability, and scalability.

### Key Capabilities:
- **Driver Management**: Create, update, search and maintain driver records and documents  
- **License Management**: Issue, renew, replace and suspend licenses with category rules  
- **Exam Scheduling**: Manage written & practical exams and record results  
- **Application Workflow**: Submit, approve/reject, and track application lifecycle  
- **Reporting**: View history, logs and administrative reports  
- **Extensible Architecture**: Ready to be extended to Web API / Mobile frontends

---

## Architecture

The project follows **Clean / 3-Tier Architecture** principles with the following layers:

### Layer Structure:

1. **DVLD (Presentation Layer)**  
   - WinForms (or WPF) UI  
   - Forms, dialogs and UI helpers  
   - View models / UI controllers

2. **DVLD_Business (Business Layer)**  
   - Business models and entities  
   - Services and managers (DriverService, LicenseService, ExamService)  
   - Validation and workflow rules

3. **DVLD_DataAccess (Data Layer)**  
   - ADO.NET helpers / Repository-style classes  
   - SQL queries and stored procedures  
   - Database connection/configuration

---

## Technology Stack

### Core Technologies:
- **.NET Framework 4.x** — Application framework  
- **C#** — Language  
- **WinForms / WPF (optional)** — Desktop UI  
- **SQL Server** — Primary database  
- **ADO.NET** — Data access layer

### Optional / Future Tech (when converting to web):
- **ASP.NET Core Web API** — expose functionality as RESTful services  
- **Entity Framework Core** — ORM alternative to ADO.NET  
- **Redis** — caching for fast temporary storage  
- **JWT** — authentication for APIs

---

## Project Structure

