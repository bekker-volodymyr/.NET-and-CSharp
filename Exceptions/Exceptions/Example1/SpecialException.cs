namespace Exceptions.Example1
{
    [Serializable]
    public class SpecialException : ApplicationException
    {
        public DateTime Time { get; private set; }
        public SpecialException()
        {
            Time = DateTime.Now;
        }
        public SpecialException(string message) : base(message) { }
        public SpecialException(string message, Exception inner) : base(message, inner) { }
        protected SpecialException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}