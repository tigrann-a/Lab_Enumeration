using System.Collections;

namespace Lab_Enumeration_20260104;

public class ColorEnumerator : IEnumerator
{
    string[] Colors;
    int Position = -1;
    
    public ColorEnumerator(string[] theColors)
    {
        Colors = new string[theColors.Length];
        for(int i = 0; i < theColors.Length; i++)
        {
            Colors[i] = theColors[i];
        }
    }

    public object Current
    {
        get
        {
            if(Position == -1)
                throw new InvalidOperationException();
            if(Position >= Colors.Length)
                throw new InvalidOperationException();
            return Colors[Position];
        }
    }

    public bool MoveNext()
    {
        if (Position < Colors.Length - 1)
        {
            Position++;
            return true;
        }
        else
            return false;
    }

    public void Reset()
    {
        Position = -1;
    }
}
