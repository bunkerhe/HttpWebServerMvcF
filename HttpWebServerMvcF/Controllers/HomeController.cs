using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpWebServerMvcF.BL;
using HttpWebServerMvcF.DAL;
using Ninject;

namespace HttpWebServerMvcF.Controllers
{
    public class HomeController : Controller
    {
        readonly IPartiesService _partiesService;
        public HomeController(IPartiesService partiesService)
        {
            _partiesService = partiesService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Parties()
        {
            return View(_partiesService);
        }
    }
}