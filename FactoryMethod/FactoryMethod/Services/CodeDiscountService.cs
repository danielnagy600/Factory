using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Services
{
    public class CodeDiscountService : DiscoutService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage 
        {
            //Validate...
            get => 15;
        }
    }
}
