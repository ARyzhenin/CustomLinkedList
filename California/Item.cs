namespace California
{
    public class Item<T>
    {
        public Item(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public Item<T> Next { get; set; }
    }
}
