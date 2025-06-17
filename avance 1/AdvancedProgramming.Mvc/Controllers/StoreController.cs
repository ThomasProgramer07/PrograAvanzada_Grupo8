using AdvancedProgramming.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace AdvancedProgramming.Mvc.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreFruitsBusiness storeBusiness;
        public StoreController()
        {
            storeBusiness = new StoreFruitsBusiness();    
        }

        //GET: Test
        public ActionResult Index()
        {
            var store = storeBusiness.FillStore();
            ViewBag.Message = "this is a test";
            return View(store);
        }
    }
}