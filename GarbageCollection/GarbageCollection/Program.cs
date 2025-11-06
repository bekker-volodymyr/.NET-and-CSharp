namespace GarbageCollection
{
    internal class Program
    {
        static void WorkWithFile()
        {
            File file = new File("Test.txt", "C:\\public\\test\\");

            file.OpenFile();
            file.AddData("Hello world");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Демонстрація System.GC");
            Console.WriteLine($"Максимальне покоління: {GC.MaxGeneration}");
            string str = new string("Hello");

            // Покоління, в якому перебуває об'єкт
            Console.WriteLine($"Покоління об'єкта: {GC.GetGeneration(str)}");

            // кількість зайнятої пам'яті
            Console.WriteLine($"Виділено пам'яті (байт): {GC.GetTotalMemory(false)}");

            GarbageHelper hlp = new GarbageHelper();
            hlp.MakeGarbage(); // створюємо сміття
            Console.WriteLine($"Виділено пам'яті (байт): {GC.GetTotalMemory(false)}");

            GC.Collect(0); // викликаємо явний збір сміття в поколінні 0
            Console.WriteLine($"Виділено пам'яті (байт): {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Покоління об'єкта: {GC.GetGeneration(hlp)}");

            GC.Collect(); // викликаємо явний збір сміття у всіх поколіннях
            Console.WriteLine($"Зайнято пам'яті (байт): {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Покоління об'єкта: {GC.GetGeneration(hlp)}");


            WorkWithFile();

            GC.Collect(); // виклик фіналізатора
            Console.WriteLine($"Зайнято пам'яті (байт): {GC.GetTotalMemory(true)}"); // звільнення пам'яті після другої збірки


            File file = new File("Test.txt", "C:\\public\\test\\");
            try
            {
                file.OpenFile();
                file.AddData("fasdfs");
                file.AddData("asdfasdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Dispose();
            }

            using (File f = new File("Test.txt", "C:\\public\\test\\"))
            {
                f.OpenFile();
                f.AddData("asdfsdfs");
                f.AddData("fasdfajs;dlfjasldf");
            } // Автоматичний виклик Dispose

            // автоматичний виклик Dispose при виході з області видимості
            // Починаючи з C# 8.0
            using File f2 = new File("Dispose.txt", "C:\\users\\test\\");

            f2.OpenFile();
            f2.AddData("new data");

            // Dispose
            using (DisposeExample test1 = new DisposeExample())
            {
                test1.DoSomething();
            }

            // або

            DisposeExample test2 = new DisposeExample();
            try
            {
                test2.DoSomething();
            }
            finally
            {
                test2.Dispose();
            }
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
