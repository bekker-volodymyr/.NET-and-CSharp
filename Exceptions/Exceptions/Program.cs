namespace Exceptions
{
    internal class Program
    {
        static void DivideNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //DivideNumbers(1, 0);

            //try
            //{
            //    throw new Exception("Exception Throw Example");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    // HANDLE DIVIDE BY ZERO
            //}
            //catch (Exception ex)
            //{
            //    // HANDLING EXCEPTION
            //}
            //finally
            //{
            //    // DO SOME WORK THAT MUST BE DONE: CLOSE FILE STREAM, CONNECTION ETC.
            //}

            //int number1, number2, result = 0;
            //Console.WriteLine("Введіть два числа");
            //try
            //{
            //    number1 = int.Parse(Console.ReadLine());
            //    number2 = int.Parse(Console.ReadLine());
            //    result = number1 / number2;
            //    Console.WriteLine($"Результат ділення чисел: {result}");
            //}
            //catch (DivideByZeroException de)
            //{
            //    Console.WriteLine(de.Message);
            //}

            //try
            //{
            //    Random r = new Random();
            //    int number = r.Next(0, 10);
            //    if (number > 5)
            //    {
            //        throw new ArgumentException($"Random Number is bigger then 5: {number}");
            //        //throw new SpecialException("Exception Throw Example");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Поля винятків - readonly!
            //    // ex.Message = "sdfjsdjkfs";

            //    Console.WriteLine($"{ex.Message}");
            //    // Console.WriteLine($"{ex.Time}");
            //}

            string numStr = "00011110101";

            int numInt = Convert.ToInt32(numStr, 2);

            // Обробка різних типів винятків
            //try
            //{
            //    Console.Write($"\nВведіть число: ");
            //    string str = Console.ReadLine();
            //     Перетворення - виняток FormatException згенерується CLR автоматично, якщо рядок не вийде перетворити на INT
            //    int number = Convert.ToInt32(str);
            //     Генеруємо виняток, якщо число менше 0
            //    if (number < 0)
            //        throw new ArgumentOutOfRangeException("Число менше 0");
            //    double sqrt = Math.Sqrt(number);
            //    Console.WriteLine($"Квадратний корінь числа {number} дорівнює {sqrt}");
            //}
            //catch (FormatException fe)
            //{
            //     Виконується, якщо ввод користувача неможливо перетворити на рядок
            //    Console.WriteLine(fe.Message);
            //}
            //catch (ArgumentOutOfRangeException de)
            //{
            //     Виконується, якщо число менше 0
            //    Console.WriteLine(de.Message);
            //}
            //catch (Exception e)
            //{
            //     Обробка будь яких інших винятків
            //    Console.WriteLine($"Exception: {e.Message}");
            //}

            // Вкладені блоки try
            //int[] a = new int[5];
            //int n = 0;
            //try
            //{
            //    for (int i = -3; i <= 3; i++)
            //    {
            //        // під час ділення на 0 не відбувається вихід із циклу:
            //        // виняток перехоплюється і
            //        // обробляється внутрішнім блоком try
            //        try // внутрішній блок try
            //        {
            //            a[n] = 100 / i;
            //            Console.WriteLine(a[n]);
            //            n++;
            //        }
            //        catch (DivideByZeroException e)
            //        {
            //            Console.WriteLine("Внутрішній catch");
            //            Console.WriteLine(e.Message);
            //        }
            //    }
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("Зовнішній catch");
            //    Console.WriteLine(e.Message);
            //}

            // Повторна генерація винятків
            //Console.WriteLine("Введіть два числа");
            //int number1, number2, result = 0;
            //try
            //{
            //    number1 = int.Parse(Console.ReadLine());
            //    number2 = int.Parse(Console.ReadLine());
            //    result = DivisionNumbers(number1, number2);
            //    Console.WriteLine($"Результат ділення чисел: {result}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // checked/unchecked
            //byte b = 100;
            //Console.WriteLine(unchecked((byte)(b + 200))); // b = 44
            //try
            //{
            //    Console.WriteLine(checked((byte)(b + 200))); // генерація винятку
            //}
            //catch (OverflowException oe)
            //{
            //    Console.WriteLine(oe.Message);
            //}

            //Фільтри винятків
            //try 
            //{
            //    // GENERATE EXCEPTION
            //}
            //catch (Exception ex) when (10 == 10)
            //{
            //    // HANDLE EXCEPTION
            //}

            //Console.WriteLine("Введіть два числа");
            //int number1, number2, result = 0;
            //try
            //{
            //    number1 = int.Parse(Console.ReadLine());
            //    number2 = int.Parse(Console.ReadLine());
            //    result = DivisionNumbers(number1, number2);
            //    Console.WriteLine($"Результат ділення чисел: {result}");
            //}
            //catch (Exception e) when (e.InnerException != null)
            //{
            //    Console.WriteLine(e.Message); // додаткова інформація
            //    Console.WriteLine(e.InnerException.Message); // попередній виняток
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // nameof
            //try
            //{
            //    ExampleNameOf example = new ExampleNameOf("LKDJFLSDJ", null);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    DivisionNumbers(10, 0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Обробка в методі Main");
            //    Console.WriteLine(ex.Message);
            //}

        }

        static int DivisionNumbers(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Обробка в методі DivisionNumbers");
                Console.WriteLine(de.Message);
                // CLOSE CONNECTION

                // ВИКИДАЄМО ВИНЯТОК, ЩОБ ПОПЕРЕДНІЙ ОБ'ЄКТ ТАКОЖ
                // ЗНАВ ПРО ПОМИЛКУ
                throw new Exception("Division by zero");
            }
            return result;
        }
    }
}
