using System;
using System.Collections;

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

    public class LinkedItem<T>
    {
        private Item<T> _head;
        private Item<T> _tail;
        private Item<T> current;

        public void Add(T item)
        {
            Item<T> node = new Item<T>(item);

            if (_head == null)
            {
                _head = node;
                current = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }
        public void Reset() => current = _head;

        public IEnumerator GetEnumerator()
        {
            while (true)
                if (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }
                else
                {
                    Reset();
                    yield break;
                }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new LinkedItem<string>();
            collection.Add("first");
            collection.Add("second");
            collection.Add("third");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
