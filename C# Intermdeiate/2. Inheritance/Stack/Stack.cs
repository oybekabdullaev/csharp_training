using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly IList<object> _list;
        public int Size
        {
            get { return _list.Count; }
        }

        public Stack()
        {
            _list = new List<object>();
        }


        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Please, provide a valid object");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (Size < 1)
                throw new InvalidOperationException("Cannot pop from empty stack");

            var lastIndex = Size - 1;
            var topElement = _list[lastIndex];
            _list.RemoveAt(lastIndex);

            return topElement;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
