namespace FactoryMethod.Services
{
    public class CountyDiscountService : DiscoutService
    {
        private readonly string _countryIdentifier;

        public CountyDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }
        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "HUN":
                        return 50;
                    default:
                        return 20;
                }
            }
        }
    }
}
