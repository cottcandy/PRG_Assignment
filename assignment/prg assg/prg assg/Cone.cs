using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Cone : IceCream
    {
        private bool dipped;
        public bool Dipped
        {
            get { return dipped; }
            set { dipped = value; }
        }

        public Cone()
        {

        }

        public Cone(string o, int s, List<Flavour> f, List<Topping> t, bool d) : base(o, s, f, t)
        {
            Dipped = d;
        }

        public override double CalculatePrice()
        {
           
        }
    }
}
