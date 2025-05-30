﻿namespace Interfaces.StudentsExample
{
    internal class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public object Clone() // глибоке копіювання
        {
            Student temp = (Student)this.MemberwiseClone(); // поверхнева копія
            temp.StudentCard = new StudentCard { Series = this.StudentCard.Series, Number = this.StudentCard.Number };
            return temp;
        }
    }
}
