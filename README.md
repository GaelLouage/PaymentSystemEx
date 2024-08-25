# Payment System using Strategy Pattern

## Overview

This repository demonstrates the implementation of the Strategy Pattern to create a flexible and extensible payment processing system. The system allows users to select from different payment methods such as Credit Card, PayPal, and Bank Transfer at runtime.

## Features

- **Flexible Payment Strategies:** Easily add new payment methods by implementing the `IPaymentStrategy` interface.
- **Dependency Injection:** Utilizes ASP.NET Core's dependency injection framework for better testability and maintainability.
- **Error Handling:** Basic validation to ensure payment amounts are greater than zero.

## Technologies Used

- .NET 6.0
- ASP.NET Core
- Dependency Injection

## Design Pattern

This project uses the **Strategy Pattern** to encapsulate different payment algorithms. Each payment method is implemented as a separate class that adheres to the `IPaymentStrategy` interface. The `PaymentContext` class is responsible for executing the payment using the selected strategy.

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### Running the Application

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/payment-system-strategy-pattern.git
    cd payment-system-strategy-pattern
    ```

2. Build and run the application:
    ```bash
    dotnet build
    dotnet run
    ```

3. Open your browser and navigate to `http://localhost:5000`. You will see the payment processing message.

### Example Usage

The example usage in the project processes a payment of $0.20 via PayPal. To change the payment method or amount, modify the `MapGet` route in `Program.cs`:

```csharp
app.MapGet("/", (IPaymentContext paymentContext) =>
{
    var result = paymentContext.Payment(new CreditCardPayment(), 50.00M);
    return Results.Ok(result);
});

Extending the System

To add a new payment method:

    Create a new class that implements IPaymentStrategy.
    Implement the Pay method with the logic for the new payment method.
    Use the new strategy in the PaymentContext.

csharp

public class ApplePayPayment : IPaymentStrategy
{
    public string Pay(decimal amount)
    {
        return $"Processing ApplePay payment of {amount:C}";
    }
}

Contributions

Feel free to fork the project and submit pull requests. For major changes, please open an issue first to discuss what you would like to change.
