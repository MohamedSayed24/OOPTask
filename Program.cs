namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine()!;

            Console.WriteLine("Enter Order Amount:");
            decimal orderAmount = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Order Type (Online or In-Store):");
            string orderType = Console.ReadLine()!;

            Order order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderAmount = orderAmount
            };

            order.AssignOrderProcessor(orderType);

            decimal finalAmount= order.GetFinalOrderAmount();

            Console.WriteLine($"Order {order.OrderId} processed for {order.CustomerName}. Final amount after {orderType} discount: ${finalAmount}");
        }
    }
}
