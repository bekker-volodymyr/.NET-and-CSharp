namespace Collections.IteratorExample
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Прізвище: {LastName}, Ім'я: {FirstName}, Народився: {BirthDate.ToLongDateString()}";
        }
    }

    public class Auditory
    {
        List<Student> _auditory = new List<Student> {
                new Student {
                    FirstName ="John",
                    LastName ="Miller",
                    BirthDate =new DateTime(1997,3,12)
                },
                new Student {
                    FirstName ="Candice",
                    LastName ="Leman",
                    BirthDate =new DateTime(1998,7,22)
                },
                new Student {
                    FirstName ="Joey",
                    LastName ="Finch",
                    BirthDate =new DateTime(1996,11,30)
                },
                new Student {
                    FirstName ="Nicole",
                    LastName ="Taylor",
                    BirthDate =new DateTime(1996,5,10)
                }
            };

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < _auditory.Count; i++)
            {
                yield return _auditory[i];
            }
        }
    }
}
