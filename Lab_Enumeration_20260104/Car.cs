namespace Lab_Enumeration_20260104;

public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string carModel, int year)
    {
        Model = carModel;
        Year = year;
    }
}
