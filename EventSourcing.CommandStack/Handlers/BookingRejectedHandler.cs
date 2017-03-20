using EventSourcing.CommandStack.Events;

namespace EventSourcing.CommandStack.Handlers
{
    public class BookingRejectedHandler : Handler,
        IHandleMessage<BookingRequestRejectedEvent>
    {
        public BookingRejectedHandler(IEventStore eventStore) 
            : base(eventStore)
        {
        }

        public void Handle(BookingRequestRejectedEvent message)
        {
            throw new System.NotImplementedException();
        }
    }
}