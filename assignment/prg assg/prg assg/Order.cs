using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Order
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime timeReceived;
        public DateTime TimeReceived
        {
            get { return timeReceived; }
            set { timeReceived = value; }
        }

        private DateTime? timeFufilled;
        public DateTime? TimeFulfilled
        {
            get { return timeFufilled; }
            set { timeFufilled = value; }
        }

        private List<IceCream> iceCreamList;
        public List<IceCream> IceCreamList
        {
            get { return iceCreamList; }
            set {  iceCreamList = value; }
        }

        public Order()
        {

        }

        public Order(int id, DateTime tr)
        {
            Id = id;
            TimeReceived = tr;
            IceCreamList = new List<IceCream>();
        }

        public void ModifyIceCream()
        {
            if (index >= 0 && index < IceCreamList.Count)
            {
                IceCreamList[index] = iceCream;
            }
        }

        public void AddIceCream(IceCream iceCream)
        {
            IceCreamList.Add(iceCream);
        }

        public void DeleteIceCream(int index)
        {
            if (IceCreamList.Count > 1)
            {
                IceCreamList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Cannot have zero ice creams in an order.");
            }
        }

        public double CalculateTotal()
        {
           
        }

        public override string ToString()
        {
            return $"Order ID: {Id}, Time Received: {TimeReceived}, Time Fulfilled: {TimeFulfilled}, Total: {CalculateTotal()}";
        }
    }
}
