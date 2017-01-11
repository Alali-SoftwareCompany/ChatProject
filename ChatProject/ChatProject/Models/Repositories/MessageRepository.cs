using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models.Repositories
{
    public class MessageRepository
    {

        private MyContext _context = new MyContext();


        public List<Message> FindAll()
        {
            return this._context.Messages.ToList<Message>();
        }


        public Message FindById(int id)
        {
            return this._context.Messages.Find(id);
        }



        public void InsertMessage(Message m)
        {
            this._context.Messages.Add(m);
            this._context.SaveChanges();

        }


        public void UpdateMessage(Message m)
        {
            Message dbms = this.FindById(m.MessageID);

            dbms.RecieveTime = m.RecieveTime;
            dbms.Text = m.Text;

            this._context.SaveChanges();

        }


        public void DeleteMessage(int id)
        {
            Message m = this.FindById(id);

            this._context.Messages.Remove(m);
            this._context.SaveChanges();

        }






    }
}