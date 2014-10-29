using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class Staff
    {
        public int StaffID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String position { get; set; }
        public DateTime employmentDate { get; set; }
        public DateTime terminationDate { get; set; }
        public float salary { get; set; }
        public Address address { get; set; }
        public Account account { get; set; }

        public Staff ()
        { }
    }
}
