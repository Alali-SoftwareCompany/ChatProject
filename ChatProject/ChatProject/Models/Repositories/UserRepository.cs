using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models.Repositories
{
    public class UserRepository
    {

        private MyContext _context = new MyContext();


        public List<User> FindAll()
        {
            return this._context.Users.ToList<User>();
        }

        public User FindById(int id)
        {
            return this._context.Users.Find(id);
        }


        public void AddUser(User u)
        {
            this._context.Users.Add(u);

            this._context.SaveChanges();
        }


        public void UpdateUser(User u)
        {
            User dbUser = this.FindById(u.UserID);

            dbUser.Firstname = u.Firstname;
            dbUser.Surname = u.Surname;
            dbUser.Password = u.Password;
            dbUser.Username = u.Username;
            dbUser.Sex = u.Sex;


            this._context.SaveChanges();
            
        }


        public void DeleteUser(int id)
        {
            User u = this.FindById(id);
            this._context.Users.Remove(u);
            this._context.SaveChanges();
        }
        

        


    }
}
