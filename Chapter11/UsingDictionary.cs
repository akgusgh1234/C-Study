using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    internal class UsingDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string>Dictionary=new Dictionary<string,string>();
            Dictionary["하나"] = "one";
            Dictionary["둘"]="two";
            Dictionary["셋"]="three";
            Dictionary["넷"]="four";
            Dictionary["다섯"] = "five";
            Console.WriteLine(Dictionary["하나"]);
            Console.WriteLine(Dictionary["둘"]);
            Console.WriteLine(Dictionary["셋"]);
            Console.WriteLine(Dictionary["넷"]);
            Console.WriteLine(Dictionary["다섯"]);
           
        }
    }
}
