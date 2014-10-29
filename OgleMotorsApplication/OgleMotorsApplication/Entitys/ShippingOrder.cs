using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{

    class ShippingOrder : Order
    {
        public int dealershipId { get; set; }

        public ShippingOrder(int dealershipId, int orderNo, bool confirmed)
            : base(orderNo, confirmed)
        {
            this.dealershipId = dealershipId;
        }
    }
}
