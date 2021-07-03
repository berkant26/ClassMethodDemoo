using System;
using System.Collections.Generic;

namespace ClassMethodDemoo
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Id = 1;
            customer1.Name = "berkant";
            customer1.Age = 20;

            Customers customer2 = new Customers();
            customer2.Id = 2;
            customer2.Name = "murat";
            customer2.Age = 24;


            Customers[] customers = new Customers[] {customer1,customer2};


            foreach (var item in customers)
            {
                Console.WriteLine("Customer name: " + item.Name + " " + "Customer Id :" + item.Id);
            }



                CustomerManager customerManager = new CustomerManager();
                customerManager.Add("Hasan",9);
                 CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Delete("Hasan");
           



        }
    }
}
