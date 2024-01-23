using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Customer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int memberId;
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        private DateTime dob;
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private Order currentOrder;
        public Order CurrentOrder
        {
            get { return currentOrder; }
            set { currentOrder = value; }
        }

        private List<Order> orderHistory;
        public List<Order> OrderHistory
        {
            get { return orderHistory; }
            set { orderHistory = value; }
        }

        private PointCard rewards;
        public PointCard Rewards
        {
            get { return rewards; }
            set {  rewards = value; }
        }

        public Customer()
        {

        }

        public Customer(string n,int m,DateTime d)
        {
            Name = n;
            MemberId = m;
            Dob = d;
        }

        public Order MakeOrder()
        { 

        }


        public void IsBirthday(bool isBirthday)
        {
            IsBirthday = isBirthday;
        }

        public override string ToString()
        {
            // Implement ToString for Customer
            return $"Customer - Name: {Name}, Membership Status: {MembershipStatus}, Membership Points: {MembershipPoints}";
        }
    }
}
