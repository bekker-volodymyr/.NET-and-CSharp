namespace Collections.HW
{
    public class CircularBuffer<T>
    {
        private T[] _buffer;
        private int _head;
        private int _tail;
        private bool _isFull;

        public bool IsFull => _isFull;
        public bool IsEmpty => !_isFull && _head == _tail;

        public int Capacity => _buffer.Length;

        public int Count
        {
            get
            {
                if (_isFull) return Capacity;
                if (_tail >= _head) return _tail - _head;
                return Capacity - _head + _tail;
            }
        }

        public CircularBuffer(int capacity)
        {
            if (capacity <= 0) throw new ArgumentException("Capacity must be greater than zero.");
            _buffer = new T[capacity];
            _head = 0;
            _tail = 0;
            _isFull = false;
        }

        public void Enqueue(T item)
        {
            _buffer[_tail] = item;
            if (_isFull)
            {
                _head = (_head + 1) % _buffer.Length; // затираємо найстаріший елемент
            }

            _tail = (_tail + 1) % _buffer.Length;
            _isFull = _tail == _head;
        }

        public T Dequeue()
        {
            if (IsEmpty) throw new InvalidOperationException("Buffer is empty.");

            var item = _buffer[_head];
            _head = (_head + 1) % _buffer.Length;
            _isFull = false;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Buffer is empty.");
            return _buffer[_head];
        }
    }
}
