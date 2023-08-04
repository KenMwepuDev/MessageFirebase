using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFirebase.Model
{
    public class MesageObject
    {
        public string MessageText { get; set; }
        public string userOwner { get; set; }
        public DateTime DateSend { get; set; }
    }
}
