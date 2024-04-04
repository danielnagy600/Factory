using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Services
{
    public abstract class DiscoutService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString()=>GetType().Name;
    }
}
