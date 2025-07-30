using System;
using System.Data;
/*
namespace Chapter9
{
    class BirtdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
        }
    }
    internal class PropertyBase
    {
        static void Main(string[] args)
        {
            BirtdayInfo birth = new BirtdayInfo();
            birth.Name = "표선";
            birth.Birthday = new DateTime(1999, 6, 28);
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
*/