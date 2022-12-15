using Interface_Abstract_Class.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract_Class.Abstract
{
    internal interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}
