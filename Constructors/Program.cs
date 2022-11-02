using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Sayit Sami",
                LastName = "Koca",
                City = "Aksaray"
            };

            Customer customer2 = new Customer(2, "Kevin", "Mittnick", "New York");

            Console.WriteLine(customer2.FirstName + " " +customer2.LastName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }

        // Default Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
