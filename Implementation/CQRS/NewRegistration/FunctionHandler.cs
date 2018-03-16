using System.Linq;
using FP.Spartakiade2018.CQRS.Data;
using FP.Spartakiade2018.CQRS.Domain.Commands;
using FP.Spartakiade2018.CQRS.Domain.Handlers;
using FP.Spartakiade2018.CQRS.Domain.Models;
using FP.Spartakiade2018.CQRS.Messaging;
using Newtonsoft.Json;
using OpenFaaS.Dotnet;

namespace Function
{
    public class FunctionHandler : BaseFunction
    {
        public FunctionHandler(IFunctionContext functionContext)
            : base(functionContext)
        {
        }

        public override void Handle(string input)
        {
            var addConferenceCommand = JsonConvert.DeserializeObject<NewRegistration>(input);
            var conferenceHandler = new ConferenceHandler();
            var events = conferenceHandler.Handle(addConferenceCommand).ToArray();

            var dl = new CommandDataLayer();
            dl.SaveEventData(events);

            var commandResult = new CommandResult
            {
                CommandName = "NewRegistration",
                EventId = events.Select(x => x.Id).ToArray()
            };

            Context.WriteContent(JsonConvert.SerializeObject(commandResult));
            using (var bus = new EventBus())
            {
                foreach (var e in events)
                {
                    bus.Publish(e);
                }
            }
        }
    }
}
