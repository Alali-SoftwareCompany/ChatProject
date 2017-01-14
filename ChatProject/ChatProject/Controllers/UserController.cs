using ChatProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatProject.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _userRepost = new UserRepository();

        // GET: User
        public ActionResult Index()
        {
            this.ViewBag.Users = this._userRepost.FindAll();
            return View();
        }
    }
}