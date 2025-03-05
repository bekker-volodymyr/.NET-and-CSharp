namespace Interfaces.ShopExample
{
    public class Seller : Employee, IWorker
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
            return "Продаю товар!";
        }
    }
}
