using CustomerApp.Core.DomainService;
using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Infratructure.Static.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        static int id = 1;
        private static List<Customer> _customers = new List<Customer>();
        public Customer Create(Customer customer)
        {
            customer.Id = id++;
            _customers.Add(customer);
            return customer; 
        }          

        public List<Customer> ReadAll()
        {
            return _customers;
        }

        public Customer ReadById(int id)
        {
            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        //Remove later when we use UOW
        public Customer Update(Customer customerUpdate)
        {
            var customerFromDB = this.ReadById(customerUpdate.Id);
            if (customerFromDB != null)
            {
                customerFromDB.FirstName = customerUpdate.FirstName;
                customerFromDB.LastName = customerUpdate.LastName;
                customerFromDB.Address = customerUpdate.Address;
                return customerFromDB;
            }
            return null;
        }

        public Customer Delete(int id)
        {
            var customerFound = this.ReadById(id);
            if (customerFound != null)
            {
                _customers.Remove(customerFound);
                return customerFound;
            }
            return null;
        }
    }
}
