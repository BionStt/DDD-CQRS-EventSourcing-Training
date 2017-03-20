namespace Deluxe.Server
{
    public class BusConfig
    {
        public static void Initialize()
        {
            BookingApplication.Bus = new InMemoryBus(new SqlEventStore());

            BookingApplication.Bus.RegisterSaga<BookingSaga>();
            BookingApplication.Bus.RegisterHandler<BookingRejectedHandler>();
            BookingApplication.Bus.RegisterHandler<EmailHandler>();
        }
    }
}