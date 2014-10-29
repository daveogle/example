using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class Purchase
    {
        public int purchaseID { get; set; }
        public DateTime purchaseDate { get; set; }
        public Dealership dealership { get; set; }
        public Customer customer { get; set; }
        //public Car car { get; set; }

        public Purchase ()
        { }
    }
}
