Console.Write("How much is the USD exchange rate? ");
double UsdExchangeRate = double.Parse(Console.ReadLine());

Console.Write("How much USD you want to buy? ");
double qtyUSD = double.Parse(Console.ReadLine());

double realToUsd = CurrencyConverter.RealToUsd(UsdExchangeRate, qtyUSD);
Console.WriteLine($"Value to be paid in R$: {realToUsd:F2}");

