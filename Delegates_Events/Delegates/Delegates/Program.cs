using Delegates.CalculatorExample;
using Delegates.DoorExample;

namespace Delegates
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }

    public record Person(string Name, int Age);

    internal class Program
    {
        public delegate void MyDelegate(string message); // Приклад делегату

        public delegate double CalcDelegate(double x, double y); // Приклад делегату

        public delegate T AddDelegate<T>(T x, T y); // Приклад Generic делегату

        // Оголошення делегата
        public delegate void MyEventHandler(string message);

        // Оголошення події
        public static event MyEventHandler MyEvent;

        public event Action OnButtonClick;

        public event EventHandler<DataEventArgs> DataReceived;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Door doors = new Door();
            Alarm alarm = new Alarm();

            doors.OnOpenDoor += alarm.OnDoorOpen;

            doors.OpenDoor();

            #region Базовий приклад
            //MyDelegate del = Test; // Збереження методу Test в делегаті

            //// Повторне додавання методу Test до делегату.
            //del += Test;
            //del += Test;

            //// Виклик методів через делегат
            //del("Привіт, делегате!");
            #endregion

            #region Приклад з калькулятором
            //// Створюємо калькулятор
            //Calculator calc = new Calculator();
            //Console.Write("Введіть вираз: ");
            //// Отримуємо вираз від користувача
            //string expression = Console.ReadLine();
            //char sign = ' ';
            //// визначення знака арифметичної дії
            //foreach (char item in expression)
            //{
            //    if (item == '+' || item == '-' || item == '*' || item == '/')
            //    {
            //        sign = item;
            //        break;
            //    }
            //}
            //try
            //{
            //    string[] numbers = expression.Split(sign); // отримання значень операндів
            //    CalcDelegate del = null;
            //    // В варіантах switch наведені різні способи збереження методів в делегаті
            //    switch (sign)
            //    {
            //        case '+':
            //            del = new CalcDelegate(calc.Add); // Збереження методу ексземпляру класу
            //            break;
            //        case '-':
            //            del = new CalcDelegate(Calculator.Sub); // Збереження статичного методу класу
            //            break;
            //        case '*':
            //            del = calc.Mult; // Додавання методу без виклику конструктора
            //            break;
            //        case '/':
            //            del = calc.Div;
            //            break;
            //        default:
            //            throw new InvalidOperationException();
            //    }
            //    // Виклик методу через делегат
            //    double result = del(double.Parse(numbers[0]), double.Parse(numbers[1]));
            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Приклад додавання та видалення методів
            //Calculator calc = new Calculator();
            //CalcDelegate delAll = null;
            //delAll += calc.Add; // додавання до списку викликів
            //delAll -= calc.Add; // видалення зі списку викликів
            #endregion

            #region Приклад multicasting
            Calculator calc = new Calculator();
            CalcDelegate delAll = calc.Add;
            delAll += Calculator.Sub;
            delAll += calc.Mult;
            delAll += calc.Div;

            // Якщо просто викликати методи через делегат, результат збереже значення, що повернув останній метод
            Console.WriteLine(delAll(2, 2));

            // Отримання всіх результатів
            foreach (CalcDelegate item in delAll.GetInvocationList()) // масив делегатів
            {
                try
                {
                    Console.WriteLine($"Результат: {item(5.7, 3.2)}"); // виклик
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            #endregion

            #region Generic приклад
            //AdditionClass example = new AdditionClass();
            //AddDelegate<int> delInt = example.AddInt;
            //Console.WriteLine($"The sum of integers: {delInt(8, 6)}");
            //AddDelegate<double> delDouble = example.AddDouble;
            //Console.WriteLine($"The sum of real numbers: {delDouble(45.67, 62.81)}");
            //AddDelegate<char> delChar = AdditionClass.AddChar;
            //Console.WriteLine($"The sum characters: {delChar('S', 'h')}");
            #endregion

            #region Приклад event
            //// Підписка на подію
            //MyEvent += EventHandler;

            //// Виклик події
            //MyEvent?.Invoke("Подія відбулася!");
            #endregion

            #region Action
            //Program program = new Program();
            //program.OnButtonClick += () => Console.WriteLine("Кнопка натиснута!");
            //program.TriggerButtonClick();
            #endregion

            #region EventHandler
            //Program program = new Program();
            //program.DataReceived += (sender, e) =>
            //    Console.WriteLine($"Отримано дані: {e.Data}");

            //program.TriggerDataReceived();
            #endregion

            #region Predicate
            //Predicate<int> isEven = number => number % 2 == 0;

            //Console.WriteLine(isEven(4));  // Виведе True
            //Console.WriteLine(isEven(7));  // Виведе False
            #endregion

            #region Func
            // Func делегат з двома параметрами (int, int) і повертає int
            //Func<int, int, int> add = (a, b) => a + b;

            //int result = add(5, 3);
            //Console.WriteLine(result);  // Виведе 8
            #endregion

            #region Анонімний метод
            //MyDelegate del = delegate (string msg)
            //{
            //    Console.WriteLine("Повідомлення: " + msg);
            //};

            //del("Привіт, світ!");  // Викликає анонімний метод
            #endregion

            #region Лямбда-вирази
            //MyDelegate del = (msg) =>
            //{
            //    Console.WriteLine("Повідомлення: " + msg);
            //};

            //del("Привіт, світ!");  // Викликає лямбда вираз
            #endregion

            #region Extention методи
            //string text = "Hello, world!";
            //Console.WriteLine(text.IsNullOrEmpty());  // Викликає Extension метод
            #endregion

            #region init
            Delegates.InitExample.Person person = new() { Age = 30, Name = "Антон" };
            // person.Age = 31;
            #endregion

            #region Записи
            //Person person1 = new Person("John", 30);
            //Person person2 = person1 with { Age = 31 };  // Створює копію з новим значенням

            //Console.WriteLine(person1);  // Person { Name = John, Age = 30 }
            //Console.WriteLine(person2);  // Person { Name = John, Age = 31 }
            #endregion

        }

        static void Test(string message)
        {
            Console.WriteLine(message);
        }

        static void EventHandler(string message)
        {
            Console.WriteLine("Обробник отримав повідомлення: " + message);
        }

        public void TriggerButtonClick()
        {
            OnButtonClick?.Invoke();
        }

        public void TriggerDataReceived()
        {
            DataReceived?.Invoke(this, new DataEventArgs("Привіт, світ!"));
        }
    }
    public class DataEventArgs : EventArgs
    {
        public string Data { get; }
        public DataEventArgs(string data) => Data = data;
    }
}
