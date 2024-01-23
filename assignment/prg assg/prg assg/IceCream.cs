using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal abstract class IceCream
    {
        // Properties
        private string option;
        public string Option
        {
            get { return option; }
            set { option = value; }
        }
        private int scopps;
        public int Scoops
        {
            get { return scopps; }
            set { Scoops = value; }
        }

        private List<Flavour> flavours;
        public List<Flavour> Flavours
        {
            get { return flavours; }
            set { flavours = value; }
        }

        private List<Topping> toppings;
        public List<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        // Constructors
        public IceCream()
        {
            
        }

        public IceCream(string o, int s, List<Flavour> f, List<Topping> t)
        {
            Option = o;
            Scoops = s;
            Flavours = f;
            Toppings = t;
        }

        // Methods
        public abstract double CalculatePrice();
        

        public override string ToString()
        {
            return $"Option: {Option}, Scoops: {Scoops}, Flavours: {string.Join(", ", Flavours)}, Toppings: {string.Join(", ", Toppings)}";
        }
    }
}
