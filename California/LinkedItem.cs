using System.Collections;

namespace California
{
    public class LinkedItem<T>
    {
        private Item<T> _head;
        private Item<T> _tail;

        public void Add(T item)
        {
            Item<T> node = new Item<T>(item);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        //Implement IEnumerable
        public IEnumerator GetEnumerator()
        {
            return new LinkedEnumerator<T>(this._head);
        }
    }
}
