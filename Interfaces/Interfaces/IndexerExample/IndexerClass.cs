namespace Interfaces.IndexerExample
{
    enum Numbers { one, two, three, four, five };

    internal class IndexerClass
    {
        string[] _names = new string[5];
        public string this[int index]
        {
            get
            {
                return _names[index];
            }
            set
            {
                _names[index] = value;
            }
        }
        public string this[string index]
        {
            get
            {
                if (Enum.IsDefined(typeof(Numbers), index))
                    return _names[(int)Enum.Parse(typeof(Numbers), index)];
                else
                    return "";
            }
        }
        public IndexerClass()
        {
            // запис значень, використовуючи індексатор з цілочисельним параметром
            this[0] = "Bob";
            this[1] = "Candice";
            this[2] = "Jimmy";
            this[3] = "Joey";
            this[4] = "Nicole";
        }
    }
}
