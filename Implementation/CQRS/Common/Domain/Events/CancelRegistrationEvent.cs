using System;

namespace FP.Spartakiade2018.CQRS.Domain.Events
{
    public class CancelRegistrationEvent : EventBase
    {
        public Guid ConferenceId { get; set; }

        public Guid RegistrationId { get; set; }

        public string Reason { get; set; }
    }
}
