using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[] 
            { 

                new Customer
                {
                    FirstName="Mark"
                },
                new Student
                {
                    FirstName="Bill"
                },
                new Person{
                    FirstName="Elon"
                }

            };
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Ebevyn İlişkisi

    class Customer:Person
    {
        public string City { get; set; } 
    }

    class Student:Person
    {
        public string Department { get; set; } 
    }
}
