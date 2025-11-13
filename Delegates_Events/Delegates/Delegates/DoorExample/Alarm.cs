namespace Delegates.DoorExample
{
    internal class Alarm
    {
        private string _code = "1234";

        public void OnDoorOpen()
        {
            Console.WriteLine("Введіть код безпеки: ");
            string code = Console.ReadLine() ?? string.Empty;

            if (code == _code)
                Console.WriteLine("Ласкаво просимо!");
            else
                Console.WriteLine("Код невірний! Викликаємо СБУ!");
        }
    }
}
