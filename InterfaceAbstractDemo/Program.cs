using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer 
            {
                DateOfBirth = new DateTime(1900,01,01),
                FirstName = "Sayit Sami",
                LastName = "Koca",
                NationalityId = "12345678901"
            
            });

            StarbucksCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            starbucksCustomerManager.AddStar(new Customer 
            {
                Id=2,
                FirstName = "Bill",
                LastName = "Gates",
                DateOfBirth = new DateTime(1800,01,01),
                NationalityId  = "43211232"
            });
        }
    }
}
