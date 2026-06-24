internal class Employee
{
    public string Name;
    public double GrossSalary;
    public double TaxValue;

    public double NetSalary()
    {
        return GrossSalary - TaxValue;
    }

    public void IncreaseSalary(double percentage)
    {
        GrossSalary *= (1 + (percentage / 100)) ;
    }

    public override string ToString()
    {
        return $"{Name}, $ {NetSalary():F2}";
    }
}