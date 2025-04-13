namespace NullableTypes
{
    public class Person
    {
        public int Id { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //string name = "Тарас";      // Потрібно ініціалізувати
            //string? nickname = null;    // Може бути null

            //if(nickname.)

            //Console.WriteLine(name);
            //Console.WriteLine(nickname);

            //int length = name.Length; // Викине NullReferenceException

            //Person person = null;

            // DateTime dt = null; // ПОМИЛКА!

            //int? age = null;

            int? age = null;

            if (age.HasValue)
            {
                Console.WriteLine($"Вік {age.Value}");
            }
            else
            {
                Console.WriteLine($"Вік не зазначено.");
            }

            int? score = null;
            int finalScore = score ?? 0; // → 0

            string? name = null;
            int? length = name?.Length; // → null, не помилка

            string? nickname = null;
            nickname ??= "Default";
            Console.WriteLine(nickname); // → "Default"

        }
    }
}
