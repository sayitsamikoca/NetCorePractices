using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfacesIntro();

            Demo();

            Demo2();
        }

        private static void Demo2()
        {
            ICustomerDal[] customerDals = new ICustomerDal[]
                        {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlCustomerDal()
                        };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Mark",
                LastName = "Zuckerberg"
            };

            Student student1 = new Student()
            {
                Id = 1,
                FirstName = "Bill",
                LastName = "Gates"
            };

            PersonManager manager = new PersonManager();
            manager.Add(customer1);
            manager.Add(student1);
        }
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
