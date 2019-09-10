using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.BL
{
    interface IParticipantsService
    {
        event ParticipantsService.SaveEventHandler SaveParticipant;
        void Vote(string name, bool isAttend, string reason, int partyId);

        List<Participant> ListAll();

        List<Participant> ListAttended();
        List<Participant> ListMissed();
    }
}