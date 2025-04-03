namespace DIP.Violation
{
    class MySQLRepository
    {
        public void SaveOrder(string order)
        {
            Console.WriteLine("Saving order to MySQL database...");
        }
    }

    class OrderService
    {
        private MySQLRepository _repository;

        public OrderService()
        {
            _repository = new MySQLRepository(); // Жорстка залежність від конкретної реалізації!
        }

        public void ProcessOrder(string order)
        {
            Console.WriteLine("Processing order...");
            _repository.SaveOrder(order);
        }
    }

}