using System.Collections;

namespace Lab_Enumeration_20260104;

public class Garage
{
    private Car[] _cars = new Car[4];

    // Fill with some Car objects upon startup.
    public Garage()
    {
        _cars[0] = new Car("Mercedes", 2004);
        _cars[1] = new Car("Nissan", 2018);
        _cars[2] = new Car("Toyota", 2023);
        _cars[3] = new Car("Range Rover", 2023);
    }

    public IEnumerator GetEnumerator() 
    {   
        // Return the array objects IEnumerator
        return _cars.GetEnumerator();
    }
}
