using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor? OrderProcessor { get; set; }

        public void AssignOrderProcessor(string orderType)
        {
            if (orderType == "online")
                OrderProcessor = new OnlineOrderProcessor();
            else if (orderType == "instore")
                OrderProcessor = new InStoreOrderProcessor();
            else
                throw new Exception("Invalid order type");
            
        }

        public decimal GetFinalOrderAmount()
        {
            return OrderAmount - OrderProcessor!.CalculateDiscount(OrderAmount);
        }

        public void ProcessOrder()
        {
            OrderProcessor!.ProcessOrder();
        }
    }
}
