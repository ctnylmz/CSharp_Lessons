//using System;
//using System.Collections.Generic;

//namespace _4DayHomeWork
//{
//    internal class Program
//    {
//        //Generic
//        static void Main(string[] args)
//        {

//            List<string> citys1 = new List<String>();
//            citys1.Add("İstanbul");
//            citys1.Add("İstanbul");
//            citys1.Add("İstanbul");
//            Console.WriteLine(citys1.Count);


//            MyList<string> citys2 = new MyList<string>();
//            citys2.Add("İzmir");
//            citys2.Add("İzmir");
//            citys2.Add("İzmir");
//            Console.WriteLine(citys2.Count);
//        }

//    }
//    class MyList<T>
//    {
//        T[] _array;
//        T[] _tempArray;

//        public MyList()
//        {
//            _array = new T[0];
//        }
//        public void Add(T item)
//        {
//            _tempArray = _array;

//            _array = new T[_array.Length + 1];

//            for (int i = 0; i < _tempArray.Length; i++)
//            {
//                _array[i] = _tempArray[i];
//            }

//            _array[_array.Length - 1] = item;

//        }


//        public int Count
//        {
//            get { return _array.Length; }
//        }
//    }
//}
