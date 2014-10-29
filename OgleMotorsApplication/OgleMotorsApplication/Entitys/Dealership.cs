using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class Dealership
    {
        public int dealershipID { get; set; }
        public String name { get; set; }
        public Address address { get; set; }
        public Staff staffMember { get; set; }

        public Dealership ()
        { }
    }
}
