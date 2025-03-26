namespace LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Базовий приклад LINQ
            // Створюємо джерело даних
            int[] scores = [97, 92, 81, 60];

            // Визначаємо вираз запиту (query expression)
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Виконуємо запит
            foreach (var i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            // Вивод: 97 92 81
            #endregion

            #region Відкладене виконання
            // Джерело даних - List з рядками
            List<string> strings = new List<string>() { "str1", "str str", "asdfsdf", "example" };

            // Визначаємо вираз запиту - отримувати тільки ті рядки, що містять підрядок str
            IEnumerable<string> stringsQuery =
                from str in strings where str.Contains("str") select str;

            // Виконуємо запит
            foreach (var str in stringsQuery)
            {
                Console.Write($"{str}, ");
            }
            // Вивод: str, str str

            //Змінюємо список рядків
            strings.Add("super str");

            // Виконуємо запит повторно
            foreach (var str in stringsQuery)
            {
                Console.Write($"{str}, ");
            }
            // Вивод: str, str str, super str
            #endregion

            #region Count, Max, First
            List<int> numbers = new List<int>() { 1, 4, 59, 10, 32 };

            var evenNumQuery = from num in numbers
                               where (num % 2) == 0
                               select num;

            int evenNumCount = evenNumQuery.Count();
            int evenNumMax = evenNumQuery.Max();
            int evenNumFirst = evenNumQuery.First();
            #endregion

            #region Використання з власним типом даних
            // Створюємо джерело даних
            Person[] people = new Person[]
            {
                new Person { Id = 1, Name = "John Doe", Description = "Software Engineer" },
                new Person { Id = 2, Name = "Jane Smith", Description = "Graphic Designer" },
                new Person { Id = 3, Name = "Mike Johnson", Description = "Data Analyst" },
                new Person { Id = 4, Name = "Emily Davis", Description = "Project Manager" }
            };

            // Створюємо запит - обрати тільки тих людей, які є графічними дизайнерами
            // Результат перетворити на рядок формату Ім'я це Графічний дизайнер
            var personsQuery =
                from person in people
                where person.Description == "Graphic Designer"
                select $"{person.Name} is {person.Description}";

            foreach (var item in personsQuery)
            {
                Console.WriteLine(item);
            }
            // Вивод: Jane Smith is Graphic Designer
            #endregion

            #region Сортування
            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };
            IEnumerable<int> queryAsc = from i in arrayInt
                                        where i % 2 == 0
                                        orderby i
                                        select i;

            Console.WriteLine("Парні елементи в порядку зростання:");
            foreach (int item in queryAsc)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            IEnumerable<int> queryDesc = from i in arrayInt
                                         where i % 2 == 0
                                         orderby i descending
                                         select i;
            Console.WriteLine("Парні елементи в порядку спадання:");
            foreach (int item in queryDesc)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion

            #region Групування
            int[] ints = { 5, 34, 67, 12, 94, 42 };
            // Групуємо результат за останньою цифрою
            IEnumerable<IGrouping<int, int>> query = from i in arrayInt
                                                     group i by i % 10;

            Console.WriteLine("Згрупована колекція:");
            foreach (IGrouping<int, int> key in query)
            {
                Console.Write($"Ключ: {key.Key}\nЗначення:");
                foreach (int item in key)
                {
                    Console.Write($"\t{item}");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
