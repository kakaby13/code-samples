using Sandbox.Models;

namespace Sandbox.Services;

public class AnotherFoodProvider : IFoodProvider
{
    public Food GetFood()
    {
        Console.WriteLine("another food provided");

        return new Food
        {
            Satiety = 42
        };
    }
}