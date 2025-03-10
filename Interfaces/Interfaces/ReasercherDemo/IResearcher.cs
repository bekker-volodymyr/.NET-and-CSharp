namespace Interfaces.ResearcherDemo
{
    internal interface IResearcher
    {
        string Subject { get; set; }
        void Investigate();
        void Invent();
    }
}
