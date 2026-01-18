using Interfaces.ResearcherExample;
using Interfaces.StudentsExample;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            IResearcher researcher = new Mathematician();

            researcher.Investigate();
            researcher.Invent();

            #region Shop example
            //Director director = new Director
            //{
            //    LastName = "Doe",
            //    FirstName = "John",
            //    BirthDate = new DateTime(1998, 10, 12),
            //    Position = "Директор",
            //    Salary = 12000
            //};

            //IWorker seller = new Seller
            //{
            //    LastName = "Beam",
            //    FirstName = "Jim",
            //    BirthDate = new DateTime(1956, 5, 23),
            //    Position = "Продавець",
            //    Salary = 3780
            //};

            //if (seller is Employee)
            //{
            //    Console.WriteLine($"Зарабітна плата продавця: {(seller as Employee).Salary}"); // приведення інтерфейсного посилання до класу Employe
            //}

            //director.ListOfWorkers = new List<IWorker> {
            //    seller,
            //    new Cashier { LastName = "Smith", FirstName = "Nicole",
            //                  BirthDate = new DateTime(1956, 5, 23),
            //                  Position = "Касир", Salary = 3780 },
            //    new Storekeeper { LastName = "Ross", FirstName = "Bob",
            //                  BirthDate = new DateTime(1956, 5, 23),
            //                  Position = "Комірник", Salary = 4500 }
            //};

            //Console.WriteLine(director);

            //if (director is IManager) // використання оператора is
            //{
            //    director.Control();
            //}

            //foreach (IWorker item in director.ListOfWorkers)
            //{
            //    Console.WriteLine(item);
            //    if (item.IsWorking)
            //    {
            //        Console.WriteLine(item.Work());
            //    }
            //}
            #endregion

            #region Game example
            //Player player = new Player();
            //Enemy enemy = new Enemy();
            //Ally ally = new Ally();

            //player.Attack(enemy);
            //enemy.Attack(ally);
            //ally.Attack(enemy);

            //player.Attack(ally);
            //enemy.Attack(ally);
            //ally.Attack(enemy);

            //player.Attack(ally);
            //enemy.Attack(ally);
            //ally.Attack(enemy);
            #endregion

            #region Indexer example
            //IndexerClass indexerClass = new IndexerClass();
            //Console.WriteLine("\t\tВиведення значень\n");
            //Console.WriteLine("Використання індексатора з цілочисельним параметром:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(indexerClass[i]);
            //}
            //Console.WriteLine("\nВикористання індексатора з рядковим параметром:");
            //foreach (string item in Enum.GetNames(typeof(Numbers)))
            //{
            //    Console.WriteLine(indexerClass[item]);
            //}
            #endregion

            #region Explicit example
            //ExplicitRealization er = new ExplicitRealization();
            //er.Show(); // виклик методу інтерфейсу IC неявно

            //((IA)er).Show(); // виклик методу інтерфейсу IA явно

            //IB iB = new ExplicitRealization();
            //iB.Show(); // виклик методу інтерфейсу IB через посилання
            #endregion

            #region Students example
            Auditory auditory = new Auditory();
            Console.WriteLine("\n---------- Студенти в аудиторії ----------\n");
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n---------- Сортування за прізвищем ----------\n");
            auditory.Sort();
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n----------  Сортування за датою народження  ----------\n");
            auditory.Sort(new DateComparer());
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n---------- Копіювання ----------\n");
            Student student1 = new Student
            {
                FirstName = "Greg",
                LastName = "Carter",
                BirthDate = new DateTime(1999, 12, 5),
                StudentCard = new StudentCard { Number = 784523, Series = "ММ" }
            };
            Student student2 = (Student)student1.Clone();

            Console.WriteLine(student1);
            Console.WriteLine(student2);

            Console.WriteLine("\n---------- Зміна ----------\n");

            student2.StudentCard.Number = 817423;
            student2.StudentCard.Series = "КК";

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            #endregion

            #region Library Example
            //Library library = new Library();

            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}

            //Console.WriteLine("Сортуємо бібліотеку...");
            //library.Sort();

            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}

            //Console.WriteLine("Сортуємо за ім'ям автора...");
            //library.Sort(new AuthorNameComparer());

            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Task 1

            #endregion

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            Array.Sort(arr);
            Array.BinarySearch(arr, 4);


            Console.WriteLine("Hello, world!");
        }
    }
}
