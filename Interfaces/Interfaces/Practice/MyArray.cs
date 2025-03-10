namespace Interfaces.Practice
{
    internal class MyArray : IOutput
    {
        private int[] _arr;

        public MyArray()
        {
            Random r = new Random();

            _arr = new int[10];

            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = r.Next();
            }
        }

        public void Show()
        {
            foreach (int i in _arr)
            {
                Console.WriteLine(i);
            }
        }

        public void Show(string info)
        {
            foreach (int i in _arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(info);
        }
    }
}
