# DVLD – Driving & Vehicle Licensing System

Welcome to the **DVLD System** — a complete multi-layered C#/.NET application designed to manage all operations for a Driving & Vehicle Licensing Department.
The system provides full functionality for applicant management, driving license creation, renewals, replacements, test management, and violation tracking.

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Architecture](#architecture)
3. [Technology Stack](#technology-stack)
4. [Project Structure](#project-structure)
5. [Features](#features)
6. [Getting Started](#getting-started)
7. [Configuration](#configuration)
8. [Modules](#modules)
9. [Data Flow](#data-flow)
10. [Database Setup](#database-setup)
11. [Business Rules](#business-rules)
12. [Error Handling](#error-handling)
13. [Testing](#testing)
14. [Support](#support)

---

## Project Overview

The **DVLD System** is a full-featured desktop application built with C# and a layered architecture approach.
It ensures clean separation between UI, business logic, and data access.

### Key Capabilities:

* **Applicant Management**: Full CRUD for citizens, personal info & documents
* **License Management**: Create, renew, replace, or upgrade driving licenses
* **Driving Tests**: Vision test, written test, and street test workflows
* **International Licenses**: Issuing and managing international licenses
* **Violations Tracking**: Record and manage license violations
* **Payments & Fees**: Auto-calculated fees, renewals, replacements
* **License History**: Records of past licenses and actions

---

## Architecture

The project follows a **Clean, Layered Architecture** with the following layers:

### Layer Structure:

#### 1. **DVLD (Presentation Layer)**

* WinForms UI
* Forms for applicants, licenses, tests, violations
* Validations and user interaction logic
* Calls Business Layer to perform actions

#### 2. **DVLD_Buisness (Business Logic Layer)**

* All domain logic for licenses and tests
* Rules for eligibility
* Handling renewals, replacements, suspensions
* Mapping data between DAL and UI
* Reusable service classes

#### 3. **DVLD_DataAccess (Data Access Layer)**

* SQL connection and execution
* CRUD operations using ADO.NET
* Stored procedures integration
* Maps database results to entities

---

## Technology Stack

### Core Technologies:

* **C# (.NET Framework / Windows Forms)**
* **SQL Server** (Primary database)
* **ADO.NET** for data access
* **Layered Architecture (UI → Business → DAL)**

### Additional Tools:

* Stored Procedures
* Database Views
* Enumerations for license types & statuses
* Logging (optional)

---

## Project Structure

```
DVLD/
│
├── DVLD/                     # Presentation Layer (Windows Forms)
│   ├── Forms/                # UI Forms
│   ├── Controls/             # User controls
│   ├── Models/               # Form models
│   ├── Helpers/              # UI helpers
│   └── Program.cs            # App entry point
│
├── DVLD_Buisness/            # Business Layer
│   ├── Services/             # License, Test, Applicant services
│   ├── Logic/                # Business rules
│   ├── Managers/             # Domain managers
│   └── Models/               # Domain entities
│
└── DVLD_DataAccess/          # Data Access Layer
    ├── Data/                 # SQL queries & stored procedures
    ├── Repositories/         # CRUD operations
    ├── Connection.cs         # Database connection
    └── DTOs/                 # Data transfer objects
```

---

## Features

### 1. Applicant Management

* Add, update, or delete applicant data
* Personal information, date of birth, national number
* Attach required documents

### 2. License Management

* Issue new local driving licenses
* Renew existing licenses
* Replace lost/damaged licenses
* Track active, expired, suspended licenses
* Automatic fee calculation

### 3. Driving Tests Module

* Vision Test
* Written Test
* Street/Practical Test
* Manage test appointments & results
* Enforce test dependencies (e.g., street test requires passing vision & written)

### 4. International Licenses

* Issue international licenses for travelers
* Check eligibility
* Maintain international license history

### 5. Violations & Penalties

* Add violations to licenses
* Suspension handling
* Fine payments
* Track violation history per license

### 6. Payments & Receipts

* Auto-generated fees
* Printed receipts
* Payment logs

### 7. License History

* Full history of issued, renewed, replaced licenses
* View stored test results
* View active and expired licenses

---

## Getting Started

### Prerequisites

* **Visual Studio 2022** (recommended)
* **SQL Server / SQL Server Express**
* .NET Desktop Development tools

### Steps to Run:

1. **Clone Repository**

```bash
git clone <repository-url>
cd DVLD
```

2. **Import Database**

* Restore the SQL `.bak` or run the `.sql` file
* Ensure stored procedures & views are created

3. **Update Database Connection**
   In the DAL layer:

```csharp
public static string ConnectionString =
    "Server=YOUR_SERVER;Database=DVLD;Trusted_Connection=True;";
```

4. **Build Solution**

```
Build → Rebuild Solution
```

5. **Run Application**

```
Start DVLD project
```

---

## Configuration

### Database Connection

Located in:

```
DVLD_DataAccess/Connection.cs
```

### Business Rules

Defined in:

```
DVLD_Buisness/Logic/
DVLD_Buisness/Services/
```

---

## Modules

### 1. Applicant Module

* Register new applicant
* Edit information
* Search by name, national ID, etc.

### 2. Local Driving License Module

* Issue, renew, replace
* License class selection (Car, Bike, Truck...)
* Fee calculation

### 3. International License Module

* Automated eligibility check
* Link local license to international license

### 4. Test Management Module

* Scheduling
* Result entry
* Dynamic test availability

### 5. Violations Module

* Create violation
* Attach fine
* Update license status

---

## Data Flow

```
UI (Forms)
     ↓
Business Layer (Rules & Validation)
     ↓
Data Access Layer (SQL Queries)
     ↓
Database (Tables, SPs, Views)
```

---

## Database Setup

### Required Tables:

* Applicants
* LocalLicenses
* InternationalLicenses
* DrivingTests
* LicenseClasses
* Violations
* Payments
* TestAppointments

### Stored Procedures:

* Insert/Update Applicants
* Insert/Update Licenses
* Get License History
* Validate Eligibility
* Insert Test Results

---

## Business Rules

* A user **must pass** Vision → Written → Street tests in order
* Cannot issue license if user has unpaid fines
* International license requires **valid local license**
* Renewals require:

  * No active violations
  * No unpaid penalties
  * Valid personal information

---

## Error Handling

* UI validation for required fields
* SQL exception handling in DAL
* Business rules validation in BLL
* User-friendly Windows Forms messages

---

## Testing

### Manual Testing

* Full test coverage through UI forms
* Test scenarios:

  * Issue license
  * Fail test
  * Renew license
  * Replace lost license
  * Add violation

### Future Enhancements

* Unit tests for BLL
* Automated integration tests

---

## Support

If something doesn’t work:

1. Check database connection
2. Verify stored procedures exist
3. Confirm tables are correctly linked
4. Contact your system administrator

---
