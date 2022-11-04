using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // MyList

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Sakarya");
            sehirler2.Add("Aksaray");
            sehirler2.Add("Tekirdağ");
            sehirler2.Add("İzmir");
            sehirler2.Add("Çanakkale");
            sehirler2.Add("Samsun");

            Console.WriteLine(sehirler2.Count);

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray; 

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
