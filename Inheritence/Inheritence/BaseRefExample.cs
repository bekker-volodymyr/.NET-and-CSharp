namespace Inheritence.BaseRefExample
{
    class Animal  // Базовий клас
    {
        public string Name { get; set; }
    }

    class Dog : Animal  // Похідний клас
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} гавкає!");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} мявкає!");
        }
    }
}