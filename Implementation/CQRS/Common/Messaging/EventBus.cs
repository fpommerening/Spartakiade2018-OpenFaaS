using System;
using System.Threading.Tasks;
using EasyNetQ;
using EasyNetQ.NonGeneric;
using FP.Spartakiade2018.CQRS.Domain.Events;

namespace FP.Spartakiade2018.CQRS.Messaging
{
    public class EventBus : IDisposable
    {
        private IBus _bus;

        private IBus Bus()
        {
            return _bus ?? (_bus = RabbitHutch.CreateBus(DockerSecretHelper.GetSecretValue("MessageBusCnn")));
        }

        public void Publish<T>(T eventData) where T : EventBase
        {
            Bus().Publish(eventData.GetType(), eventData);
        }

        public IDisposable Subscribe<T>(string id, Func<T, Task> handler) where T : EventBase
        {
            return Bus().SubscribeAsync<T>(id, handler);
        }

        public void Dispose()
        {
            _bus?.Dispose();
        }
    }
}
