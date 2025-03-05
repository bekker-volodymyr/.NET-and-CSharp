namespace Exceptions.NameofExample
{
    public class ExampleNameOf
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public ExampleNameOf(string name, string id)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Name = name;
        }
    }
}
