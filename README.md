# Sanwo for .NET

Sanwo is a free, open-source payment SDK that gives you a single, unified API for every payment provider. This package provides ASP.NET Tag Helpers for checkout buttons and custom amount forms.

## Installation

```bash
dotnet add package Sanwo
```

## Quick Start

**1. Register in `Program.cs`:**

```csharp
using Sanwo;

builder.Services.AddSanwo(options =>
{
    options.Provider = "paystack";
    options.PublicKey = "pk_test_xxxxx";
    options.Currency = "NGN";
});
```

**2. Add Tag Helpers in `_ViewImports.cshtml`:**

```cshtml
@addTagHelper *, Sanwo
```

**3. Add the script (in your layout, before `</body>`):**

```cshtml
<sanwo-scripts />
```

**4. Use checkout buttons:**

```cshtml
<sanwo-checkout
    amount="500000"
    email="customer@example.com"
    button-text="Pay Now" />
```

## Custom Amount Form

Let customers enter their own amount:

```cshtml
<sanwo-custom-amount
    email="donor@example.com"
    button-text="Donate"
    placeholder="How much would you like to give?"
    min-amount="500"
    max-amount="1000000" />
```

## Configuration via appsettings.json

```json
{
  "Sanwo": {
    "Provider": "paystack",
    "PublicKey": "pk_test_xxxxx",
    "Currency": "NGN",
    "Debug": false
  }
}
```

```csharp
builder.Services.AddSanwo(builder.Configuration.GetSection("Sanwo"));
```

## Supported Providers

Paystack, Flutterwave, Razorpay, Monnify, Interswitch, and custom providers.

## Links

- [Documentation](https://docs.sanwo.dev/sdks/dotnet/)
- [GitHub](https://github.com/Sanwohq/dotnet)
- [Website](https://sanwohq.com)
