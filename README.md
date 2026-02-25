# Ordering & Inventory Dashboard

## Overview
This project is a **mini production-level inventory management dashboard**, built using ASP.NET Core Razor Pages and jQuery.  
It demonstrates **enterprise-level architecture, modular services, and business rule enforcement**, with dynamic UI updates suitable for a realistic enterprise scenario.  

The application simulates a real-world **inventory management system**, focusing on **product management and dashboard KPIs**.

---

## Features (Phase 1 Implemented)
- **Dynamic Inventory Dashboard** with KPI cards (Total Products, Low Stock Count).  
- **Interactive Product Table** with:
  - Columns: Name, Category, Stock, Reserved, Status, Actions.  
  - Status badges (In Stock / Low Stock / Out of Stock).  
  - Conditional styling based on stock levels.  
- **Product Details Modal**:
  - Displays full product information.  
  - Enforces business rules:
    - Stock < Threshold → Warning.  
    - Stock = 0 → Cannot create order.  
    - Reserved > Stock → Critical alert.  
- **Add New Product (in-memory)**:
  - Form validation using jQuery.  
  - Server-side validation via ProductService and RuleService.  
  - Updates KPI cards and inventory table dynamically.  
- Modular architecture: **Razor Pages → Service Layer → Repository → Rule Engine**.  
- Clean, maintainable code, reflecting **enterprise-level structure**.

---

## Architecture Overview
The application follows a **layered architecture**:

- **UI Layer**: Razor Pages handle display and user interactions, binding to **ViewModels**.  
- **Service Layer**: Contains business logic, including product operations and application of business rules.  
- **Repository Layer**: Provides in-memory data for Phase 1, designed to be replaced with database or API in the future.  
- **Rule Engine**: Applies business rules such as stock thresholds and reserved quantity checks.  
- **Client-side**: jQuery handles dynamic updates for tables, KPI cards, and modals.

**Flow of Data**:

1. Razor Page loads → calls ProductService.  
2. ProductService fetches product data from the repository.  
3. ProductRuleService applies business rules to the data.  
4. Processed data is returned to the Razor Page via DashboardViewModel.  
5. jQuery updates the UI dynamically (table, KPI cards, modals).

---

## Tech Stack
- **Front-end:** Razor Pages, jQuery, Bootstrap  
- **Back-end:** ASP.NET Core, C#  
- **Architecture:** Service Layer, Repository, Rule Engine  
- **Data:** In-memory (Phase 1)  
- **Validation:** Client-side + Service-layer business rules  

---

## How to Run
1. Clone the repository  
2. Open in Visual Studio 2022  
3. Restore NuGet packages  
4. Run the project (F5)  
5. Explore the dashboard, view product details, and add new products  

---

## Potential Enhancements
-- **Unit testing / TDD** for services and rule engine  
- Database persistence using EF Core or Dapper  
- Authentication and role-based access  
- Error handling and logging  
- Orders module with stock validation  
- Real-time stock updates via SignalR  

---

## About the Developer
I am a **Senior .NET Developer** with 9 years of experience in Microsoft technologies, including:  
- C#, ASP.NET Core, ASP.NET MVC, ASP.NET FRAMEWORK,
- Web API  
- Razor Pages, jQuery, Bootstrap  
- Entity Framework Core, SQL Server  
- Designing **enterprise-level architecture, business rules, and modular UI**  

This project demonstrates my ability to **build production-quality, scalable, and maintainable applications**, with strong emphasis on **enterprise-level thinking, business rules, project planning, and dynamic data handling**.
