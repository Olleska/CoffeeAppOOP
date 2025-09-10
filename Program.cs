using RedTaskCoffeeOOP;
using RedTaskCoffeeOOP.Action;
using RedTaskCoffeeOOP.Ingredient;

class Program
{
    static void Main(string[] args)
    {
        var repo = new DrinkRepo();
        var service = new DrinkService(repo);
        var controller = new DrinkController(service);
        controller.Run();
    }
}