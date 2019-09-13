using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;
using HttpWebServerMvcF.Infrastructure;
using Newtonsoft.Json;

namespace HttpWebServerMvcF.DAL
{
    class ParticipantRepository : IParticipantRepository
    {
        private static string jsonFile = @"f:\Study\Homework\HttpWebServerMvcF\HttpWebServerMvcF\bin\json1.json";

        private ILogger Logger { get; set; }
        private static Database Data { get; set; }
        private static List<Party> Parties { get; set; }
        private static List<Participant> Participants { get; set; }

        public ParticipantRepository(ILogger logger)
        {
            Data = JsonConvert.DeserializeObject<Database>(File.ReadAllText(jsonFile));
            Participants = Data.Participants;
            Logger = logger;
        }


        public void Save(Participant participant)
        {
            var oldParticipant = Participants.SingleOrDefault(x => x.Name == participant.Name);
            if (oldParticipant != null)
            {
                oldParticipant.IsAttend = participant.IsAttend;
                oldParticipant.Reason = participant.Reason;
                oldParticipant.PartyId = participant.PartyId;
                Logger.Log(DateTime.Now + $" - обновление участника {oldParticipant.Name}.");
            }
            else
            {
                Participants.Add(participant);
                Logger.Log(DateTime.Now + $" - добавление участника {participant.Name}.");
            }
            Commit();
        }

        public List<Participant> List()
        {
            return Participants;
        }

        public List<Party> PartyList()
        {
            return Parties;
        }

        public void Delete(string name)
        {
            var participant = Participants.SingleOrDefault(x => x.Name == name);
            Participants.Remove(participant);
        }

        public Participant Get(string name)
        {
            throw new NotImplementedException();
        }

        private void Commit()
        {
            File.WriteAllText(jsonFile, JsonConvert.SerializeObject(Data));
            Logger.Log(DateTime.Now + " - запись в базу данных.");
        }
    }
}
