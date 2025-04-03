namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Порушення принципу підстановки Барбари Лісков

            LSP.Violation.Rectangle rect = new LSP.Violation.Square();
            rect.Width = 5;
            rect.Height = 10;
            Console.WriteLine(rect.GetArea()); // Очікувано: 50, але отримаємо 100!

            #endregion

            #region Виконання принципу підстановки Барбари Лісков

            LSP.IShape shape = new LSP.Square() { Side = 5 };

            Console.WriteLine(shape.GetArea());

            shape = new LSP.Rectangle() { Height = 5, Width = 10 };

            Console.WriteLine(shape.GetArea());

            #endregion

        }
    }
}
