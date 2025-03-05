namespace Interfaces.ShopExample
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"\nПрізвище: {LastName} Ім'я: {FirstName} Дата народження: {BirthDate.ToLongDateString()}";
        }
    }
}
