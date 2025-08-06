using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter11
{
    class Mylist<T>
    {
        private T[] array;
        public Mylist() { array = new T[3]; }
        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index+1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length {  get { return array.Length; } }
    }
    internal class Generic
    {
        static void Main(string[] args)
        {
            Mylist<string> list = new Mylist<string>();
            list[0] = "abc";
            list[1] = "def";
            list[2] = "ghi";
            list[3] = "jkl";
            list[4] = "mno";
            for(int i=0; i<list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            Mylist<int> list2 = new Mylist<int>();
            list2[0] = 1;
            list2[1] = 2;
            list2[2] = 3;
            list2[3] = 4;
            list2[4] = 5;
            for(int i=0; i < list2.Length; i++) { Console.WriteLine(list2[i]); }
        }
    }
}
*/