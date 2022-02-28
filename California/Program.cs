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

    public class LinkedItem<T> : IEnumerable, IEnumerator
    {
        private Item<T> _head;
        private Item<T> _tail;
        private Item<T> _position;

        public void Add(T item)
        {
            Item<T> node = new Item<T>(item);

            if (_head == null)
            {
                _head = node;
                //_position = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        //Реализация IEnumerator
        public bool MoveNext()
        {
            if (_position == null)
            {
                _position = _head;
                return true;
            }
            if (_position.Next != null)
            {
                _position = _position.Next;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            _position = null;
        }

        public object Current
        {
            get
            {
                return _position.Value;
            }
        }

        //Реализация IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
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
            collection.Add("fourth");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
