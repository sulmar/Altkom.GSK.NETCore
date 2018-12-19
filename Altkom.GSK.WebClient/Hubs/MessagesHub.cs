using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Altkom.GSK.WebClient.Hubs
{
    public class MessagesHub : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.SendAsync("NewMessage", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("NewMessage", "Hi");

            await base.OnConnectedAsync();
        }
    }
}
