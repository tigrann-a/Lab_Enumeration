using System.Collections;

namespace Lab_Enumeration_20260104;

public class StudentGroup : IEnumerable
{
    Student[] student = new Student[4];

    public StudentGroup()
    {
        student[0] = new Student("Aram", 16);
        student[1] = new Student("Davit", 20);
        student[2] = new Student("Lusine", 18);
        student[3] = new Student("Anahit", 14);
    }

    public IEnumerator GetEnumerator()
    {
        // Return the array objects IEnumerator
        return new StudentEnumerator(student);
    }
}
