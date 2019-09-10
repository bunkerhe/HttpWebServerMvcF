using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.Controllers
{
    public class PartyController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {
            var test = title;
            return View(new Party
            {
                Id = 1,
                Date = DateTime.Now,
                Title = "Helloween",
                Location = "ИТ Академия"
            });
        }

        [HttpPost]
        public ActionResult Vote(int id, string name,  string attend, string reason)
        {
            return RedirectToAction("Participants", new {id = id});
        }

        public ActionResult Participants(int id)
        {
            return View(new List<Participant>());
        }

    }
}