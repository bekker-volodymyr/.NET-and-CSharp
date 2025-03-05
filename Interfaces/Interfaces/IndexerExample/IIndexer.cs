namespace Interfaces.IndexerExample
{
    internal interface IIndexer
    {
        string this[int index]
        {
            get;
            set;
        }
        string this[string index]
        {
            get;
        }
    }
}
