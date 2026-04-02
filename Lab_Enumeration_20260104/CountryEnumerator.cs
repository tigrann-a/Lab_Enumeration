using System.Collections;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Lab_Enumeration_20260104;

public class CountryEnumerator : IEnumerator
{
    private string[] _myCountries;
    private int _position = -1;

    public CountryEnumerator(string[] theCountries)
    {
        _myCountries = new string[theCountries.Length];
        for(int i = 0; i < theCountries.Length; i++)
        {
            _myCountries[i] = theCountries[i];
        }
    }

    public object Current
    {
        get
        {
            if (_position == -1)
                throw new InvalidOperationException();
            if(_position >= _myCountries.Length)
                throw new InvalidOperationException();
            return _myCountries[_position];
        }
    }

    public bool MoveNext()
    {
        if(_position >= _myCountries.Length - 1)
        {
            return false;
        }
        _position++;
        return true;
    }

    public void Reset()
    {
        _position = -1;
    }
}
