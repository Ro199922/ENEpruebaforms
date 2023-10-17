using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ENE.model
{
    public class AFP
    {
        public string Name { get; set; }
        public float DiscountPercentage { get; set; }

        public AFP(string name, float discountPercentage)
        {
            Name = name;
            DiscountPercentage = discountPercentage;
        }
    }
}
