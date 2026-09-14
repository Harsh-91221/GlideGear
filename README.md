# GlideGear
GlideGear is a full-stack e-commerce application that provides a seamless shopping experience with a modern React frontend and a robust ASP.NET Core backend. The platform offers product browsing, shopping cart management, user authentication, and integrated Stripe payments, making it a complete online store solution.

🚀 Demo
Live Link: GlideGear - Online Store
Frontend: https://harsh-91221.github.io/GlideGear/

📚 Documentation
Project Overview Walkthrough
Database Schema Walkthrough

📌 Project Highlights
🔐 User Authentication & Authorization (Identity Framework)
🛒 Shopping Cart Management with Session-based Baskets
✅ Order Processing & History
💳 Stripe Payment Integration (Test Mode)
📦 Product Catalog with Filtering & Search
📄 Pagination Support for Large Product Sets
🏷️ Product Categories (Brands & Types)
⚡ Vite + React for Fast Development
🔧 Full-stack ASP.NET Core API Architecture
💾 PostgreSQL Database with EF Core

🔧 Technologies Used
🖥️ Frontend
React 19 (with TypeScript)
Vite.js
Redux Toolkit
MUI (Material-UI)
React Hook Form + Zod Validation
Stripe.js for Payments
React Router DOM

🖥️ Backend
ASP.NET Core 9 (C#)
Entity Framework Core
PostgreSQL (Npgsql)
Microsoft Identity Framework
Stripe.net SDK
JWT Authentication (via Identity API Endpoints)
CORS Configuration

💡 Key Features
Feature	Description
Authentication	Register, login, logout with email/password
User Roles	Member and Admin roles with Access Control
Product Catalog	Browse products with search and filters
Shopping Cart	Add/remove items, persist across sessions
Checkout	Shipping address collection and order placement
Payments	Stripe integration for secure payment processing
Order History	View past orders with status tracking
Product Management	CRUD operations for products (Admin)
Pagination	Optimized loading for large product lists
CORS Setup	Frontend-backend communication enabled

🧠 Challenges Faced
Implementing session-based basket management with cookies
Integrating Stripe Payment Intents with webhook handling
Managing Entity Framework migrations for PostgreSQL
Configuring ASP.NET Identity with custom User model
Handling CORS between GitHub Pages frontend and Render backend
Ensuring data consistency during order creation and payment

🌍 Use Cases & Scope
GlideGear is designed to support:

Small to medium e-commerce businesses
Product showcase platforms
Online stores with simple payment flows
Development projects requiring full-stack e-commerce
E-learning demos for ASP.NET Core and React

The system can scale from a single-product store to a multi-category marketplace.

🔗 API Reference
All backend routes are listed below:
- Authentication: `/api/account/register`, `/api/account/login`, `/api/account/logout`
- Products: `/api/products`, `/api/products/{id}`, `/api/products/filters`
- Basket: `/api/basket` (GET/POST/DELETE)
- Orders: `/api/orders` (GET/POST)
- Payments: `/api/payments` (POST), `/api/payments/webhook`

For complete endpoint documentation, refer to the Swagger/OpenAPI docs when running locally.

📞 Contact
Author: Harsh Kumar

LinkedIn: Harsh Kumar
