using Sandbox.Models;

namespace Sandbox.Services;

public class FoodProvider : IFoodProvider
{
    public Food GetFood()
    {
        Console.WriteLine("food provided");

        return new Food
        {
            Satiety = 42
        };
    }
}