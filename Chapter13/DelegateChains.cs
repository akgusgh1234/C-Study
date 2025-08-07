using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Chapter13
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify Eventoccuerd;
    }

    class EventListener 
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }

    
    internal class DelegateChains
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("listener1");
            EventListener listener2 = new EventListener("listener2");
            EventListener listener3 = new EventListener("listener3");
            notifier.Eventoccuerd += listener1.SomethingHappend;
            notifier.Eventoccuerd += listener2.SomethingHappend;
            notifier.Eventoccuerd += listener3.SomethingHappend;
            notifier.Eventoccuerd("You have got mail");
        }
    }
}
*/