using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MTPApp.Core;


namespace MTPApp
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User("name", "last");
            user.FirstName = "mate";
            user.LastName = "Phuthanet";

            double math = Math.PI;

            double msg = MateService.PI;

            prinfCustomer();

            CustomerService customerservice = new CustomerService();


            Customer customer = new Customer();
            customer.FirstName = "Bobbie";
            customer.LastName = "Shaw";
            customer.Id = 0;
            customer.Address = "London";
            customerservice.CreateCustomer(customer);

            prinfCustomer();
            Customer customer2 = new Customer() { FirstName = "Mate", LastName = "Phuthanet", Id = 0, Address = "Non" };

            customerservice.CreateCustomer(customer2);
            prinfCustomer();

            Customer customer4 = new Customer() { FirstName = "Boooo", LastName = "mamamama", Id = 3, Address = "America" };
            customerservice.UpdateCustomer(customer4);
            prinfCustomer();

            Customer customer8 = customerservice.DeleteCustomer(3);
            prinfCustomer();

            Customer customer3 = customerservice.FindCustomerById(10);
            if (customer3 != null)
            {
                Console.WriteLine($"Name: {customer3.FirstName} {customer3.LastName} ID: {customer3.Id} Address : {customer3.Address}");
            }
            else
            {
                Console.WriteLine("No User");
            }


            Console.ReadLine();
        }

        public static void prinfCustomer()
        {
            CustomerService customerservice = new CustomerService();

            List<Customer> customers = customerservice.GetAllCustomers();
            foreach (var item in customers)
            {
                Console.WriteLine($"Name: {item.FirstName} {item.LastName} ID: {item.Id} Address : {item.Address}");
            }
            Console.ReadLine();

        }

    }
}
