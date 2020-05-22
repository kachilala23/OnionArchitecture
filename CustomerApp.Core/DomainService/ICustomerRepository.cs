using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Core.DomainService
{
    public interface ICustomerRepository
    {
        // CRUD for customers
        Customer Create(Customer customer);
        Customer ReadById(int id);
        List<Customer> ReadAll();
        Customer Update(Customer customer);
        Customer Delete(int id);
    }
}
