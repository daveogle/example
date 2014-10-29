using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class Address
    {
        public String addressLine1 { get; set; }
        public String addressLine2 { get; set; }
        public String addressLine3 { get; set; }
        public String city { get; set; }
        public String postcode { get; set; }
        public int addressID { get; set; }
        public int regionID { get; set; }

        public Address()
        { }

        /// <summary>
        /// Compares this address' city to the one passed
        /// </summary>
        /// <param name="toCompare">The address to comapare to</param>
        /// <returns>True if cities match, false otherwise</returns>
        public bool SameCity(Address toCompare)
        {
            return this.city == toCompare.city;
        }

        /// <summary>
        /// Compares this address' region id to the one passed
        /// </summary>
        /// <param name="toCompare">The address to compare to</param>
        /// <returns>True if region ids match, false otherwise</returns>
        public bool SameRegion(Address toCompare)
        {
            return this.regionID == toCompare.regionID;
        }
    }
}
