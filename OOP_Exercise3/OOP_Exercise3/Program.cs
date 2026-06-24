Student s = new Student();

Console.Write("Student name: ");
s.Name = Console.ReadLine();
Console.WriteLine("Type the student's three grades: ");
s.Grade1 = double.Parse(Console.ReadLine());
s.Grade2 = double.Parse(Console.ReadLine());
s.Grade3 = double.Parse(Console.ReadLine());

Console.WriteLine($"FINAL GRADE = {s.FinalGrade():F2}");

if (s.Approved()) {
    Console.WriteLine("APPROVED");
}
else
{
    Console.WriteLine("FAILED");
    Console.WriteLine($"SHORT BY {s.RemainingGrade():F2} POINTS");
}
