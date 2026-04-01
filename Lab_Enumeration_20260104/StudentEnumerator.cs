using System.Collections;

namespace Lab_Enumeration_20260104
{
    internal class StudentEnumerator : IEnumerator
    {
        private Student[] Students;
        private int Position = -1;
        public StudentEnumerator(Student[] theStudents)
        {
            Students = new Student[theStudents.Length];
            for(int i = 0; i < theStudents.Length; i++)
            {
                Students[i] = theStudents[i];
            }
            
        }
        public object Current
        {
            get
            {
                if (Position == -1)
                    throw new InvalidOperationException();
                if(Position >= Students.Length)
                    throw new InvalidOperationException();
                return Students[Position];
            }
        }

        public bool MoveNext()
        {
            if(Position >= Students.Length - 1)
                return false;
            Position++;
            if (Students[Position].Grade < 18)
                return MoveNext();
            return true;
        }

        public void Reset()
        {
            Position = -1;
        }
    }
}