using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemoo
{
    class CustomerManager
    {
        public void Add(String Name, int Id)
        {
            Console.WriteLine("Customer Added!!" + " " + "Id:" + Id + " " + "Name: " + Name);
        }

        public void Delete( String Name)
        {
            Console.WriteLine("Customer Deleted"+" " +Name);
        }
        


    }
}
