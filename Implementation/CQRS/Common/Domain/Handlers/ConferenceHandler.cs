using System;
using System.Collections.Generic;
using FP.Spartakiade2018.CQRS.Domain.Commands;
using FP.Spartakiade2018.CQRS.Domain.Events;

namespace FP.Spartakiade2018.CQRS.Domain.Handlers
{
    public class ConferenceHandler
    {
        public IEnumerable<EventBase> Handle(AddConference command)
        {
            var addConferenceEvent = new AddConferenceEvent
            {
                Id = Guid.NewGuid(),
                Description = command.Description,
                Name = command.Name,
                Start = command.Start,
                End = command.End,
                RegistrationStart = command.RegistrationStart,
                RegistrationEnd = command.RegistrationEnd
            };
            yield return addConferenceEvent;
        }

        public IEnumerable<EventBase> Handle(NewRegistration command)
        {
            var newRegistrationEvent = new NewRegistrationEvent
            {
                Id = Guid.NewGuid(),

                Company = command.Company,
                FirstName = command.FirstName,
                Name = command.Name,
                ConferenceId = command.ConferenceId,
                Email = command.Email
            };
            yield return newRegistrationEvent;
        }

        public IEnumerable<EventBase> Handle(CancelRegistration command)
        {
            var cancelRegistrationEvent = new CancelRegistrationEvent
            {
                Id = Guid.NewGuid(),
                ConferenceId = command.ConferenceId,
                RegistrationId = command.RegistrationId,
                Reason = command.Reason
            };
            yield return cancelRegistrationEvent;
        }
    }
}
