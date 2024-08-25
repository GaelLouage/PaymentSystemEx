using PaymentSystemEx.Context.Classes;
using PaymentSystemEx.Context.Interfaces;
using PaymentSystemEx.Strategy.Classes;
using PaymentSystemEx.Strategy.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPaymentContext, PaymentContext>();
var app = builder.Build();

app.MapGet("/", ( IPaymentContext paymentContext) =>
{
    var result = paymentContext.Payment(
        new PaypalPayment(), 0.2M);
    return Results.Ok(result);
});

app.Run();
