using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter14
{
    class FriendsList
    {
        private List<string> list=new List<string>();
        public void Add(string name)=>list.Add(name);
        public void remove(string name)=>list.Remove(name);
        public void PrintAll()
        {
            foreach(var item in list)
                Console.WriteLine(item);
        }
        public FriendsList() => Console.WriteLine("FriendList()");
        ~FriendsList() => Console.WriteLine("~FriendList()");
        public int Capacity
        {
            get=>list.Capacity;
            set => list.Capacity = value;
        }
        public string this[int index]
        {
            get=>list[index];
            set => list[index] = value;
        }
        
    }
    internal class ExpressionBodiedMember
    {
        static void Main(string[] args)
        {
            FriendsList obj= new FriendsList();
            obj.Add("표선");
            obj.Add("태허");
            obj.Add("규도");
            obj.Add("종규");
            obj.remove("종규");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");
            Console.WriteLine($"{obj[0]}");
            obj[0] = "종규";
            obj.PrintAll();
        }
    }
}
*/