using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MTPApp.Core
{

    public class CustomerService
    {
        public CustomerService()
        {
            if (FakeDB.Customers.Count >= 1) return;
            var cust1 = new Customer()
            {
                Id = FakeDB.Id++,
                FirstName = "Bob",
                LastName = "Dylan",
                Address = "BongoStreet 202"
            };
            FakeDB.Customers.Add(cust1);

            var cust2 = new Customer()
            {
                Id = FakeDB.Id++,
                FirstName = "Lars",
                LastName = "Bilde",
                Address = "Ostestrasse 202"
            };
            FakeDB.Customers.Add(cust2);
        }
        public List<Customer> GetAllCustomers()
        {
            return FakeDB.Customers;
        }
        public Customer FindCustomerById(int id)
        {
            return FakeDB.Customers.
                Select(c => new Customer()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    Address = c.Address,
                    LastName = c.LastName
                }).
                FirstOrDefault(c => c.Id == id);
        }
        public Customer CreateCustomer(Customer customer)
        {
            customer.Id = FakeDB.Id++;
            FakeDB.Customers.Add(customer);
            return customer;
        }
        public Customer UpdateCustomer(Customer customerUpdate)
        {
            var customerFromDB = FindCustomerById(customerUpdate.Id);
            if (customerFromDB == null) return null;

            customerFromDB.FirstName = customerUpdate.FirstName;
            customerFromDB.LastName = customerUpdate.LastName;
            customerFromDB.Address = customerUpdate.Address;
            FakeDB.Customers[customerUpdate.Id-1]=customerFromDB;
            return customerFromDB;
        }
        public Customer DeleteCustomer(int id)
        {
            var customerFound = FindCustomerById(id);
            if (customerFound == null) return null;

            FakeDB.Customers.RemoveAt(customerFound.Id-1);
            return customerFound;
        }
        public int Count()
        {
            return FakeDB.Customers.Count();
        }

        public Customer NewCustomer (string firstname,string lastname)
        {
            Customer customer = new Customer() { FirstName = firstname, LastName = lastname };
            customer.Id = FakeDB.Id++;
            FakeDB.Customers.Add(customer);
            return customer;
        }
        
    }
}
