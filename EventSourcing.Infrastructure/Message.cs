﻿
namespace EventSourcing.Infrastructure
{
    public class Message
    {
        public string SagaId { get; protected set; }
    }
}