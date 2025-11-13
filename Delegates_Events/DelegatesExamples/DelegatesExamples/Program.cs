namespace DelegatesExamples
{
    internal class Program
    {
        public delegate bool MyPredicate<T>(T t);

        public static event Action<string, int> OnEventHappened;
        static void Main(string[] args)
        {
            OnEventHappened += OnSmthHappend;

            OnEventHappened.Invoke("test", 10);

            Predicate<int> pred = (x) => x > 0;

            MyPredicate<string> isHello = (str) => str == "Hello";
            isHello += (str) => str == "hello";

            Console.WriteLine(isHello("Hello"));
            Console.WriteLine(isHello("test"));

            Console.WriteLine(pred(-1));
            Console.WriteLine(pred(1));
        }

        public static void OnSmthHappend(string s, int i)
        {
            Console.WriteLine($"Smth happened. Data: {s} {i}");
        }
    }
}
