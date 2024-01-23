using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Waffle : IceCream
    {
        private string waffleFlavour;
        public string WaffleFlavour
        {
            get { return waffleFlavour; } 
            set { waffleFlavour = value; } 
        }

        public Waffle()
        {
            
        }

        public Waffle(string o, int s, List<Flavour> f, List<Topping> t, string w) : base(o, s, f, t)
        {
            waffleFlavour  = w;
        }

        public override double CalculatePrice()
        {
            double TotalPrice = 0;
            return TotalPrice;
        }
    }
}
