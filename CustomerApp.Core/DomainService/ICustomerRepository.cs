using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Core.DomainService
{
    public interface ICustomerRepository
    {
        // CRUD for customers
        //Create
        Customer Create(Customer customer);
        // Read
        Customer ReadById(int id);
        List<Customer> ReadAll();
        // Update
        Customer Update(Customer customer);
        // Delete
        Customer Delete(int id)
    }
}
