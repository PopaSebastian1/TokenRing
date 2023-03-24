using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenRing
{
    public class Calculator
    {

        public String Ip { get; set; }
        public Calculator Next { get; set; }
        public Calculator Prev { get; set; }

        public Token Token { get; set; }
        public Calculator(String ip)
        {
            Ip = ip;
            Next = null;
            Prev = null;
            Token = null;
        }

        

    }
}
