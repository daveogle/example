using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    abstract class Order
    {
        public int orderNo { get; set; }
        public DateTime start { get; set; }
        public DateTime estimatedEnd { get; set; }
        public DateTime end { get; set; }
        public int staffId { get; set; }
        public int storageId { get; set; }
        public bool confirmed { get; set; }
        public string comments { get; set; }
        // public List<Car> car { get; set; }

        public Order(int orderNo, bool confirmed)
        {
            this.orderNo = orderNo;
            this.confirmed = confirmed;
        }

    }
}
