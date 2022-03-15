using System.Collections;

namespace California
{
    class LinkedEnumerator<T> : IEnumerator
    {
        private Item<T> _head;
        private Item<T> _position;

        public LinkedEnumerator(Item<T> head)
        {
            _head = head;
        }

        //Implement IEnumerator
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
    }

}
