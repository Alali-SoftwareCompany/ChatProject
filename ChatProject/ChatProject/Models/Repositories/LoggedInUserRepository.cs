using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models.Repositories
{
    public class LoggedInUserRepository
    {
        private MyContext _context = new MyContext();


        public List<LoggedInUser> FindAll()
        {
            return this._context.LoggedInUsers.ToList<LoggedInUser>();
        }


        public LoggedInUser FindById(int id)
        {
            return this._context.LoggedInUsers.Find(id);
        }

        


    }
}