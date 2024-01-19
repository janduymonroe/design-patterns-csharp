namespace DesignPatterns.AbstractFactory.PublisherExample;

//This is a abstract factory class
public abstract class MessagePublisher
{
    public abstract string ProviderName { get; }
    public abstract Task PublishMessage(string message);
}