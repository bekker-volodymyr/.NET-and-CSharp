namespace Interfaces.InterfaceInheritenceExample
{
    interface IA
    {
        string A1(int n);
    }

    interface IB
    {
        int B1(int n);
        void B2();
    }

    interface IC : IA, IB
    {
        void C1(int n);
    }

    class InherInterface : IC
    {
        public string A1(int n)
        {
            throw new NotImplementedException();
        }
        public int B1(int n)
        {
            throw new NotImplementedException();
        }
        public void B2()
        {
            throw new NotImplementedException();
        }
        public void C1(int n)
        {
            throw new NotImplementedException();
        }
    }
}