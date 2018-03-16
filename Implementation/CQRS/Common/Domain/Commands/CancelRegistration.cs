using System;

namespace FP.Spartakiade2018.CQRS.Domain.Commands
{
    public class CancelRegistration
    {
        public Guid ConferenceId { get; set; }

        public Guid RegistrationId { get; set; }

        public string Reason { get; set; }
    }
    
}
