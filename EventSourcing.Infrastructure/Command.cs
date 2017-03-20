namespace EventSourcing.Infrastructure
{
    public class Command : Message
    {
        public string Name { get; protected set; }
    }
}