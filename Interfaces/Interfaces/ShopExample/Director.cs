namespace Interfaces.ShopExample
{
    public class Director : Employee, IManager
    {
        public List<IWorker> ListOfWorkers { get; set; }
        public void Control()
        {
            Console.WriteLine("Контролюю роботу!");
        }
        public void MakeBudget()
        {
            Console.WriteLine("Формую бюджет!");
        }
        public void Organize()
        {
            Console.WriteLine("Організовую работу!");
        }
    }
}
