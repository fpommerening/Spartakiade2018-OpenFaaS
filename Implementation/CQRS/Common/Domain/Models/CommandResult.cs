using System;

namespace FP.Spartakiade2018.CQRS.Domain.Models
{
    public class CommandResult
    {
        public Guid[] EventId { get; set; }

        public string CommandName { get; set; }
    }
}
