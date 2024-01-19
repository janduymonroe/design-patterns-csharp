namespace DesignPatterns.AbstractFactory.PublisherExample;

//This is a factory method class
public abstract class MessageFactory
{
    public abstract MessagePublisher GetPublisher();
}