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

        public DbSet<User> User { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<PrivateMessage> PrivateMessage { get; set; }

        public DbSet<Message> Message { get; set; }

        public DbSet<LoggedInUser> LoggedInUser { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}