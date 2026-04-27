# OTPMicroservice: Enterprise-Grade One-Time PIN API

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](#)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](#)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](#)

**Repository:** [https://github.com/robinsondominic/OTPMicroservice](https://github.com/robinsondominic/OTPMicroservice)

## 🌍 The Vision & Community Impact

In modern financial ecosystems, marketplaces, and automated workflows, identity verification is the ultimate bottleneck. Poorly implemented One-Time Password (OTP) systems expose platforms to algorithmic sequencing, replay attacks, and expensive SMS toll fraud. 

**OTPMicroservice** was built to democratize zero-trust authentication. This open-source .NET Core microservice provides developers with a cryptographically secure, stateless, and instantly deployable OTP infrastructure. By open-sourcing this core security component, we aim to help startups, fintechs, and enterprise teams build safer applications without having to reinvent the wheel.

## ✨ Key Technical Features
* **Cryptographic Unpredictability:** Utilizes secure random generation (`RandomNumberGenerator`) to prevent modulo bias and sequence guessing, preserving the full entropy space.
* **Stateless Architecture:** Designed for horizontal scaling. Uses `IMemoryCache` out-of-the-box for instant local deployment, structured perfectly for easy migration to `IDistributedCache` (Redis) in clustered container environments.
* **Atomic Invalidation:** Enforces strict single-use policies to completely eliminate replay attack vectors.
* **Platform Agnostic:** Exposes clean RESTful endpoints ready for native mobile (iOS AutoFill, Android SMS Retriever) or secure web integrations.

---

## 📋 Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (or later)
* Visual Studio 2022 (Recommended) or Visual Studio Code

---

## 🚀 Getting Started

If you have cloned or downloaded the repository directly to your local drive (e.g., at `C:\OTPMicroservice`), follow one of the methods below to run the API.

### Option 1: Using Visual Studio 2022 (Recommended)
1. Navigate to your cloned directory.
2. Double-click the **`OTPMicroservice.sln`** file to open the solution.
3. In the **Solution Explorer**, right-click the **`OtpService.Api`** project and select **"Set as Startup Project"**.
4. Press **F5** to build and launch the application. 
5. Your default browser will automatically open the Swagger UI at `https://localhost:<port>/swagger`.

### Option 2: Using the .NET CLI
1. Open your preferred terminal.
2. Navigate to the API project directory: `cd src/OtpService.Api`
3. Run the application: `dotnet run`
4. Open your browser and navigate to the localhost URL provided in the terminal output (append `/swagger` to view the documentation).

---

## 🧪 Running Tests

### Option 1: Visual Studio Test Explorer
1. Open **`OTPMicroservice.sln`** in Visual Studio 2022.
2. Select **Test** > **Test Explorer** from the top menu.
3. Click the **Run All Tests** button.

### Option 2: .NET CLI
Open your terminal at the root directory where the `.sln` file is located and run:
`dotnet test OTPMicroservice.sln`

---

## 🔌 API Endpoints Reference
* **`POST /api/otp/generate`**
  * **Payload:** `{ "identifier": "user@example.com" }`
  * **Description:** Generates a secure 6-digit OTP and binds it to the identifier.
* **`POST /api/otp/validate`**
  * **Payload:** `{ "identifier": "user@example.com", "pin": "123456" }`
  * **Description:** Validates the OTP. If successful, the OTP is atomically destroyed from the cache.

---

## 🤝 Contributing: Build With Us
Security thrives in the open. We welcome contributions from developers and security researchers! Please read our `CONTRIBUTING.md` and `CODE_OF_CONDUCT.md` before submitting a pull request.

## 📄 License
This project is licensed under the MIT License. See the `LICENSE` file for more details.
