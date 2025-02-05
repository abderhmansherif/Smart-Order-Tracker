using System;


namespace OrderProcessing
{
    public class WaitingState : IOrderStates
    {
        public void CancelOrder(Order order)
        {
            System.Console.WriteLine("Order is Canceld");
            order.SetState(new CancelledState());
        }

        public void ProcessOrder(Order order)
        {
            System.Console.WriteLine("The Order in Processing...");
            order.SetState(new PreparingState());
            System.Console.WriteLine("The Order in Preparing State");
        }
    }
}