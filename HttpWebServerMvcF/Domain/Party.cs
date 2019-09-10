using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpWebServerMvcF.Domain
{
    public class Party
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}