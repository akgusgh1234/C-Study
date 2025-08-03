using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter9
{
    class BirthdayInfo
    {
        public required string Name {  get; set; }
        public required DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class RequiredProperty
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth=new BirthdayInfo() { Name = "표선", Birthday = new DateTime(2002,6,28) };
            Console.WriteLine("Name : {0}",birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}",birth.Age);
        }
    }
}
*/