using System.Text;

namespace LinqJoining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Колекція клієнтів
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Володимир", Email = "vova@example.com" },
                new Customer { Id = 2, Name = "Олена", Email = "olena@example.com" },
                new Customer { Id = 3, Name = "Ігор", Email = "igor@example.com" },
                new Customer { Id = 4, Name = "Марія", Email = "maria@example.com" }
            };

            // Колекція замовлень
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 101, CustomerId = 1, OrderDate = new DateTime(2025, 11, 20), TotalAmount = 250m },
                new Order { OrderId = 102, CustomerId = 2, OrderDate = new DateTime(2025, 11, 21), TotalAmount = 450m },
                new Order { OrderId = 103, CustomerId = 1, OrderDate = new DateTime(2025, 11, 22), TotalAmount = 150m },
                new Order { OrderId = 104, CustomerId = 3, OrderDate = new DateTime(2025, 11, 23), TotalAmount = 300m }
            };

            #region Join
            {
                var result = from c in customers
                             join o in orders on c.Id equals o.CustomerId
                             select new { c.Name, o.OrderId };

                Console.WriteLine("Покупець - Id замовлення");

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Name} - {item.OrderId}");
                }
            }
            #endregion

            #region Union, Intersect, Except
            List<int> numbers1 = new List<int> { 1, 2, 3, 4 };
            List<int> numbers2 = new List<int> { 3, 4, 5, 6 };

            // Об'єднання без дублікатів
            var union = numbers1.Union(numbers2);

            foreach (var n in union)
                Console.WriteLine(n);

            // Спільні елементи
            var intersect = numbers1.Intersect(numbers2);

            foreach (var n in intersect)
                Console.WriteLine(n);

            // Унікальні елементи numbers1
            var except = numbers1.Except(numbers2);

            foreach (var n in except)
                Console.WriteLine(n);
            #endregion
        }
    }
}
