using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class PointCard
    {
        private int points;
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        private int punchCard;
        public int PunchCard
        {
            get { return punchCard; }
            set { punchCard = value; }
        }

        private string tier;
        public string Tier
        {
            get { return tier; }
            set { tier = value; }
        }
        

        public PointCard()
        {
            
        }

        public PointCard(int pt,int pc)
        {
            Points = pt;
            punchCard = pc;
        }

        public void AddPoints(int points)
        {
            Points += (int)Math.Floor(amountPaid * 0.72);
        }

        public void RedeemPoints(Customer customer, double amountToOffset)
        {
            
            if (customer.MembershipStatus == "Silver" || customer.MembershipStatus == "Gold")
            {
               
            }
        }

        public void Punch()
        {
            
            PunchCardCount++;
            if (PunchCardCount == 10)
            {
               
                PunchCardCount = 0;
               
                Points += 1;
            }
        }
    }
}
