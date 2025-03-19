namespace Collections.GenericRestrictions
{
    /*
     * Repository<T> підходить лише для класів із конструктором без параметрів.
     * Забезпечує контроль над типами ще на етапі компіляції.
     * Використовується, наприклад, для шаблонних сховищ (репозиторіїв) у патерні "Repository".
     */
    public class Repository<T> where T : class, new()
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T CreateAndAdd()
        {
            T newItem = new T(); // можна створювати об'єкти T
            _items.Add(newItem);
            return newItem;
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }
}
