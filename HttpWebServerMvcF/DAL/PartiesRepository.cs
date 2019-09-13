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
    class PartiesRepository : IPartiesRepository
    {
        private static List<Party> Parties { get; set; }

        public PartiesRepository()
        {
            Parties = new List<Party>();
            var halloween =
                new Party
                {
                    Id = 1,
                    Date = new DateTime(2019, 10, 25, 18, 0, 0),
                    Title = "Halloween",
                    Location = "Кафе 'Березка'"
                };
            Parties.Add(halloween);
            var newYear =
                new Party
                {
                    Id = 2,
                    Date = new DateTime(2019, 12, 28, 18, 0, 0),
                    Title = "Новый год",
                    Location = "Кафе 'Волна'"
                };
            Parties.Add(newYear);
            var firmBirthDay =
                new Party
                {
                    Id = 3,
                    Date = new DateTime(2019, 11, 5, 18, 0, 0),
                    Title = "ДР фирмы",
                    Location = "Бар 'У Толяна'"
                };
            Parties.Add(firmBirthDay);
        }



        public List<Party> List()
        {
            return Parties;
        }

    }
}
