namespace Interfaces.ShopExample
{
    public class Storekeeper : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }
        public string Work()
        {
            return "Обліковую товар!";
        }
    }
}
