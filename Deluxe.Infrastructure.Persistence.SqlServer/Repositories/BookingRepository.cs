using System;
using Deluxe.CommandStack.Domain.Common;
using Deluxe.CommandStack.Domain.Model;
using Deluxe.Infrastructure.Framework;
using Deluxe.Infrastructure.Framework.Repositories;
using Deluxe.Infrastructure.Persistence.SqlServer.Data;
using Deluxe.Infrastructure.Persistence.SqlServer.Repositories.Adapters;

namespace Deluxe.Infrastructure.Persistence.SqlServer.Repositories
{
    public class BookingRepository : IRepository
    {
        private readonly MerloEntities _merloEntities;
        public BookingRepository()
        {
            _merloEntities = new MerloEntities();
        }

        public T GetById<T>(int id) where T : IAggregate
        {
            throw new NotImplementedException();
        }

        public CommandResponse CreateBookingFromRequest<T>(T item) where T : class, IAggregate
        {
            // Gets a BookingRequest
            var request = item as BookingRequest;
            var booking = Adapter.RequestToBooking(request);
            
            _merloEntities.Bookings.Add(booking); //.Set<T>().Add(booking);
            var count = _merloEntities.SaveChanges();

            var response = new CommandResponse(count >0, booking.Id) {RequestId = new Guid(booking.RequestId)};
            return response;
        }
    }
}