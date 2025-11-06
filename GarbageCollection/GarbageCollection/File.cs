namespace GarbageCollection
{
    public class File : IDisposable
    {
        string _fileName;
        string _filePath;
        string _data = string.Empty;
        bool _isOpened = false;

        public File(string fileName, string filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }

        public void AddData(string data)
        {
            if (!_isOpened) throw new UnauthorizedAccessException("Файл недоступний!");
            _data += data;
        }

        public void OpenFile()
        {
            _isOpened = true;
        }

        public void CloseFile()
        {
            _isOpened = false;
        }

        public void Dispose()
        {
            Console.WriteLine("Метод Dispose");
            if (_isOpened)
            {
                CloseFile();
            }
        }

        ~File()
        {
            Console.WriteLine("Виклик фіналізатора");
            Dispose();
        }
    }
}