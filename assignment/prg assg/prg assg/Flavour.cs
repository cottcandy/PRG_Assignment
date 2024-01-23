using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Flavour
    {
        private string type;
        public string Type
        { 
            get { return type; }
            set { type = value; }
        }

        private bool premium;
        public bool Premium
        {
            get { return premium; }
            set { premium = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity;}
            set { quantity = value; }
        }

        // Constructors
        public Flavour()
        {

        }
        public Flavour(string t, bool p, int q)
        {
            Type = t;
            Premium = p;
            Quantity = q;
        }

        // Method
        public string ToString()
        {
            return $"Flavour: {Type}, Premium: {Premium}, Quantity: {Quantity}";
        }
    }
}
