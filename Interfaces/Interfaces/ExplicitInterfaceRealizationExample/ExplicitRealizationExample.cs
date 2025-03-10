namespace Interfaces.ExplicitRealizationExample
{
    interface IA
    {
        void Show();
    }

    interface IB
    {
        void Show();
    }

    interface IC
    {
        void Show();
    }

    class ExplicitRealization : IA, IB, IC
    {
        void IA.Show()
        {
            Console.WriteLine("Interface IA");
        }
        void IB.Show()
        {
            Console.WriteLine("Interface IB");
        }
        void IC.Show()
        {
            Console.WriteLine("Interface IC");
        }
    }
}