using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenRing
{
    public class Token
    {
        public String IpSursa { get; set; }

        public String IpDestinatie { get; set; }

        public String Mesaj { get; set; }

        public bool AjunsLaDestinatie { get; set; }

        public bool Liber { get; set; }

        List<Calculator> Istoric {  get; set; }
       
    }
}
