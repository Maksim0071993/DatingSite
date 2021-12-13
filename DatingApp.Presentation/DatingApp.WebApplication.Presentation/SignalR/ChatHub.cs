using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.SignalR
{
    public class ChatHub : Hub
    {
        private Dictionary<int, List<string>> connections = new Dictionary<int, List<string>>();
        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }
        public async Task Send(string message,int id, string name)
        {
            await this.Clients.User(id.ToString()).SendAsync("Send", message, name);
        }
    }
}
