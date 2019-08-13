using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitanMessaging.Core;
using TitanMessaging.Core.Interfaces;
using TitanMessaging.Core.Models;
using TitanMessaging.Services;

namespace TitanMessaging.Hubs
{
    public class MessagingHub : Hub<IChatClient>
    {
        private Dictionary<Guid, string> AvailableChannels = new Dictionary<Guid, string>();
        private readonly IChannelService channelService;
        public MessagingHub()
        {

        }

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, Constants.SignalR.GLOBAL);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, Constants.SignalR.GLOBAL);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task GetAvailableChannels(string query)
        {
            var channels = await channelService.SearchChannels(query);
            await Clients.Caller.ReceiveSearchChannelsResult(channels);
        }

        public async Task SendMessage(Guid channelID, Message message)
        {
            await Clients.Groups(channelID.ToString()).ReceiveMessage(message);           
        }
    }
}
