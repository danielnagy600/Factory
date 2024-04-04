//Purpose :loose coupling
//New types of products can be added without breaking clients code (open/closed/principle)
//Creating products ins moved to one specific place in your code: Creator

//Old solution
// var codeDiscoutService = new CodeDiscoutService(Guid.NewGuid());
// var codeDiscoutService = new CodeDiscoutService("HUN");

using FactoryMethod.Factorys;

//New
//DiscountFactory Abstract
var factories = new List<DiscountFactory> { new CodeDiscountFactory(Guid.NewGuid()), new CountryDiscountFactory("HUN") };

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Name: {discountService} Percentage {discountService.DiscountPercentage}");
}

Console.ReadLine();