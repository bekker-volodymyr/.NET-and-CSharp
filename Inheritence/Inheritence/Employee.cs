using System.Text;

namespace Inheritence
{
    public class Employee : Human
    {
        double _salary;
        public Employee(string fName, string lName, double salary) : base(fName, lName)
        {
            // firstName = fName;
            // lastName = lName;
            _salary = salary;
            // _id = 34; // Error
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Заробітна плата: {_salary} $");
        }

        public override string ToString()
        {
            // ПОГАНИЙ ВАРІАНТ 
            // тип string є незмінним, відбувється нове виделення пам'яті
            // погано для продуктивності
            // string result = $"First Name: {firstName}\n";
            // result += $"Second Name: {lastName}\n";
            // result += $"Salary: {_salary}";

            StringBuilder sb = new StringBuilder();

            sb.Append($"First Name: {firstName}\n");
            sb.Append($"Second Name: {lastName}\n");
            sb.Append($"Salary: {_salary}");

            return sb.ToString();
        }
    }
}
