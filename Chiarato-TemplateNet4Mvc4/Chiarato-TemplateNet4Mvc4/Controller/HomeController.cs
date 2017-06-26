using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplicationVazioNet4Mvc4.ViewModel;

namespace WebApplicationVazioNet4Mvc4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeViewModel() { Titulo = "Aaaaaa" });
        }
       
    }
}