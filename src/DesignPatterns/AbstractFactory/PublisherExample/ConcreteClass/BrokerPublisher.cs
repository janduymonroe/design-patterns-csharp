namespace DesignPatterns.AbstractFactory.PublisherExample.ConcreteClass;


//This is a concrete class
public class BrokerPublisher : MessagePublisher
{
    public override string ProviderName => "BusMessage";
    
    public override async Task PublishMessage(string message)
    {
        await Task.Run(() =>
        {
            //SendMessageToBUS;
        });
    }
}