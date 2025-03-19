using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region ArrayList
            // Створюємо та ініціалізуємо новий ArrayList.
            //ArrayList myAL = new ArrayList(); // місткість за замовчуванням
            //ArrayList myAL2 = new ArrayList(5); // початкове значення
            //ArrayList myAL3 = new ArrayList(new int[] { 3, 10, 45 }); // копіювати значення іншої колекції

            //myAL.Add("Привіт");
            //myAL.Add("Світе");
            //myAL.Add("!");

            //// Вивід властивостей ArrayList.
            //Console.WriteLine("myAL");
            //Console.WriteLine("\tКількість:    {0}", myAL.Count);
            //Console.WriteLine("\tМісткість: {0}", myAL.Capacity);
            //Console.Write("\tЗначення:");
            //PrintValues(myAL);

            //myAL.TrimToSize(); // зменшити місткість до кількості елементів
            //Console.WriteLine("myAL");
            //Console.WriteLine("\tКількість:    {0}", myAL.Count);
            //Console.WriteLine("\tМісткість: {0}", myAL.Capacity);
            //Console.Write("\tЗначення:");
            //PrintValues(myAL);

            //myAL.Add("Бувай"); // додати один елемент
            //myAL.AddRange(new string[] { "тест", "рядок" }); // додати елементи іншої колекції
            #endregion

            #region Box
            //Box<int> boxInt = new Box<int>();
            //Box<string> boxStr = new Box<string>();

            //boxInt.Value = 10;
            //boxStr.Value = "lsdafdsf";

            //Console.WriteLine(boxInt.Value);
            //Console.WriteLine(boxStr.Value);
            #endregion

            #region Generic Method
            int a = 10;
            int b = 12;

            Swap(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");

            float af = 10.5f;
            float bf = 1.5f;

            Swap(ref af, ref bf);
            Console.WriteLine($"af: {af}, bf: {bf}");

            #endregion
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}