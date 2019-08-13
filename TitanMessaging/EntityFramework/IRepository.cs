using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TitanMessaging.Core.Entities;

namespace TitanMessaging.EntityFramework
{
    public interface IRepository
    {
        DbSet<Channel> Channels { get; }
        DbSet<Message> Messages { get; }
        DbSet<User> Users { get; }

        Task SaveChangesAsync();
    }
}