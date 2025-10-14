namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(); // виклик конструктора за замовчуванням
            Point point2 = new Point(10, 15); // виклик конструктора з параметрами

            point1.Print(); // виклик методу структури
            point2.Print();
        }
    }
}