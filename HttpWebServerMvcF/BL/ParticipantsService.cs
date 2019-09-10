using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.BL
{
    class ParticipantsService : IParticipantsService
    {
        
        public delegate void SaveEventHandler();
        public event SaveEventHandler SaveParticipant;
        private IParticipantRepository Repository { get; set; }
        public ParticipantsService(IParticipantRepository repository)
        {
            Repository = repository;
        }

        public void Vote(string name, bool isAttend, string reason, int partyId)
        {
            var participant = new Participant(name, isAttend, reason, partyId);
            Repository.Save(participant);
            SaveParticipant?.Invoke();
        }


        public List<Participant> ListAll()
        {
            return Repository.List();
        }

        public List<Participant> ListAttended()
        {
            return Repository.List().Where(x => x.IsAttend).ToList();
        }

        public List<Participant> ListMissed()
        {
            return Repository.List().Where(x => !x.IsAttend).ToList();
        }
    }
}
