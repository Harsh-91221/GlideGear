# GlideGear

A full-stack e-commerce application with a React frontend and ASP.NET Core backend.

## Quick Start

### Frontend (GitHub Pages)
The frontend is built with Vite + React and deployed to GitHub Pages.
- **Live URL**: https://harsh-91221.github.io/GlideGear/
- **Source**: `main` branch, `/docs` folder

### Backend (Render.com)
The backend is an ASP.NET Core 9 API using PostgreSQL (via Npgsql).
- **Live URL**: https://glidegear-api.onrender.com (after deployment)
- **Database**: PostgreSQL via Render's managed databases
- **Stripe**: Test mode enabled for payments

## Local Development

### Prerequisites
- Node.js 20+
- .NET 9 SDK
- PostgreSQL (or use Render's managed database)

### Backend Setup
```bash
cd API
dotnet restore
dotnet run
```
The API will start at http://localhost:5001 (or the port configured in `launchSettings.json`).

### Frontend Setup
```bash
cd client
npm install
npm run dev
```
The Vite dev server will start at https://localhost:3000.

### Environment Variables
Copy `.env.example` to `.env` and fill in your values:
```env
VITE_API_URL=https://localhost:5001/api
VITE_STRIPE_PK=pk_test_xxxxx...
```

## Production Deployment

### GitHub Pages (Frontend)
1. Go to **Settings → Pages**
2. Source: **Branch: main, Folder: /docs**
3. Save

### Render.com (Backend)
1. Create a **PostgreSQL database** (free tier)
2. Create a **Web Service**:
   - Connect your GitHub repo
   - Environment: **Docker**
   - Dockerfile: `./API/Dockerfile`
   - Environment Variables:
     - `ConnectionStrings__DefaultConnection`: Link to your database
     - `StripeSetting__SecretKey`: Your Stripe secret key
     - `StripeSetting__WhSecret`: Your webhook secret
     - `ASPNETCORE_ENVIRONMENT`: `Production`
     - `ASPNETCORE_URLS`: `http://0.0.0.0:8080`
3. Deploy

### Update Frontend API URL
After backend is deployed, update `client/.env`:
```env
VITE_API_URL=https://your-api.onrender.com/api
```
Commit and push to rebuild.

## Architecture

- **Frontend**: React 19 + Vite + TypeScript + Redux Toolkit + MUI + React Hook Form + Zod
- **Backend**: ASP.NET Core 9 + Entity Framework Core + PostgreSQL + Stripe
- **Testing**: Stripe test mode (no real charges)

## Testing Credentials
- **User**: `bob@test.com` / `Pa$$w0rd`
- **Admin**: `admin@test.com` / `Pa$$w0rd`
- **Stripe Test Card**: `4242 4242 4242 4242`, any future date, any CVC
