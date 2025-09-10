namespace RedTaskCoffeeOOP.Ingredient;

public class Syrop: Ingredient
{
    public Syrop(string type, decimal weight) : base($"Сироп {type}", weight)
    {
        
    }
}