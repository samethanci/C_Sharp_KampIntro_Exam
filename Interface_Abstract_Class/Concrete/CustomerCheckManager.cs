using Interface_Abstract_Class.Abstract;
using Interface_Abstract_Class.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract_Class.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
