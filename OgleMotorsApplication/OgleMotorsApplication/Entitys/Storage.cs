using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class Storage
    {
        public int capacity { get; set; }
        public int storageId { get; set; }
        //public List<Car> car { get; set; }
        //Address

        public Storage(int capacity, int storageId)
        {
            this.capacity = capacity;
            this.storageId = storageId;
        }
    }
}
