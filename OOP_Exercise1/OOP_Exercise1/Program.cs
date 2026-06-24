Rectangle r = new Rectangle();

Console.WriteLine("Insert rectangle's width and height:");
r.Width = double.Parse(Console.ReadLine());
r.Height = double.Parse(Console.ReadLine());

Console.WriteLine($"AREA = {r.areaCalc():F2}");
Console.WriteLine($"PERIMETER = {r.perimeterCalc():F2}");
Console.WriteLine($"DIAGONAL = {r.diagonalCalc():F2}");