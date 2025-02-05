using System;


namespace OrderProcessing
{
    public class PreparingState : IOrderStates
    {
        public void CancelOrder(Order order)
        {
            System.Console.WriteLine("The Order is cancelled");
            order.SetState(new CancelledState());
        }

        public void ProcessOrder(Order order)
        {
            System.Console.WriteLine("The Order in Processing...");
           order.SetState(new ReadyForDeliveryState());
           System.Console.WriteLine("The Order in Ready For Delivery State");
        }
    }
}