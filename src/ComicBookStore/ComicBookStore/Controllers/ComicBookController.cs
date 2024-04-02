using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStore.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) {
                return Redirect ("/");
            }


            ViewBag.Title = "Super Mario 64";
            ViewBag.Description = "Super Mario 64 is a 1996 platform video game developed and published by Nintendo for the Nintendo 64.";
            ViewBag.Characters = new string[]
            {
                "Mario",
                "Princess Peach",
                "Bowser",
                "Toad",
                "Yoshi"
            };

            return View();
            //return Content ("Hello from the Comic Book Store");
        }
    }
}