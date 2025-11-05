namespace Interfaces.StudentsExample
{
    internal class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; } = null!;

        public int CompareTo(object? obj)
        {
            if (obj is Student student)
            {
                // Порівнюємо студентів за прізвищем
                return LastName.CompareTo(student.LastName);
            }
            throw new NotImplementedException();
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone(); // поверхнева копія
            temp.StudentCard = new StudentCard // глибоке копіювання
            {
                Series = this.StudentCard.Series,
                Number = this.StudentCard.Number
            };
            return temp;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} #{StudentCard.Number}. \n\tBD: {BirthDate:D}";
        }
    }
}
