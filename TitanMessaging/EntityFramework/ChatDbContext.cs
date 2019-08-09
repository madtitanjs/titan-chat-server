using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TitanMessaging.Core.Entities;

namespace TitanMessaging.EntityFramework
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserChannel>().HasKey(uc => new { uc.ChannelID, uc.UserID });
            modelBuilder.Entity<UserChannel>().HasOne(uc => uc.User).WithMany(c => c.UserChannels).HasForeignKey(f => f.UserID);
            modelBuilder.Entity<UserChannel>().HasOne(uc => uc.Channel).WithMany(c => c.UserChannels).HasForeignKey(f => f.ChannelID);
        }
    }
}
