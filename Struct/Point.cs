namespace Struct
{
    public struct Point
    {
        // специфікатор доступу за замовчуванням - public
        public int x; // але краще записувати
        public int y; // це підвищує читабельність коду

        public Point(int x, int y) // конструктор з параметрами
        {
            this.x = x; // ключове слово this - посилання на об'єкт, 
            this.y = y; // для якого викликано метод
        }

        public void Print() // струтури можуть мати методи
        {
            Console.WriteLine($"({x};{y})");
        }
    }
}