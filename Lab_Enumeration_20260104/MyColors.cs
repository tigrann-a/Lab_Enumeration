using System.Collections;

namespace Lab_Enumeration_20260104;

public class MyColors : IEnumerable
{
    string[] Colors = { "Red", "Yellow", "Blue" };

    public IEnumerator GetEnumerator()
    {
        return new ColorEnumerator(Colors);
    }
}
