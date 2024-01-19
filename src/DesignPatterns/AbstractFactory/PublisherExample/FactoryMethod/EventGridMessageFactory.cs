using DesignPatterns.AbstractFactory.PublisherExample.ConcreteClass;

namespace DesignPatterns.AbstractFactory.PublisherExample.FactoryMethod;

public class EventGridMessageFactory : MessageFactory
{
    public override MessagePublisher GetPublisher()
    {
        return new EventGridPublisher();
    }
}