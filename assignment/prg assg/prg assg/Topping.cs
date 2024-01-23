using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg_assg
{
    internal class Topping
    {
        // Attribute

        private string type;
        public string Type { get; set; }

        // Constructors
        public Topping()
        {

        }
        public Topping(string ty)
        {
            Type = ty;
        }

        // Method
        public string ToString()
        {
            return $"Topping: {Type}";
        }
    }
}
