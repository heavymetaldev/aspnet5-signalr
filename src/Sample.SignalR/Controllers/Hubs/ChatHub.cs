using System;
using System.Reflection;
using System.Threading.Tasks;

namespace  Sample.SignalR.Controllers.Hubs
{
    using Microsoft.AspNet.SignalR;

    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        public override async Task OnConnected()
        {
            await base.OnConnected();
        }
    }
}