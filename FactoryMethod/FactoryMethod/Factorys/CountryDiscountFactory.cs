using FactoryMethod.Services;

namespace FactoryMethod.Factorys
{
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;

        public CountryDiscountFactory(string countyIdentifier)
        {
            _countryIdentifier = countyIdentifier;
        }
        public override DiscoutService CreateDiscountService()
        {
            return new CountyDiscountService(_countryIdentifier);
        }
    }
}
