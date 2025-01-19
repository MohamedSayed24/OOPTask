using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    public class OnlineOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.10m;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processing online order");
        }
    }

    public class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.05m;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processing in store-order");
        }
    }
}
