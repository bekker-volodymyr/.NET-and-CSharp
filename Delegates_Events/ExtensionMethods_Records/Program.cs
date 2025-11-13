using ExtensionMethods_Records.Extensions;
using ExtensionMethods_Records.Records;

namespace ExtensionMethods_Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "level";

            if (word.IsPalindrome())
            {
                Console.WriteLine("Word is palindrome!");
            }
            else
            {
                Console.WriteLine("Word is not a palindrome!");
            }


            var person = new Person
            {
                Name = "Vova",
                Age = 30
            };
        }
    }
}
