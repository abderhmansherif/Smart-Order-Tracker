using System;


namespace OrderProcessing
{
    public class DeliveredState : IOrderStates
    {
        public void CancelOrder(Order order)
        {
            System.Console.WriteLine("Can not cancel The Order Is Delivred");
        }

        public void ProcessOrder(Order order)
        {
            System.Console.WriteLine("The Order is Delivered");
        }
    }
}