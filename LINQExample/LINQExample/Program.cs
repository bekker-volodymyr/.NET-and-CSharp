namespace LINQExample
{
    internal class Program
    {
        class Person
        {
            public int Id { get; private set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public Person(int id)
            {
                Id = id;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double[] doubles = { 10.5, 12.56, -56.05, 67.9 };

            var sortDoublesQuery =
                from d in doubles
                where d > 0
                orderby d descending
                select d;

            foreach (var d in doubles)
            {
                Console.WriteLine(d + " ");
            }

            var sortedDoubles = doubles.OrderByDescending(d => d).ToArray();

            Array.ForEach(sortedDoubles, d => Console.WriteLine(d + " "));

            foreach (var d in sortedDoubles)
            {
                Console.WriteLine(d + " ");
            }


            double value = Convert.ToDouble(Console.ReadLine());

            var queryTest =
                from d in doubles
                where d > value
                select d;

            foreach (var item in queryTest)
            {
                Console.WriteLine(item);
            }

            var sortingQuery =
                from d in doubles
                orderby d ascending
                select d;

            var sortingDescQuery =
                from d in doubles
                orderby d descending
                select d;

            //foreach (var d in sortingQuery)
            //{
            //    Console.Write($"{d} ");
            //}

            //Console.WriteLine();

            //foreach (var d in sortingDescQuery)
            //{
            //    Console.Write($"{d} ");
            //}

            //Console.WriteLine();

            List<Person> persons = new List<Person>()
            {
                new Person(1) {Name = "Тарас", Surname ="Шевченко", Age= 23},
                new Person(2) {Name = "Борис", Surname ="Шевченко", Age= 15},
                new Person(3) {Name = "Тарас", Surname ="Коваленко", Age = 10},
                new Person(4) {Name = "Анастасія", Surname ="Коваль", Age=65},
                new Person(5) {Name = "Сергій", Surname ="Зеленський", Age=32}
            };

            var tarasIDList = persons.Where(p => p.Name == "Тарас").Select(p => p.Id).ToList();

            foreach (var id in tarasIDList)
            {
                Console.WriteLine(id);
            }

            var sortedBySurname = persons.Where(p => p.Age > 18).OrderBy(p => p.Surname).Select(p => $"{p.Name} повнолітній або повнолітня.").ToList();

            sortedBySurname.ForEach(s => Console.WriteLine(s));


            Console.WriteLine();

            var groupBySurname =
                from p in persons
                group p by p.Surname;

            foreach (var group in groupBySurname)
            {
                foreach (var person in group)
                {
                    Console.WriteLine($"{group.Key}: {person.Id}");
                }
                Console.WriteLine();
            }

            var sortByAge =
                from p in persons
                orderby p.Age
                select $"{p.Id} {p.Name} {p.Surname} {p.Age}";

            //foreach (var person in sortByAge)
            //{
            //    Console.WriteLine(person);
            //}

            var sortByName =
                from p in persons
                orderby p.Name descending
                select $"{p.Id} {p.Name} {p.Surname} {p.Age}";

            //foreach (var person in sortByName)
            //{
            //    Console.WriteLine(person);
            //}

            var tarasQuery =
                from p in persons
                where p.Name == "Тарас" || p.Surname.StartsWith("Ковал")
                select $"{p.Id} {p.Name} {p.Surname}";

            //foreach (var taras in tarasQuery)
            //{
            //    Console.WriteLine(taras);
            //}


            // Джерело даних (Data Source)
            int[] scores = { 12, 10, 6, 3, 12 };

            // Формуємо запит
            int goodScore = 7;
            IEnumerable<int> query =
                from score in scores
                where score > goodScore
                select score;

            // Виконання запиту
            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            scores[3] = 11;

            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n{query.Count()}");
            Console.WriteLine($"\n{query.Max()}");
            Console.WriteLine($"\n{query.Min()}");

            scores[2] = 8;

            Console.WriteLine($"\n{query.Min()}");

            List<string> strs = new List<string>() { "str", "super str", "sadfasdfasd", "asdfasdfdbghd" };

            var strQuery =
                from str in strs
                where str.Contains("str")
                select str;

            Console.WriteLine(strQuery.First());
            Console.WriteLine(strQuery.Last());


        }
    }
}
