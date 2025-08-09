using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter15
{
    class Class
    {
        public string Name {  get; set; }
        public int[]Score { get; set; }
    }
    internal class FromFrom
    {
        static void Main(string[] args)
        {
            Class[] artclass =
            {
                new Class(){Name="A",Score=new int[]{99,80,70,24} },
                new Class(){Name="B",Score=new int[]{60,45,87,72} },
                new Class(){Name="C",Score=new int[]{92,30,85,94 } },
                new Class(){Name="D",Score=new int[]{90,88,0,17} }
            };

            var classes = from c in artclass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach (var c in classes) { Console.WriteLine($"{c.Name} {c.Lowest}"); }
        }
    }
}
*/