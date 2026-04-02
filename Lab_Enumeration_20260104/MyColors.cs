using System.Collections;

namespace Lab_Enumeration_20260104;

public class MyColors : IEnumerable
{
    private readonly string[] _colors = { "Red", "Yellow", "Blue" };

    public IEnumerator GetEnumerator()
    {
        return new ColorEnumerator(_colors);
    }
}
