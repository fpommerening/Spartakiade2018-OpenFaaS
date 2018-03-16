using System.Threading.Tasks;
using FP.Spartakiade2018.CQRS.Data;
using FP.Spartakiade2018.CQRS.Data.ReadModels;
using FP.Spartakiade2018.CQRS.Domain.Events;

namespace FP.Spartakiade2018.CQRS.EventHandler.Projections
{
    public class ConferenceList
    {
        public static Task Handle(AddConferenceEvent addConferenceEvent)
        {
            var dl = new HandlerDataLayer();
            var item = new ConferenceListItem
            {
                ConferenceId = addConferenceEvent.Id,
                Name = addConferenceEvent.Name,
                Start = addConferenceEvent.Start,
                End = addConferenceEvent.End
            };
            return dl.SaveConferenceListItem(item);
        }
    }
}
