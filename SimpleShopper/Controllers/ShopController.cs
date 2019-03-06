using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SimpleShopper.Controllers
{
    public class ShopController:Controller
    {
        public ActionResult Index()
        {
            return Content("hello");
            //return View();
        }
    }
}
