namespace Interfaces.ShopExample
{
    public interface IWorker
    {
        bool IsWorking { get; }
        string Work();
    }
}
