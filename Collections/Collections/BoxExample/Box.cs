namespace Collections.BoxExample
{
    public class Box<T>
    {
        private T _value;
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public Box(T value)
        {
            _value = value;
        }
        public T Method(T value)
        {
            return _value;
        }
    }
}
