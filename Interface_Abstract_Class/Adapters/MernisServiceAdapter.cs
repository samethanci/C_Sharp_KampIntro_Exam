using Interface_Abstract_Class.Abstract;
using Interface_Abstract_Class.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract_Class.Adapters
{
    internal class MernisServiceAdapter : ICustomerCheckService
    {

        //ServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
        //return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
        //    customer.DateOfBirth.Year);
        public bool CheckIfRealCustomer(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
                customer.DateOfBirth.Year);
        }
    }
}
