namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Console.WriteLine("Демонстрація System.GC");
            //Console.WriteLine($"Максимальне покоління: {GC.MaxGeneration}");
            //GarbageHelper hlp = new GarbageHelper();

            //// дізнаємося покоління, в якому перебуває об'єкт
            //Console.WriteLine($"Покоління об'єкта: {GC.GetGeneration(hlp)}");

            //// кількість зайнятої пам'яті
            //Console.WriteLine($"Зайнято пам'яті (байт): {GC.GetTotalMemory(false)}");

            //hlp.MakeGarbage(); // створюємо сміття
            //Console.WriteLine($"Зайнято пам'яті (байт): {GC.GetTotalMemory(false)}");

            //GC.Collect(0); // викликаємо явний збір сміття в поколінні 0
            //Console.WriteLine($"Зайнято пам'яті (байт): {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Покоління об'єкта: {GC.GetGeneration(hlp)}");

            //GC.Collect(); // викликаємо явний збір сміття у всіх поколіннях
            //Console.WriteLine($"Зайнято пам'яті (байт): {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Покоління об'єкта: {GC.GetGeneration(hlp)}");

            // Dispose
            using (DisposeExample test = new DisposeExample())
            {
                test.DoSomething();
            }

            // або

            //DisposeExample test = new DisposeExample();
            //try
            //{
            //    test.DoSomething();
            //}
            //finally
            //{
            //    test.Dispose();
            //}
        }
    }

    // Допоміжний клас для створення сміття
    public class GarbageHelper
    {
        // Метод, що створює сміття
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person p = new Person();
            }
        }
        class Person
        {
            string _name;
            string _surname;
            byte _age;
        }
    }
}
