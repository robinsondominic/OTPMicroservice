# Contributing to OTPMicroservice

First off, thank you for considering contributing to OTPMicroservice! It's people like you that make open-source such a great community.

## 1. Where to Start
* If you are reporting a bug, please open an issue and use the Bug Report template.
* If you are suggesting a feature, open an issue using the Feature Request template.
* Look for issues tagged `good first issue` if you want to get your feet wet.

## 2. Pull Request Process
1. Fork the repository and create your branch from `main`.
2. If you've added code that should be tested, add unit tests in the `OtpService.Tests` project.
3. Ensure the test suite passes (`dotnet test`).
4. Issue that pull request!

## 3. Current Priorities (Looking for Help!)
* Implementing `IDistributedCache` for Redis clustering.
* Adding webhook integrations for Twilio/SendGrid SMS and Email dispatch.
* Building rate-limiting middleware for the generation endpoint.
