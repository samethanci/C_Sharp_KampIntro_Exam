using Interface_Abstract_Class.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract_Class.Abstract
{
    internal abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine($"Saved to db: {customer.FirstName}");
        }
    }
}
