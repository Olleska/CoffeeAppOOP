namespace RedTaskCoffeeOOP.Ingredient;

public class CoffeeBeans : Ingredient
{
    public CoffeeBeans(string sort, decimal weight) : base($"Кофе сорта {sort}", weight)
    {
        
    }
}