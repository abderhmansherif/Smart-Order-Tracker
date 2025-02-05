using System;


namespace OrderProcessing
{
    public class Order
    {
        private IOrderStates _states;

        public Order(){
            _states = new WaitingState();
        } 

        public void SetState (IOrderStates states)
        {
            _states = states;
        }

        public void Process()
        {
            _states.ProcessOrder(this);
        }

        public void Cancel()
        {
            _states.CancelOrder(this);
        }
    }
}