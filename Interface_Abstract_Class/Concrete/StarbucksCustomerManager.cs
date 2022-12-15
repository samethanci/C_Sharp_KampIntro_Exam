using Interface_Abstract_Class.Abstract;
using Interface_Abstract_Class.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract_Class.Concrete
{
    internal class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid customer");
            }
        }

    }
}
