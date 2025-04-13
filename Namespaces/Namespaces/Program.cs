
using static System.Console;

namespace Namespaces
{
    public class Person
    {
        private int id;
        public int Id { get { return id; } }
        public string Name { get; set; }
        public string Title { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Статичне підключення System.Console");
        }
    }
}
