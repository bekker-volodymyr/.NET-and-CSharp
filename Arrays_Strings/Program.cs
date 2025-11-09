using System.Text;

namespace Arrays_Strings
{
    enum Status : byte
    {
        Online, Offline, Unknown
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Status status = Status.Online;

            switch (status)
            {
                case Status.Online: Console.WriteLine("User is online"); break;
                case Status.Offline: Console.WriteLine("User is offline"); break;
                default: Console.WriteLine("User status is unknonw"); break;
            }

            Console.WriteLine(status.ToString());
            var enumNames = Enum.GetNames(typeof(Status));
            foreach (var enumName in enumNames)
            {
                Console.WriteLine(enumName);
            }

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            object[] objects = { true, 10, new Random(), "Hello", new int[5] { 1, 4, 5, 6, 7 } };

            int[] arr1; // пусте посилання - null
            int[] arr2 = new int[10]; // виділення пам'яті без ініціалізації
            arr2 = new int[50]; // переназначення посилання
            int[] arr3 = new int[4] { 1, 2, 3, 4 }; // створення посилання та ініціалізація
            int[] arr4 = { 1, 2, 3 }; // створення посилання та ініціалізація

            //Array.Resize(ref arr4, 5);
            //Console.WriteLine(arr4.Length);

            Console.WriteLine(arr4.Sum());

            object arrClone = arr4.Clone();

            int[] arr5 = new int[3];
            arr4.CopyTo(arr5, 0);
            Array.Copy(arr4, arr5, arr4.Length);
            foreach (var i in arr5)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Random random = new Random();

            int[] arr6 = new int[10];
            for (int i = 0; i < arr6.Length; i++)
            {
                arr6[i] = random.Next(0, 11);
            }

            foreach (var i in arr6)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Array.Sort(arr6);
            foreach (var i in arr6)
            {
                Console.Write($"{i}, ");
            }
            int index = Array.BinarySearch(arr6, 7);
            Console.WriteLine($"{index}");

            // Console.WriteLine(arr4[12]);

            int[,] arr2d_1; // пусте посилання - null
            int[,] arr2d_2 = new int[10, 3]; // виділення пам'яті без ініціалізації
            int[,] arr2d_3 = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }; // створення посилання та ініціалізація
            int[,] arr2d_4 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } }; // створення посилання та ініціалізація

            Console.WriteLine(arr2d_2.GetUpperBound(0));

            int[,,] arr3d = new int[3, 2, 3]
            {
                {
                    { 1, 2, 3 },
                    { 5, 6, 7 }
                },
                {
                    { 4, 5, 6 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 7, 8, 9 }
                }
            };

            foreach (var i in arr4)
            {
                Console.Write($"{i}, ");
            }

            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }

            Console.WriteLine(arr3d.Length);
            Console.WriteLine(arr3d.Rank);
            Console.WriteLine(arr3d.GetUpperBound(0));
            Console.WriteLine(arr3d.GetUpperBound(1));
            Console.WriteLine(arr3d.GetUpperBound(2));

            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                for (int j = 0; j < arr3d.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3d.GetLength(2); k++)
                    {
                        Console.Write($"{arr3d[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            foreach (var i in arr3d)
            {
                Console.WriteLine(i);
            }

            string str; // пусте посилання - null
            string str2 = "Hello";
            string str3 = new string("Hello");

            Console.WriteLine(str2[3]);
            // str2[3] = 'F';

            str2 = "Hello, world";

            Console.WriteLine(str2.IndexOfAny(new char[] { 'o', 'j', 'c' }));

            string str4 = str2 + ", world";

            string s = string.Format("X = {0:F2}, Y = {1}", 12.345, 7);

            DateTime date = DateTime.Now;
            string s2 = $"X = {12.345:F2}, Y = {7}, date = {date:M}";
            Console.WriteLine(s2);

            StringBuilder sb = new StringBuilder();

            sb.Append(date.ToString());
            sb.Append("Hello, world");

            string result = sb.ToString();
        }
    }
}
