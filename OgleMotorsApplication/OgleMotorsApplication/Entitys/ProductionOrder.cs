using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class ProductionOrder : Order
    {
        public ProductionOrder(int orderNo, bool confirmed)
            : base(orderNo, confirmed)
        {
        }
    }
}
