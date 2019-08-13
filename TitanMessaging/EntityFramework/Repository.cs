using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TitanMessaging.Core.Entities;

namespace TitanMessaging.EntityFramework
{
    public class Repository : IRepository
    {
        private readonly ChatDbContext Context;

        public Repository(ChatDbContext context)
        {
            Context = context;
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public DbSet<Channel> Channels { get { return Context.Channels; } }
        public DbSet<User> Users { get { return Context.Users; } }
        public DbSet<Message> Messages { get { return Context.Messages; } }

    }
}
