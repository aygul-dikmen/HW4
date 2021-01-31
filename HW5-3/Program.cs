using System;
using System.Collections.Generic;

namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            MyList<string> sehirler2=new MyList<string>();
            Console.WriteLine( sehirler2.Count) ;
            //sehirler2.Add("Ankara");
        }
    }
    class MyList<T> //Listelerde string ve ya int gibi tek bir değişken yerine gerekli yerde istenilen değişken kullanılabilir.
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            T[] _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        //propfull + tab
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
