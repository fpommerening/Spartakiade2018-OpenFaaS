using System;

namespace FP.Spartakiade2018.CQRS.Domain.Events
{
    public abstract class EventBase
    {
        public Guid Id { get; set; }
    }
}
