Employee e = new Employee();

Console.Write("Name: ");
e.Name = Console.ReadLine();
Console.Write("Gross salary: ");
e.GrossSalary = double.Parse(Console.ReadLine());
Console.Write("Tax value: ");
e.TaxValue = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Funcionário: {e}");

Console.WriteLine();
Console.Write("Insert an percentage to increase the salary: ");
double percentage = double.Parse(Console.ReadLine());
e.IncreaseSalary(percentage);

Console.WriteLine();
Console.WriteLine($"Updated data: {e}");