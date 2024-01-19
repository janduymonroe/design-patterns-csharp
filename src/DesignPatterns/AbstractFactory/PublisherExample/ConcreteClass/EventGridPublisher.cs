namespace DesignPatterns.AbstractFactory.PublisherExample.ConcreteClass;

//This is a concrete class
public class EventGridPublisher : MessagePublisher
{
    public override string ProviderName => "EventGrid";

    public override async Task PublishMessage(string message)
    {
        await Task.Run(() =>
        {
            //SendMessageToEventGrid;
        });
    }
}
