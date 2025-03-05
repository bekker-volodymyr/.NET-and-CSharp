namespace Inheritence.VirtualMethods
{
    class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("BaseClass Show");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("DerivedClass Show");
        }
    }
}