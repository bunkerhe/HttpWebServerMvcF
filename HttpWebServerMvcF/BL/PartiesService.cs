using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.BL
{
    public class PartiesService : IPartiesService
    {
        private IPartiesRepository Repository { get; set; }
        private IParticipantsService ParticipantService { get; set; }
        public PartiesService(IPartiesRepository repository, IParticipantsService participantService)
        {
            Repository = repository;
            ParticipantService = participantService;
        }

        public List<Party> List()
        {
            return Repository.List();
        }

        public Party GetById(int id)
        {
            return Repository.List().SingleOrDefault(x => x.Id == id);
        }
    }
}
