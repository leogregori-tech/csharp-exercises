internal class CurrencyConverter
{
    public static double Iof = 6.0;

    public static double UsdToReal(double qtyUsd, double usdExchangeRate)
    {
        return (usdExchangeRate * qtyUsd) * (1 + Iof / 100);
    }
}

