using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.BL
{
    public class ParticipantsService : IParticipantsService
    {
        
        public delegate void SaveEventHandler();
        public event SaveEventHandler SaveParticipant;
        private IParticipantRepository Repository { get; set; }
        public ParticipantsService(IParticipantRepository repository)
        {
            Repository = repository;
        }

        public void Vote(string name, string attend, string reason, int partyId)
        {
            var isAttend = attend == "on";
            var participant = new Participant(name, isAttend, reason, partyId);
            Repository.Save(participant);
            SaveParticipant?.Invoke();
        }


        public List<Participant> ListAll()
        {
            return Repository.List();
        }

        public List<Participant> ListAttended(int partyId)
        {
            return Repository.List().Where(x => x.IsAttend && x.PartyId == partyId).ToList();
        }

        public List<Participant> ListMissed(int partyId)
        {
            return Repository.List().Where(x => !x.IsAttend && x.PartyId == partyId).ToList();
        }
    }
}
