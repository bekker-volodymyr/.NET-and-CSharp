namespace BoxingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            object obj = num; // boxing

            int unbox = (int)obj; // unboxing

            float cast = (float)obj; // InvalidCastException
        }
    }
}
