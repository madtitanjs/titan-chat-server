using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanMessaging.Core.Mapper;
using TitanMessaging.Core.Models;
using TitanMessaging.EntityFramework;

namespace TitanMessaging.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IRepository repository;

        public async Task<IEnumerable<Channel>> GetUserChannels(Guid userID)
        {
            var entities = repository.Channels
                .Where(
                    x => x.UserChannels.Any(uc => uc.User.UserID == userID)
                );

            return await entities.Select(x => x.ToModel()).ToListAsync();
        }

        public async Task<IEnumerable<Channel>> SearchChannels(string query)
        {
            // search by name or users
            query = query ?? String.Empty;
            var _query = query.ToLower();
            var entities = repository.Channels
                .Where(
                    x => x.ChannelName.ToLower().Contains(_query) ||
                    x.UserChannels.Any(
                        uc => uc.User.FirstName.ToLower().Contains(_query) ||
                                uc.User.LastName.ToLower().Contains(_query)
                        )
                    );

            return await entities.Select(x => x.ToModel()).ToListAsync();
        }
    }
}
