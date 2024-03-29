﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpWebServerMvcF.Domain;

namespace HttpWebServerMvcF.DAL
{
    public interface IParticipantRepository
    {
        void Save(Participant participant);
        List<Participant> List();
        void Delete(string name);
        Participant Get(string name);
    }
}
