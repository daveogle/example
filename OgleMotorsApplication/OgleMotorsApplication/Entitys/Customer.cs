using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    class Customer
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String title { get; set; }
        public String occupation { get; set; }
        public DateTime dateOfBirth { get; set; }
        public char sex { get; set; }
        public int income { get; set; }
        public int customerID { get; set; }

        public Customer ()
        {}

        /// <summary>
        /// Compares this customer's occupation to the one passed
        /// </summary>
        /// <param name="toCompare">The customer to compare</param>
        /// <returns>True if the same occupation, false otherwise</returns>
        public bool SameOccupation(Customer toCompare)
        {
            return this.occupation == toCompare.occupation;
        }

        /// <summary>
        /// Gets the difference between this customer's income and the one passsed
        /// </summary>
        /// <param name="toCompare">Customer to compare to</param>
        /// <returns>The difference between the customers' incomes</returns>
        public int CompareIncome(Customer toCompare)
        {
            return this.income - toCompare.income;
        }
    }
}
