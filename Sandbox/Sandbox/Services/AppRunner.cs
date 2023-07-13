using Sandbox.Models;
using Sandbox.Services;

public class AppRunner
{
    private AnimalFeeder _animalFeeder;
    
    public AppRunner(AnimalFeeder animalFeeder)
    {
        _animalFeeder = animalFeeder;
    }
    
    public void Do()
    {
        var animal1 = new Animal();
        var animal2 = new Animal();
        var animal3 = new Animal();
        
        _animalFeeder.Feed(animal1, FoodType.CatFood);
        _animalFeeder.Feed(animal2, FoodType.CatFood);
        _animalFeeder.Feed(animal1, FoodType.CatFood);

    }
}