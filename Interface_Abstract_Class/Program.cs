using Interface_Abstract_Class.Abstract;
using Interface_Abstract_Class.Adapters;
using Interface_Abstract_Class.Concrete;
using System;

namespace Interface_Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManagerNero = new NeroCustomerManager();
            //BaseCustomerManager baseCustomerManagerStarbucks = new StarbucksCustomerManager(new MernisServiceAdapter());

            baseCustomerManagerNero.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(1900, 1, 1),
                FirstName = "Samet",
                LastName = "HANCI",
                NationalityId = "0000000000000",
                Id = 1
            });





        }
    }
}
