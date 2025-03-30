namespace Serialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        int _id;

        [NonSerialized]
        const string Planet = "Earth";

        public Person() { }

        public Person(int number)
        {
            _id = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Identification number: {_id}, Planet: {Planet}.";
        }
    }
}
