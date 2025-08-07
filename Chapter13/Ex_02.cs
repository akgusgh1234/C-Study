using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    delegate void MyDelegate(int a);
    class Market
    {
        public event MyDelegate CustomerEvent;
        public void BuySometing(int CustomerNo)
        {
            if (CustomerNo == 30) { CustomerEvent(CustomerNo); }
        }
    }
    internal class Ex_02
    {
        static public void congu(int a) { Console.WriteLine("축하합니다 : " + a); }
        
            
            static void Main(string[] args)
            {
                Market market = new Market();
                market.CustomerEvent += new MyDelegate(congu);
                for (int custo = 0; custo < 100; custo++)
                {
                market.BuySometing(custo);
                }
                
            }
           
        
    }
}
