namespace Inheritence.SealedExample
{
    public class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1 of BaseClass");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("VirtualMethod of BaseClass");
        }
    }

    public sealed class SealedClass : BaseClass
    {

    }

    // public class SealedChild : SealedClass { } // error

    public class ChildClass : BaseClass
    {
        public sealed override void VirtualMethod()
        {
            base.VirtualMethod();
        }
    }

    public class GrandChildClass : ChildClass
    {
        // public override void VirtualMethod() { } // error
    }
}