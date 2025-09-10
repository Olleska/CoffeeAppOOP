namespace RedTaskCoffeeOOP;

public interface IElement
{
    string Describe();
    
    void Execute();
    
    List<string> GetDescriptionsSteps();
}