using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_7_1
{
    public class MoverCollection<T> : IList<T> where T : Mover
    {
        private List<Mover> _innerList = new List<Mover>();

        public T this[int index]
        {
            get => (T)_innerList[index];
            set => _innerList[index] = value;
        }


        public int Count => _innerList.Count();

        public bool IsReadOnly => false;

        public void Add(T item)
        {

            _innerList.Add(item);
        }




        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var enumerator = _innerList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return (T)enumerator.Current;
            }
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => _innerList.GetEnumerator();
        
    }
}
