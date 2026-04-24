# .NET Core OTP (One-Time PIN) Microservice API

A clean, open-source, and production-ready .NET 8 Web API for generating, storing, and validating One-Time PINs (OTPs). 

This project uses `IMemoryCache` to avoid heavy database dependencies, making it incredibly easy to integrate into any existing system or mobile application backend.

## 📋 Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
- Visual Studio 2022 (recommended) or Visual Studio Code.

---

## 🚀 Getting Started

### Option A: Using Visual Studio 2022 (Recommended)
1. Clone the repository to your local machine.
2. Navigate to the repository root and open the **`OTPMicroservice.sln`** file.
3. In the **Solution Explorer** (usually on the right), right-click the **`OtpService.Api`** project and select **"Set as Startup Project"**.
4. Press **F5** (or click the green "Start" button) to build and run the application. 
5. Your browser will automatically open the Swagger UI at `https://localhost:<port>/swagger`, where you can test the endpoints.

### Option B: Using the .NET CLI
1. Open your terminal or command prompt.
2. Navigate to the directory containing the API project:
   ```bash
   cd src/OtpService.Api
   ```
   *(Note: If your API project is at the root level, simply `cd OtpService.Api`)*
3. Run the application:
   ```bash
   dotnet run
   ```
4. Open your browser and navigate to the URL provided in the terminal output (append `/swagger` to the URL to view the UI).

---

## 🧪 Running Tests

This solution includes a comprehensive xUnit test suite to ensure the OTP generation and validation logic remains secure and functional.

### Option A: Using Visual Studio Test Explorer
1. Open **`OTPMicroservice.sln`** in Visual Studio 2022.
2. From the top menu, select **Test** > **Test Explorer**.
3. Click the **Run All Tests** button (the green play icon with double arrows) to execute the test suite.

### Option B: Using the .NET CLI (Root Directory)
The easiest way to run tests from the command line without worrying about specific folder paths is to run the test command against the solution file itself. 

1. Open your terminal at the root directory of the repository (where the `.sln` file is located).
2. Execute the following command:
   ```bash
   dotnet test OTPMicroservice.sln
   ```
This command will automatically discover and run all tests linked to the solution, regardless of whether they are in the `tests/` folder or the root directory.
```

