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
    }
}
