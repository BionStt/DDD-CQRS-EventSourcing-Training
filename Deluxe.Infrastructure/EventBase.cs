﻿using System;

namespace Deluxe.Infrastructure
{
    public class EventBase : Message
    {
        public DateTime TimeStamp { get; private set; }

        public EventBase()
        {
            TimeStamp = DateTime.Now;
            Code = EventType.Unknown;
        }

        public EventType Code { get; protected set; }
    }
}