using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models.Repositories
{
    public class PrivateMessageRepository
    {
        private MyContext _context = new MyContext();


        public List<PrivateMessage>FindAll()
        {
            return this._context.PrivateMessages.ToList<PrivateMessage>();
        }

        public PrivateMessage FindById(int id)
        {
            return this._context.PrivateMessages.Find(id);
        }


        public void InsertPrivateMessage(PrivateMessage pm)
        {
            this._context.PrivateMessages.Add(pm);

            this._context.SaveChanges();
        }


        public void UpdatePrivateMessage(PrivateMessage pm)
        {
            PrivateMessage dbPM = this.FindById(pm.PrivateMessageID);

            

        }

        public void DeletePrivateMessage(PrivateMessage pm)
        {
            PrivateMessage dbPM = this.FindById(pm.PrivateMessageID);
            this._context.PrivateMessages.Remove(pm);

            this._context.SaveChanges();

        }




    }
}