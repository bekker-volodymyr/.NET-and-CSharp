namespace OperatorsOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // перевантажений оператор !=
            if ("apple" != "banana")
                Console.WriteLine("apple is not a banana");

            // перевантажений оператор +
            string concat = "Hello, " + "World!";

            Vector vector = new Vector() { X = 1, Y = 3 };
            vector *= 10;

            if (vector)
            {
                Console.WriteLine("Vector is not zero");
            }
            else
            {
                Console.WriteLine("Vector is zero");
            }
        }
    }
}
