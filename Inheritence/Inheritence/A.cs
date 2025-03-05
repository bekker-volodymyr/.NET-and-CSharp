namespace Inheritence.BaseKeyword
{
    public class A
    {
        public A(string message)
        {
            Console.WriteLine("Базовий клас: " + message);
        }
    }
    class B : A
    {
        public B() : base("Привіт від A!") // Викликає конструктор A  
        {
            Console.WriteLine("Конструктор B");
        }
    }
}
