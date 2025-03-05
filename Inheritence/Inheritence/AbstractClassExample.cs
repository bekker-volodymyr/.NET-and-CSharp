namespace Inheritence.AbstractClass
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape ctor");
        }

        public abstract double GetArea(); // Абстрактний метод
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double r) { radius = r; }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

}