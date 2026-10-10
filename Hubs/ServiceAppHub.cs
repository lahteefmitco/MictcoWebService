using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MictcoWebService.Hubs
{
    /// <summary>
    /// Real-time notifications for the Service App (e.g. general remarks changes).
    /// </summary>
    public class ServiceAppHub : Hub
    {
        public static string TicketGroup(int ticketId) => $"service-ticket-{ticketId}";

        // Optional: a client can subscribe to a single ticket instead of listening to everything.
        public Task JoinTicket(int ticketId) =>
            Groups.AddToGroupAsync(Context.ConnectionId, TicketGroup(ticketId));

        public Task LeaveTicket(int ticketId) =>
            Groups.RemoveFromGroupAsync(Context.ConnectionId, TicketGroup(ticketId));
    }
}
