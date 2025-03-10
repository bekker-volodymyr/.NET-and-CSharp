namespace GarbageCollection
{
    public class DisposeExample : IDisposable
    {
        // використовується для того, щоб з'ясувати, чи викликався метод Dispose()
        private bool isDisposed = false;

        private void Cleaning(bool disposing) // допоміжний метод
        {
            // переконатися, що ресурси ще не звільнені
            if (!isDisposed) // очищати тільки один раз
            {
                //якщо true, то звільняємо всі керовані ресурси
                if (disposing)
                {
                    Console.WriteLine("Звільнення керованих ресурсів");
                }
                Console.WriteLine("Звільнення некерованих ресурсів");
            }
            isDisposed = true;
        }
        public void Dispose()
        {
            // виклик допоміжного методу
            // true - очищення ініційоване користувачем об'єкта
            Cleaning(true);
            // заборонити збирачу сміття здійснювати фіналізацію
            GC.SuppressFinalize(this);
        }
        ~DisposeExample()
        {
            // false вказує на те, що очищення ініціював збирач сміття
            Cleaning(false);
        }
        public void DoSomething()
        {
            Console.WriteLine("Виконання певних операцій");
        }
    }
}
