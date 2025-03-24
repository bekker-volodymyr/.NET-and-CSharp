using System.Text;
using System.Text.RegularExpressions;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            #region FileStream 1
            //using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate))
            //{
            //    // Перетворюємо рядок Привіт! в масив байтів
            //    byte[] data = Encoding.UTF8.GetBytes("Привіт!");
            //    // Записуємо масив байтів у файл
            //    fs.Write(data, 0, data.Length);
            //}
            #endregion

            // Console.WriteLine("-----------------------------");

            #region FileStream 2
            //string path = "test.bin";

            //using (FileStream fs = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    // Записуємо масив байтів до файлу
            //    fs.Write(Encoding.UTF8.GetBytes("Деякий текст для запису в файл у байтовому вигляді"));

            //    // Повертаємо позицію напочаток файлу перед читанням
            //    fs.Position = 0;

            //    // Зчитуємо побайтово інформацію з файлу та зберігаємо в буфер
            //    int data;
            //    byte[] buffer = new byte[fs.Length];
            //    int i = 0;
            //    do
            //    {
            //        data = fs.ReadByte();

            //        if (data == -1) break;

            //        buffer[i] = (byte)data;
            //        i++;

            //    } while (data != -1);

            //    // Конвертуємо буфер байтів в рядок та виводимо в консоль
            //    Console.WriteLine(Encoding.UTF8.GetString(buffer));
            //}
            #endregion

            //Console.WriteLine("-------------------------------");

            #region FileStream 3
            //string path = "test.bin";

            //using (FileStream fs = new(path, FileMode.OpenOrCreate))
            //{
            //    // Створюємо буферний масив байтів
            //    // Довжина масиву дорівнює довжені файлового потоку
            //    // Довжина потоку - тип long, тому виконуємо перетворення до int
            //    byte[] buffer = new byte[(int)fs.Length];

            //    // Зчитуємо файл у буфер
            //    fs.Read(buffer, 0, buffer.Length);

            //    // Конвертуємо буфер байтів в рядок та виводимо в консоль
            //    Console.WriteLine(Encoding.UTF8.GetString(buffer));
            //}
            #endregion

            // Console.WriteLine("-------------------------------");

            #region StreamWriter
            //using (StreamWriter writer = new StreamWriter("file2.txt"))
            //{
            //    writer.WriteLine("Перший рядок в файл");
            //    writer.WriteLine("Ще рядок");
            //    writer.Write("Запис без розриву рядку");
            //    writer.WriteLine(". Продовження попереднього запису в одному рядку");
            //    writer.WriteLine("Іі Її Єє Ґґ");
            //}
            #endregion

            //Console.WriteLine("-------------------------------");

            #region StreamReader
            //using (StreamReader reader = new StreamReader("file2.txt"))
            //{
            //    Console.WriteLine(reader.ReadLine());

            //    Console.WriteLine(reader.ReadToEnd());
            //}
            #endregion

            //Console.WriteLine("-------------------------------");

            #region BinaryWriter
            //using (FileStream fs = new("binary.dat", FileMode.OpenOrCreate))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs))
            //    {
            //        bw.Write(123); // Записує ціле число
            //        bw.Write("Hello"); // Записує рядок
            //        bw.Write(true); // Записує bool
            //        bw.Write(10.3f); // Записує float
            //    }
            //}
            #endregion

            //Console.WriteLine("-------------------------------");

            #region BinaryReader
            //using (FileStream fs = new("binary.dat", FileMode.OpenOrCreate))
            //{
            //    using (BinaryReader br = new BinaryReader(fs))
            //    {
            //        int number = br.ReadInt32(); // Читання цілого числа
            //        Console.WriteLine(number);
            //        string str = br.ReadString(); // Читання рядка
            //        Console.WriteLine(str);
            //        bool boolean = br.ReadBoolean(); // Читання bool
            //        Console.WriteLine(boolean);
            //        float floatNum = br.ReadSingle(); // Читання float
            //        Console.WriteLine(floatNum);
            //    }
            //}
            #endregion

            // Console.WriteLine("-------------------------------");

            #region Directory
            //string directoryPath = @"C:\ExampleDirectory";

            //// Створення каталогу
            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //    Console.WriteLine("Каталог створено.");
            //}

            //// Перевірка, чи існує каталог
            //if (Directory.Exists(directoryPath))
            //{
            //    Console.WriteLine("Каталог існує.");
            //}

            //// Отримання списку файлів у каталозі
            //string[] files = Directory.GetFiles(directoryPath);
            //Console.WriteLine("Файли в каталозі:");
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //// Видалення каталогу
            ////Directory.Delete(directoryPath);
            //Directory.Delete(directoryPath, true);
            //Console.WriteLine("Каталог видалено.");
            #endregion

            // Console.WriteLine("-------------------------------");

            #region File

            //string new_path = @"C:\ExampleFile.txt";

            //// Створення нового файлу
            //if (!File.Exists(new_path))
            //{
            //    File.WriteAllText(new_path, "Привіт, C#!");
            //    Console.WriteLine("Файл створено.");
            //}

            //// Перевірка, чи існує файл
            //if (File.Exists(new_path))
            //{
            //    Console.WriteLine("Файл існує.");
            //}

            //// Читання вмісту файлу
            //string content = File.ReadAllText(new_path);
            //Console.WriteLine($"Вміст файлу: {content}");

            //// Копіювання файлу
            //string copyPath = @"C:\ExampleFileCopy.txt";
            //File.Copy(new_path, copyPath, true);
            //Console.WriteLine("Файл скопійовано.");

            //// Видалення файлу
            //File.Delete(new_path);
            //Console.WriteLine("Файл видалено.");

            #endregion

            // Console.WriteLine("-------------------------------");

            #region DirectoryInfo
            //DirectoryInfo dir = new DirectoryInfo("."); // поточний каталог
            //Console.WriteLine($"Повний шлях до каталогу:\n{dir.FullName}");
            //Console.WriteLine($"Час створення каталогу: {dir.CreationTime}");

            //Console.WriteLine("\n\tВсі файли каталогу:");
            //FileInfo[] allFiles = dir.GetFiles(); // всі файли в каталозі
            //foreach (FileInfo f in allFiles)
            //{
            //    Console.WriteLine($"{f.Name} - {f.Length} байт");
            //}
            #endregion

            //Console.WriteLine("-------------------------------");

            #region FileInfo
            //string pathInfo = @"C:\ExampleFile.txt";
            //FileInfo fileInfo = new FileInfo(pathInfo);

            //// Створення нового файлу
            //if (!fileInfo.Exists)
            //{
            //    using (FileStream fs = fileInfo.Create())
            //    {
            //        byte[] content_ = System.Text.Encoding.UTF8.GetBytes("Привіт, C#!");
            //        fs.Write(content_, 0, content_.Length);
            //        Console.WriteLine("Файл створено.");
            //    }
            //}

            //// Перевірка, чи існує файл
            //if (fileInfo.Exists)
            //{
            //    Console.WriteLine("Файл існує.");
            //}

            //// Отримання розміру файлу
            //Console.WriteLine($"Розмір файлу: {fileInfo.Length} байт");

            //// Копіювання файлу
            //string copyPathInfo = @"C:\ExampleFileCopy.txt";
            //FileInfo fileCopy = fileInfo.CopyTo(copyPathInfo, true);
            //Console.WriteLine("Файл скопійовано.");

            //// Видалення файлу
            //fileInfo.Delete();
            //Console.WriteLine("Файл видалено.");

            //fileCopy.Delete();
            //Console.WriteLine("Копія видалена.");

            #endregion

            Console.WriteLine("-------------------------------");

            #region Regex
            /*
             * [літери+цифри+крапка+нижнє підкреслювання]@[літери+крапка+літери]
             * [9 цифр]
             */

            string emailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";

            Console.Write("Введіть e-mail: ");
            string email = Console.ReadLine();
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(regex.IsMatch(email) ? "E-mail підтверджено." : "Невірний e-mail!");

            string phonePattern = @"^\+\d{ 2}\(\d{ 3}\)\d{ 3}-\d{ 2}-\d{ 2}$";
            Console.Write("Введіть номер телефону: ");
            string phone = Console.ReadLine();
            regex = new Regex(phonePattern);
            Console.WriteLine(regex.IsMatch(phone) ? "Телефон записано." : "Невірний формат номеру!");

            Console.WriteLine("\nЗаміна тексту, що задовольняє вираз");
            string text = "I like Java. Java forever. 109";
            string textPattern = "[0-9]";

            Console.WriteLine(text);
            Console.WriteLine(Regex.Replace(text, textPattern, "C#"));
            #endregion
        }
    }
}
