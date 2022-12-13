using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();    
            customer1.Id = 1;
            customer1.Customer_Tc_No = "1234567890";
            customer1.Customer_First_Name = "Samet";
            customer1.Customer_Last_Name = "HANCI";
            customer1.Customer_Age = 26;

            Customer customer2 = new Customer() {Id = 2, Customer_Tc_No = "12345678901", Customer_First_Name = "Hatice", Customer_Last_Name = "HANCI", Customer_Age = 52 };

            Customer customer3 = new Customer()
            {
                Id = 3,
                Customer_First_Name = "Ahmet",
                Customer_Last_Name = "HANCI",
                Customer_Tc_No = "5435432435",
                Customer_Age = 56
            };

            Customer[] customers = new Customer[] {customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer3);
            customerManager.Listeleme(customer2);
        }
    }
}
