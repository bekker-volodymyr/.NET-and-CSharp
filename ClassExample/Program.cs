using System.Text;

namespace ClassExample
{
    internal class Program
    {
        static void ChangeValue(Person p)
        {
            p.name = "Микола Хвильовий";
        }

        static void ChangeReference(Person p)
        {
            p = new Person("Іван Дзюба", 34);
        }

        static void ChangeObjReference(ref Person p)
        {
            p = new Person("Михайль Семенко", 23);
        }

        static void ChangeValueType(ref int value)
        {
            value = 10;
        }

        static void InitNumber(out int value)
        {
            value = 15;
        }

        static void InitPerson(out Person p)
        {
            p = new Person("Симон Петлюра", 30);
        }

        static void PrintNumbers(bool desc, params int[] numbers)
        {
            int[] arr = desc ? numbers : numbers.Reverse().ToArray();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Cat cat = new Cat() { Name = "Ґарфілд", Age = 5 };

            PrintNumbers(true, 10, 12, 34, 23, 45);

            int number;
            Person p;
            InitNumber(out number);
            InitPerson(out p);
            Console.WriteLine(number);
            Console.WriteLine(p.name);

            Person person = new Person("Тарас Шевченко", 27);
            Console.WriteLine(person.name); // дивимось старе значення
            ChangeObjReference(ref person);
            Console.WriteLine(person.name); // нове значення - метод змінив посилання

            int num = 12;
            ChangeValueType(ref num);
            Console.WriteLine(num);

            Person person2 = new Person("Микола Фітільов", 26);
            Console.WriteLine(person2.name); // дивимось старе значення
            ChangeValue(person2);
            Console.WriteLine(person2.name); // нове значення - метод змінив оригінал

            ChangeReference(person2);
            Console.WriteLine(person2.name); // значення не змінилось - метод використовує локальне посилання
        }
    }
}
