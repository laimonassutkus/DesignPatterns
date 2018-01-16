using System.Collections.Generic;

namespace Iterator
{
    class ListIterator<T> : IIterator<T>
    {
        private List<T> elements = new List<T>();
        private int index = 0;

        public void Add(T element)
        {
            elements.Add(element);
        }

        public T Current()
        {
            if (elements.Count == 0)
                return default(T);

            return elements[index];
        }

        public bool HasNext()
        {
            return index < elements.Count;
        }

        public void Next()
        {
            index++;
        }
    }
}
