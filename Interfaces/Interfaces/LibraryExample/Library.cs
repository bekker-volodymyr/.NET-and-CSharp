using System.Collections;

namespace Interfaces.LibraryExample
{
    internal class Library : System.Collections.IEnumerable
    {
        Book[] books =
        {
            new Book()
            {
                Title = "Маленький принц",
                Author = new Author()
                {
                   FirstName = "Антуан",
                   LastName = "Екзюпері"
                },
                Pages = 150
            },
            new Book()
            {
                Title = "Відьмак: Останнє бажання",
                Author = new Author()
                {
                   FirstName = "Анджей",
                   LastName = "Сапковскій"
                },
                Pages = 300
            },
            new Book()
            {
                Title = "Гарі Потер і в'язниця Азкобана",
                Author = new Author()
                {
                   FirstName = "Джоан",
                   LastName = "Роулінг"
                },
                Pages = 345
            }
        };

        public void Sort()
        {
            Array.Sort(books);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(books, comparer);
        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
