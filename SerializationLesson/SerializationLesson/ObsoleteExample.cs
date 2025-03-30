namespace SerializationLesson
{
    internal class ObsoleteExample
    {
        [Obsolete(message: "Цей метод застарілий і поганий. Використовуйте метод NewGoodMethod замість цього.")]
        public void OldBadMethod()
        {
            Console.WriteLine("Якийсь старий поганий метод.");
        }

        public void NewGoodMethod()
        {
            Console.WriteLine("Якийсь хороший новий метод.");
        }
    }
}
