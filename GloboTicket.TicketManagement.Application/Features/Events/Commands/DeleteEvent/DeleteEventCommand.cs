using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand: IRequest<Unit>
    {
        public Guid EventId { get; set; }
    }
}
