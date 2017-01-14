using ChatProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatProject.Controllers
{
    public class RoomController : Controller
    {
        private RoomRepository _roomRepos = new RoomRepository();

        // GET: Room
        public ActionResult Index()
        {

            this.ViewBag.Rooms = this._roomRepos.FindAll();
            return View();
        }
    }
}