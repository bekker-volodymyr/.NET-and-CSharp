namespace Inheritence.NameHiding
{
    public class Parent
    {
        public void Show()
        {
            Console.WriteLine("Метод базового класу");
        }
    }

    public class Child : Parent
    {
        public new void Show()
        {
            Console.WriteLine("Метод дочірнього класу");
        }
    }
}
