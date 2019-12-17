using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingEasy.Areas.Identity.Data
{
    public class Mensaje
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Text { get; set; }

        public DateTime When { get; set; }

        public string UserID { get; set; }

        public virtual ProgramingEasyUser Remitente { get; set; }
    }
}
