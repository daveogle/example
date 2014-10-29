using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgleMotorsApplication.Entitys
{
    //TODO: Add a hashing function
    class Account
    {
        public String username { get; set; }
        public String password { get; set; }
        public LinkedList<int> accessLevels { get; set; }

        public Account (String username, String password)
        {

        }

        //TODO: Include hasking of toCompare
        public bool ValidatePass(String toCompare)
        {
            return password == toCompare;
        }

        public void doAthing()
        {
            string a = "Dave";
            a = "Do some more things";
            int b = 20;
            b += 40;
        }
    }
}
