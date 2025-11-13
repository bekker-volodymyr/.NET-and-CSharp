namespace DelegatesFromBCL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Action
            {
                // Створюємо делегат Action, який приймає один рядок
                Action<string> greet = message => Console.WriteLine(message);

                // Викликаємо делегат
                greet("Hello!");

                // Можна підписати кілька методів
                greet += AnotherGreet;
                greet("How are you?");
            }
            #endregion

            #region Event Handler
            {
                Button button = new Button();

                // Підписка на подію Click
                button.Click += OnButtonClick;

                // Виклик події
                button.SimulateClick();
            }
            #endregion

            #region Predicate
            {
                List<int> numbers = new() { 1, 5, 10, 15, 20 };

                // Делегат Predicate для перевірки, чи число більше 10
                Predicate<int> isGreaterThan10 = n => n > 10;

                // Використання з методом List.FindAll
                List<int> result = numbers.FindAll(isGreaterThan10);

                Console.WriteLine("Числа більше 10: " + string.Join(", ", result));
            }
            #endregion

            #region
            {
                // Func<int, int, int> – приймає два int і повертає int
                Func<int, int, int> add = (a, b) => a + b;

                int result = add(5, 7);
                Console.WriteLine("Сума: " + result);

                // Func<string, int> – приймає string і повертає int
                Func<string, int> stringLength = s => s.Length;
                Console.WriteLine("Довжина рядка: " + stringLength("Привіт"));
            }
            #endregion
        }

        static void OnButtonClick(object? sender, EventArgs e)
        {
            Console.WriteLine($"Button is pressed! Sender: {sender?.GetType()}. ");
        }

        static void AnotherGreet(string msg)
        {
            Console.WriteLine("Additional message: " + msg);
        }
    }
}
