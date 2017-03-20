using System;
using EventSourcing.Infrastructure.Extras.Backend;

namespace EventSourcing.Infrastructure.Extras
{
    public class EmailService
    {
        public static void Send(string address, string message)
        {
            using (var db = new merloXtra())
            {
                var email = new SentEmail {Address = address, Body = message, Sent = DateTime.Now};
                db.SentEmails.Add(email);
                db.SaveChanges();
            }
        }
    }
}