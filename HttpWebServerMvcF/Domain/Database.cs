using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpWebServerMvcF.Domain
{
    class Database
    {
        public List<Participant> Participants { get; set; }
    }

    public class Participant
    {
        public Participant(string name, bool isAttend, string reason, int partyId)
        {
            Name = name;
            IsAttend = isAttend;
            Reason = reason;
            PartyId = partyId;
        }
        public string Name { get; set; }
        public bool IsAttend { get; set; }
        public string Reason { get; set; }
        public int PartyId { get; set; }
    }
}
