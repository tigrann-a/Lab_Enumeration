using Lab_Enumeration_20260104;

// Classroom

//Console.WriteLine("Fun");

//Garage carLot = new Garage();
//MyColors colors = new MyColors();

//foreach(Car c in carLot)
//{
//    Console.WriteLine("{0} is going {1} MPH", c.DriverName, c.Year);
//}

//Console.WriteLine();

//foreach (string color in colors)
//{
//    Console.WriteLine($"{color}");
//}

//Console.WriteLine();

//var studentGroup = new StudentGroup();

//foreach(Student student in studentGroup)
//    Console.WriteLine($"{student.Grade}");

// Home

//List<string> names = new List<string> { "Cristiano", "Lionel", "Henrik" };

//foreach(string name in names)
//    Console.WriteLine(name);

//List<string> names = new List<string> { "Cristiano", "Lionel", "Henrik" };

// 1.
//IEnumerator<string> enumerator = names.GetEnumerator();

//while (enumerator.MoveNext())
//{
//    string name = enumerator.Current;
//    Console.WriteLine(name);
//}

// 2.
//foreach(string name in names)
//{
//    Console.WriteLine(name);
//}

// 3.
MyNumbers numbers = new MyNumbers();

foreach(int number in numbers)
{
    Console.WriteLine(number);
}