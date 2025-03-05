namespace Inheritence
{
    public class Human
    {
        internal protected int _id;
        protected string firstName;
        protected string lastName;

        public Human(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Прізвище: {lastName}\nІм'я: {firstName}");
        }
    }
}
