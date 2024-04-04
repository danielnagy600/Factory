using FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factorys
{
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid guid)
        {
            _code = guid;
        }
        public override DiscoutService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}