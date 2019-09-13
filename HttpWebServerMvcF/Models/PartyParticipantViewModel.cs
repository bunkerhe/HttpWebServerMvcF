using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HttpWebServerMvcF.BL;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.Models
{

    public class PartyParticipantViewModel
    {
        public Party Party { get; set; }
        public List<Participant> Participants { get; set; }
        public PartyParticipantViewModel(IParticipantsService participantService, IPartiesService partiesService, int partyId)
        {
            Party = partiesService.List().SingleOrDefault(x => x.Id == partyId);
            Participants = participantService.ListAttended(partyId);
        }

    }
}