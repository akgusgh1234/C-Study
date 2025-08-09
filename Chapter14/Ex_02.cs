using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    internal class Ex_02
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };
            int result = 0;
            foreach(int i in array)
            {
                Action<int> act = (x) => result = (x * x);
                act(i);
                Console.WriteLine(result);
            }
        }
    }
}
