using ShoppingWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWeb.Controllers
{
    public class AuthanticationController : Controller
    {
        // GET: Authantication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logon()
        {

            UserProxy.GetUserByLoginNamePassword();

        }
    }
}