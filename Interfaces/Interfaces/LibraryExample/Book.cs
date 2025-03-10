namespace Interfaces.LibraryExample
{
    internal class Book : System.IComparable
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Pages { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is Book other)
            {
                return Title.CompareTo(other.Title);
            }
            throw new NotSupportedException("Using of unsupported type");
        }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPages: {Pages}";
        }
    }
}
