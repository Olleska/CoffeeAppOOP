namespace RedTaskCoffeeOOP.Ingredient;

public class Juice : Ingredient
{
    public Juice(string taste, decimal weight) : base($"Сок {taste}", weight)
    {
        
    }
}