namespace ClassExample
{
    internal class Student
    {
        // спеціфікатор доступу за замовчуванням - private
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;

        // конструктор з параметрами
        public Student(int id, string firstName, string lastName, string email)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }

        public void Print() // метод класу
        {
            Console.WriteLine($"{_id}. {_firstName} {_lastName}: {_email}");
        }
    }
}
