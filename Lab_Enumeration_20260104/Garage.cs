using System.Collections;

namespace Lab_Enumeration_20260104;

public class Garage
{
    private Car[] _carArray = new Car[4];

    // Fill with some Car objects upon startup.
    public Garage()
    {
        _carArray[0] = new Car("Merkem", 2023);
        _carArray[1] = new Car("Resen", 2026);
        _carArray[2] = new Car("Busty", 2023);
        _carArray[3] = new Car("Jone", 2023);
    }

    public IEnumerator GetEnumerator() 
    {   
        // Return the array objects IEnumerator
        return _carArray.GetEnumerator();
    }
}
