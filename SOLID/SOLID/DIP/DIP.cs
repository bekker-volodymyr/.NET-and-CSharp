namespace DIP
{
    interface IOrderRepository
    {
        void SaveOrder(string order);
    }

    class MySQLRepository : IOrderRepository
    {
        public void SaveOrder(string order)
        {
            Console.WriteLine("Saving order to MySQL database...");
        }
    }

    class MongoDBRepository : IOrderRepository
    {
        public void SaveOrder(string order)
        {
            Console.WriteLine("Saving order to MongoDB database...");
        }
    }

    class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository; // Використовуємо абстракцію, а не конкретну реалізацію
        }

        public void ProcessOrder(string order)
        {
            Console.WriteLine("Processing order...");
            _repository.SaveOrder(order);
        }
    }
}