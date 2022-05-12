using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyListEnumerator (T[] _list)
        {
            array = _list;
        }

        public T Current
        {
            get
            {
                try
                {
                    return array[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }

            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return(position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
