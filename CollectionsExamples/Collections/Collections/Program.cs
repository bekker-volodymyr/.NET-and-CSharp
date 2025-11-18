using Collections.IteratorExample;
using System.Collections;

namespace Collections
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Name = "Іван";
        }

        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region ArrayList
            // Створюємо та ініціалізуємо новий ArrayList.
            ArrayList myAL = new ArrayList(); // місткість за замовчуванням
            ArrayList myAL2 = new ArrayList(5); // початкове значення
            ArrayList myAL3 = new ArrayList(new int[] { 3, 10, 45 }); // копіювати значення іншої колекції

            myAL.Add("Привіт");
            myAL.Add("Світе");
            myAL.Add("!");

            // Вивід властивостей ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("\tКількість:    {0}", myAL.Count);
            Console.WriteLine("\tМісткість: {0}", myAL.Capacity);
            Console.Write("\tЗначення:");
            PrintValues(myAL);

            myAL.TrimToSize(); // зменшити місткість до кількості елементів
            Console.WriteLine("myAL");
            Console.WriteLine("\tКількість:    {0}", myAL.Count);
            Console.WriteLine("\tМісткість: {0}", myAL.Capacity);
            Console.Write("\tЗначення:");
            PrintValues(myAL);

            myAL.Add("Бувай"); // додати один елемент
            myAL.AddRange(new string[] { "тест", "рядок" }); // додати елементи іншої колекції

            myAL.Add(1);
            myAL.Add(true);
            myAL.Add(4.5f);
            #endregion

            #region List

            List<string> list = new List<string>();

            list.Add("test");
            // list.Add(1); // помилка

            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count: {list.Count}");

            list.Clear();

            list.Add("test");
            list.Remove("test");

            Console.WriteLine(list[0]);

            // Створення списку (АЛЕ ЦЕ ДИНАМІЧНИЙ МАСИВ!!) користувацького типу
            List<Person> persons = new List<Person>();

            #endregion

            #region Box
            //Box<int> boxInt = new Box<int>();
            //Box<string> boxStr = new Box<string>();

            //boxInt.Value = 10;
            //boxStr.Value = "lsdafdsf";

            //Console.WriteLine(boxInt.Value);
            //Console.WriteLine(boxStr.Value);
            #endregion

            #region Swap Example
            //int a = 10;
            //int b = 20;

            //Swap(ref a, ref b);

            //Person person1 = new Person();
            //Person person2 = new Person("Вова");

            //Swap(ref person1, ref person2);
            #endregion

            #region Generic Restrictions
            //Repository<Person> repository = new Repository<Person>();

            //Repository<int> repository1 = new Repository<int>();
            #endregion

            #region Generic Method
            //int a = 10;
            //int b = 12;

            //Swap(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b}");

            //float af = 10.5f;
            //float bf = 1.5f;

            //Swap(ref af, ref bf);
            //Console.WriteLine($"af: {af}, bf: {bf}");

            #endregion

            #region Dictionary Example
            Dictionary<string, Person> personsDict = new Dictionary<string, Person>();

            personsDict.Add("перший", new Person());
            personsDict.Add("другий", new Person("Антон"));

            Console.WriteLine(personsDict["перший"]);
            Person person = new Person();
            personsDict.TryGetValue("перший", out person);

            //personsDict.Clear();

            personsDict.Remove("другий");

            personsDict["другий"] = new Person("Андрій");

            Console.Write(personsDict.Count);

            foreach (var key in personsDict.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in personsDict.Values)
            {
                Console.WriteLine(value);
            }

            #endregion

            #region Queue Example
            Queue<Person> people = new Queue<Person>();

            people.Enqueue(new Person());
            people.Enqueue(new Person("Антон"));

            Console.WriteLine($"Count {people.Count}");

            //Person human = people.Dequeue();

            Console.WriteLine($"Count {people.Count}");

            //Console.WriteLine($"{human.Name}");

            Person human2 = people.Peek();

            Console.WriteLine($"Count {people.Count}");
            Console.WriteLine(human2.Name);
            #endregion

            #region Stack Example
            Stack<string> stack = new Stack<string>();

            stack.Push("HELLO");
            stack.Push("WORLD");
            stack.Push("!!!!");

            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Count);

            #endregion

            Auditory auditory = new Auditory();

            foreach (var student in auditory)
            {
                Console.WriteLine(student.ToString());
            }
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

        public static T Sum<T>(T[] arr) where T : struct
        {
            dynamic sum = default(T);

            foreach (T t in arr)
            {
                sum += t;
            }

            return sum;
        }
    }
}