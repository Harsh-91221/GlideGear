# GlideGear

A full-stack e-commerce application with a React frontend and ASP.NET Core backend. Features include product browsing, shopping cart management, user authentication, and Stripe payment integration. Deployed on GitHub Pages (frontend) and Render.com (backend).

## Project Overview

GlideGear is a complete online store solution built with a modern tech stack. The platform enables users to browse products, manage a shopping cart, and complete purchases securely. Administrators can manage products, orders, and user roles. The system is designed for small to medium e-commerce businesses and can scale from a single-product store to a multi-category marketplace.

### Key Capabilities
- **Product Browsing**: Search and filter products across 4 categories (Boards, Hats, Gloves, Boots)
- **Shopping Cart**: Session-based cart management with persistent item storage
- **Order Processing**: Full checkout flow with shipping address collection
- **Payment Integration**: Stripe integration for secure test-mode transactions
- **User Authentication**: Register/login with Member and Admin role-based access control
- **Admin Dashboard**: Product management, order tracking, and user management

### Technical Architecture
- **Frontend**: React.js 19 + Redux Toolkit + Vite.js
- **Backend**: ASP.NET Core 9 Web API with Entity Framework Core
- **Database**: PostgreSQL with Npgsql Entity Framework provider
- **Authentication**: ASP.NET Core Identity with JWT tokens
- **Payments**: Stripe.net SDK with Payment Intents and Webhooks
- **Deployment**: GitHub Pages (frontend) + Render.com (backend)

### Technology Highlights
- 18 products seeded with descriptions, prices, and images
- 4 product categories with filtering capabilities
- 2 user roles (Member, Admin) with distinct permissions
- Transactional database operations ensuring data consistency
- Responsive design working across desktop and mobile devices

### Project Documentation
- [GlideGear Overview](Overview/walkthrough-glidegear-overview.html) - Complete project walkthrough
- [GlideGear Database Schema](Overview/walkthrough-glidegear-database-schema.html) - Database schema visualization