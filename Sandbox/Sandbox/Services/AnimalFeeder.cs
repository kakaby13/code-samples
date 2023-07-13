using Sandbox.Models;

namespace Sandbox.Services;

public class AnimalFeeder
{
    IFoodProvider _foodProvider;

    public AnimalFeeder(IFoodProvider foodProvider)
    {
        _foodProvider = foodProvider;
    }
    
    public void Feed(Animal animal, FoodType foodType)
    {
        animal.Satiety += _foodProvider.GetFood().Satiety;
        Console.WriteLine("animal feeded");

    }
    
    public void FeedManyAnimals(List<Animal> animals, FoodType foodType)
    {
        animals.ForEach(c => c.Satiety += _foodProvider.GetFood().Satiety);
    }
}