namespace ClassExample
{
    internal class CtorsExampleClass
    {
        private int _field;
        private static int _staticField;
        public CtorsExampleClass(int value) // конструктор з параметрами
        {
            _field = value;
        }
        static CtorsExampleClass() // статичний конструктор
        {
            _staticField = 0;
        }
    }
}
