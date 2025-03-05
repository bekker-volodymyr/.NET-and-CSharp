namespace Inheritence.BaseKeyword
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Метод базового класу");
        }
    }

    class Child : Parent
    {
        public void ShowChild()
        {
            base.Show(); // Викликає метод базового класу  
            Console.WriteLine("Метод дочірнього класу");
        }
    }
}
