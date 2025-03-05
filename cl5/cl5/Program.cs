namespace cl5
{
    internal class Program
    {
        static int DivisionNumbers(int n1, int n2)
        {
            int result = 0;
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            return result;
        }

        static void Main(string[] args)
        {
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
            Console.WriteLine("Write nums");
            string num = Console.ReadLine();
            int num1 = 0;
            try
            {
                num1 = Convert.ToInt32(num);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
