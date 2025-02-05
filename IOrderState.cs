using System;


namespace OrderProcessing
{
    public interface IOrderStates
    {
        void ProcessOrder(Order order);

        void CancelOrder(Order order);
    }
}