namespace Interfaces.ShopExample
{
    public abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nПосада: {Position} Зарабітна плата: {Salary} $";
        }
    }
}
