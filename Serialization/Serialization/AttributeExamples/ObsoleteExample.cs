namespace Serialization.AttributeExamples
{
    internal class ObsoleteExample
    {
        [Obsolete(message: "Використовуй новий метод, він краще!")]
        public void OldMethod()
        {
            Console.WriteLine("Якийсь застарілий метод");
        }

        public void NewMethod() { Console.WriteLine("Новий, набагато кращий метод"); }
    }
}
