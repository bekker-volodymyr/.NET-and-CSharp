namespace Interfaces.ShopExample
{
    public class Cashier : Employee, IWorker
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
            return "Приймаю оплату за товар!";
        }
    }
}
