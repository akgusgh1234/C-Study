using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_데이터_보관_
{
    internal class Exercise
    {
        static void Main(string[] args)
        {
            Console.Write("사각형의 너비를 입력하세요: ");
            string width = Console.ReadLine();
            Console.Write("사각형의 높이를 입력하세요: ");
            string height = Console.ReadLine();
            double w=double.Parse(width);
            double h=double.Parse(height);
            double area = w * h;
            Console.Write("사격형의 넓이는 : {0}", area);
        }
    }
}
