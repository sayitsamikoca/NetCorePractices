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
        }
    }
}
