using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models
{
    public class UserRepository
    {
        private MyContext _context = new MyContext();

        public List<User> FindAll()
        {
            return this._context.User.ToList<User>();
        }

        public User FindById(int id)
        {
            return this._context.User.Find(id);
        }


    }
}