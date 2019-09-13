using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpWebServerMvcF.BL;
using HttpWebServerMvcF.Domain;
using HttpWebServerMvcF.Models;

namespace HttpWebServerMvcF.Controllers
{
    public class PartyController : Controller
    {
        readonly IPartiesService _partiesService;
        readonly IParticipantsService _participantsService;
        public PartyController(IParticipantsService participantsService, IPartiesService partiesService)
        {
            _partiesService = partiesService;
            _participantsService = participantsService;
        }


        [HttpGet]
        public ActionResult Index(int partyId)
        {
            if (partyId == 0)
            {
                return RedirectToAction("Parties", "Home");
            }
            return View(_partiesService.GetById(partyId));
        }

        [HttpPost]
        public ActionResult Vote(int id, string name, string attend, string reason)
        {
            _participantsService.Vote(name, attend, reason, id);
            return RedirectToAction("Participants", new { partyId = id });
        }

        public ActionResult Participants(int partyId)
        {
            var viewModel = new PartyParticipantViewModel(_participantsService, _partiesService, partyId);
            return View(viewModel);
        }

    }
}