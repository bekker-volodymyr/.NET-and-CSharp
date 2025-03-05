//using Inheritence.BaseKeyword;
//using Inheritence.NameHiding;

namespace Inheritence
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Для виводу літери І
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Приклад спадкування
            //Employee employee = new Employee("Микола", "Тарасенко", 2563.57);
            //employee.Print();

            //Human human = new Employee("Антон", "Сердюк", 10000);
            //human.Print();

            //Console.WriteLine(employee._id);

            // Порядок виклику конструкторів
            //Three obj = new Three();

            //(obj as One).Show();

            // Ключове слово base
            //B b = new();

            //BaseKeyword.Child child = new BaseKeyword.Child();
            //child.ShowChild();

            // Приховування імен під час спадкування
            //NameHiding.Child child = new NameHiding.Child();
            //child.Show(); // Виклик методу дочірнього класу

            //NameHiding.Parent parent = new NameHiding.Parent();
            //parent.Show(); // Виклик методу батьківського класу

            //NameHiding.Parent child2 = new NameHiding.Child();
            //child2.Show(); // Виклик методу батьківського класу

            // Віртуальні методи
            //VirtualMethods.DerivedClass derivedClass = new VirtualMethods.DerivedClass();
            //derivedClass.Show(); // метод дочірнього класу

            //VirtualMethods.BaseClass baseClass = new VirtualMethods.BaseClass();
            //baseClass.Show(); // метод батьківського класу

            //VirtualMethods.BaseClass derivedClass2 = new VirtualMethods.DerivedClass();
            //derivedClass2.Show(); // метод дочірнього класу - пізнє зв'язування

            // Абстрактний клас

            // AbstractClass.Shape shape = new AbstractClass.Shape(); // error

            //AbstractClass.Shape shape = new AbstractClass.Circle(3.5);
            //shape.GetArea();

            // Використання посилання на базовий клас
            // Animal animal = new Cat { Name = "Патрон" };

            // animal.Bark();

            // Явне приведення (explicit cast)
            // Поганий варіант, якщо приведення не вийде програма вилетить!
            //Dog dog1 = (Dog)animal;
            //dog1.Bark();

            // Приведення через ключове слово as
            //Dog dog2 = animal as Dog;
            //if (dog2 != null)
            //{
            //    dog2.Bark();
            //}

            //// Приведення через is + приведення
            //if (animal is Dog dog3)
            //{
            //    dog3.Bark();
            //}

            One one = new One();

            Console.WriteLine(one.ToString());
        }
    }

    class One
    {
        public One() { Console.WriteLine("Конструктор One"); }

        public virtual void Show()
        {
            Console.WriteLine("Show Class One");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Two : One
    {
        public Two() { Console.WriteLine("Конструктор Two"); }
        public override void Show()
        {
            Console.WriteLine("Show Class Two");
        }
    }

    class Three : Two
    {
        public Three() { Console.WriteLine("Конструктор Three"); }
    }
}
