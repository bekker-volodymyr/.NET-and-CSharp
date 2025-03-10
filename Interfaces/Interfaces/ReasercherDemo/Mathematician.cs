namespace Interfaces.ResearcherDemo
{
    internal class Mathematician : IResearcher
    {
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public void Invent()
        {
            Console.WriteLine("Винайшли уявне число i");
        }

        public void Investigate()
        {
            Console.WriteLine("Досліджуємо квадратичні рівняння...");
        }
    }
}
