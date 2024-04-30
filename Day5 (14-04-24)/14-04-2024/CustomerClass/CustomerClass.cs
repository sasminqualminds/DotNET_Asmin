using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class CustomerClass
    {
        private string name;
        private string ph_num;

        public CustomerClass(string name, string ph_num)
        {
            this.name = name;
            this.ph_num = ph_num;
        }

        public string details()
        {
            return "My name is "+name + " and Phone number is " + ph_num;
        }
        
    }
}
