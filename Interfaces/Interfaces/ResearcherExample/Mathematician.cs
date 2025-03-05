namespace Interfaces.ResearcherExample
{
    public class Mathematician : IResearcher
    {
        public void Investigate()
        {
            Console.WriteLine("Doing some math investigation... ");
            Console.WriteLine("It's seems that 2 + 2 equals 4");
        }

        public void Invent()
        {
            Console.WriteLine("Doing some math inventing...");
            Console.WriteLine("I invented an imaginary number!");
        }
    }
}
