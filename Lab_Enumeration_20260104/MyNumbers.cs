using System.Collections;

namespace Lab_Enumeration_20260104;

public class MyNumbers : IEnumerable<int> // MyNumbers-ը իրականացնում է IEnumerable<int> ինտերֆեյսը, որը թույլ է տալիս MyNumbers-ի օբյեկտները օգտագործել foreach ցիկլի մեջ և այլ տեղերում, որտեղ պահանջվում է IEnumerable<int>։
{
    private int[] numbers = { 1, 2, 3 };

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            yield return numbers[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
