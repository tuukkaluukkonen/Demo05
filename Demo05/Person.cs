using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Person
    {
        public string Firstname { get; set; }
        public string lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            return Firstname + " " + lastname + " " + SocialSecurityNumber;
        }
    }
}
