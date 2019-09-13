using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.BL
{
     public interface IPartiesService
    {
        List<Party> List();
        Party GetById(int id);
    }
}