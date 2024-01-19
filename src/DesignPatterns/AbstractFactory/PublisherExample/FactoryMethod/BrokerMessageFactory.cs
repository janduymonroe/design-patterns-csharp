using DesignPatterns.AbstractFactory.PublisherExample.ConcreteClass;

namespace DesignPatterns.AbstractFactory.PublisherExample.FactoryMethod;

public class BrokerMessageFactory : MessageFactory
{
    public override MessagePublisher GetPublisher()
    {
        return new BrokerPublisher();
    }
}
