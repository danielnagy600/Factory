using FactoryMethod.Services;

namespace FactoryMethod.Factorys
{
    public abstract class DiscountFactory
    {
        public abstract DiscoutService CreateDiscountService();
    }
}
