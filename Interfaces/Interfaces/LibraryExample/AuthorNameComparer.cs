using System.Collections;

namespace Interfaces.LibraryExample
{
    internal class AuthorNameComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Book left && y is Book right)
            {
                return string.Compare(left.Author.FirstName, right.Author.FirstName);
            }
            throw new NotSupportedException("Using of unsupported type");
        }
    }
}
