using Lab_Enumeration_20260104;

Console.WriteLine("Fun");

Garage carLot = new Garage();
MyColors colors = new MyColors();

foreach(Car c in carLot)
{
    Console.WriteLine("{0} is going {1} MPH", c.DriverName, c.Year);
}

Console.WriteLine();

foreach (string color in colors)
{
    Console.WriteLine($"{color}");
}

Console.WriteLine();

var studentGroup = new StudentGroup();

foreach(Student student in studentGroup)
    Console.WriteLine($"{student.Grade}");