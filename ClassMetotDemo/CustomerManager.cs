using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id} id'ye sahip {customer.Customer_First_Name + ' ' +customer.Customer_Last_Name} başarılı şekilde eklendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Id} id'ye sahip {customer.Customer_First_Name + ' ' +customer.Customer_Last_Name} başarılı şekilde silindi.");
        }
        public void Listeleme(params Customer[] customers) 
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id} First Name: {customer.Customer_First_Name} " +
                    $"Last Name: {customer.Customer_Last_Name} Tc No: {customer.Customer_Tc_No} Age: {customer.Customer_Age}");
            }
        }
        
    }
}
