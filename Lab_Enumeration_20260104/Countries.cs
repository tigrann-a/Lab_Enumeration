using System.Collections;

namespace Lab_Enumeration_20260104;

public class Countries : IEnumerable
{
    private readonly string[] _countries = { "Armenia", "Russia", "USA" };

    public IEnumerator GetEnumerator()
    {
        return new CountryEnumerator(_countries);
    }
}
