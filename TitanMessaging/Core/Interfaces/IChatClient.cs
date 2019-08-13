using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TitanMessaging.Core.Models;

namespace TitanMessaging.Core.Interfaces
{
    public interface IChatClient
    {
        Task ReceiveChannels(IEnumerable<Channel> channels);
        Task ReceiveSearchChannelsResult(IEnumerable<Channel> channels);
        Task ReceiveMessages(IEnumerable<Message> messages);
        Task ReceiveMessage(Message message);
    }
}
