using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ChatProject.Models
{
    public class MyContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<PrivateMessage> PrivateMessages { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<LoggedInUser> LoggedInUsers { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}