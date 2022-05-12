using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class MyList<T> : IList<T> where T : IComparable<T>     
    {
        private T[] _list = new T[1];
        public int Count { get; private set; }
        public int Capacity => _list.Length;
        public T this[int index]
        {
            get { return _list[index]; }
            set => _list[index] = value;
        }
        private void TryToIncreaseInternalArray()
        {
            if (Count == Capacity)
            {
                T[] tmp = new T[Capacity * 2];
                _list.CopyTo(tmp, 0);
                _list = tmp;
            }
        }
        public bool IsReadOnly { get; }
        public void Add(T elem)
        {
            TryToIncreaseInternalArray();
            _list[Count] = elem;
            Count++;
        }
        public void Clear()
        {
            _list = new T[1];
            Count = 0;
        }
        public bool Contains(T item)
        {
            return _list.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            int tmp = 0;
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = _list[tmp];
                tmp++;
            }
        }
        public int IndexOf(T item) 
        {
            for (int i = 0; i < Count; i++)
            {
                if (_list[i].CompareTo(item) == 0) return i;
            }
            return -1;
        }
        public void Insert(int index, T item)
        {
            if (index < Count && index >= 0)
            {
                Count++;
                TryToIncreaseInternalArray();
                for (int i = Count-1; i > index; i--)
                {
                    _list[i] = _list[i-1];
                }
                _list[index] = item;
            }
            else throw new IndexOutOfRangeException("Неверный индекс нового элемента");
        }
        public void PrintListToConsole()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++) 
            { 
                result = String.Concat(result, _list[i].ToString(), ", ");
            }
            result = result.TrimEnd(new char[] {' ', ','});
            return result;
        }

        public bool Remove(T item)
        {
            if(_list.Contains(item))
            {
                for (int i = Array.IndexOf(_list, item); i < Count; i++)
                {
                    _list[i] = _list[i + 1];
                }
                Count--;
                return true;
            };
            return false;
        }
        public void RemoveAt(int index)
        {
            if (index < Count && index >= 0)
            {
                for (int i = index; i < Count; i++)
                {
                    _list[i] = _list[i + 1];
                }
                Count--;
            }
            else throw new IndexOutOfRangeException("Неверный индекс");
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _list[i];
            }
        }
        public MyList ()
        {
            _list = new T[1];
            Count = 0;
        }
        public MyList (int count)
        {
            _list = new T[count];
            Count = 0;
        }
    }
}