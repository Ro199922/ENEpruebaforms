using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ENE.model
{
    public class Health
    {
        public string Name { get; set; }
        public float DiscountPercentage { get; set; }

        public Health(string name, float discountPercentage)
        {
            Name = name;
            DiscountPercentage = discountPercentage;
        }
    }
}
