using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TitanMessaging.Core.Models;

namespace TitanMessaging.Services
{
    public interface IChannelService
    {
        Task<IEnumerable<Channel>> GetUserChannels(Guid userID);
        Task<IEnumerable<Channel>> SearchChannels(string query);
    }
}