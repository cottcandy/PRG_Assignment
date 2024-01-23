using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Cup : IceCream
    {
        // Constructors
        public Cup()
        {
            
        }

        public Cup(string o, int s, List<Flavour> f, List<Topping> t) : base(o, s, f, t)
        {
           
        }

        // Methods
        public override double CalculatePrice()
        {
            double TotalPrice = 0;
            return TotalPrice;
        }

        public override string ToString()
        {
            
            return $"Cup Option: {Option}, Scoops: {Scoops}, Flavours: {string.Join(", ", Flavours)}, Toppings: {string.Join(", ", Toppings)}";
        }
    }
}
