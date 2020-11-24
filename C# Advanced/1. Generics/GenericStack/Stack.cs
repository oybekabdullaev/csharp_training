using System;
using System.Collections.Generic;

namespace GenericStack
{
    public class Stack<T>
    {
        private readonly IList<T> _list;
        public int Size
        {
            get
            {
                return _list.Count;
            }
        }

        public Stack()
        {
            _list = new List<T>();
        }

        public void Push(T element)
        {
            if (element == null)
                throw new InvalidOperationException("Please, provide a valid element");

            _list.Add(element);
        }

        public T Pop()
        {
            if (Size < 1)
                throw new InvalidOperationException("Cannot pop from empty stack");

            var lastIndex = Size - 1;
            var lastElement = _list[lastIndex];
            _list.RemoveAt(lastIndex);

            return lastElement;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
