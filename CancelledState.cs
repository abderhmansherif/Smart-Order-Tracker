using System;


namespace OrderProcessing
{
    public class CancelledState : IOrderStates
    {
        public void CancelOrder(Order order)
        {
            System.Console.WriteLine("The Order is already cancelled");
        }

        public void ProcessOrder(Order order)
        {
            System.Console.WriteLine("The Order is cancelled and cannot be Processed");
        }
    }
}