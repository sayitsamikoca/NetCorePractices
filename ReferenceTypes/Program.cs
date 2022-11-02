using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,enum,boolean value types (Değer Tiplerdir.)

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1); // 20


            //arrays,class,interface ... reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar1[0] = " + sayilar1[0]); // 1000



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Sayit";

            person2 = person1; // person1 değerleri ne ise person 2'de onu tutar.
            person1.FirstName = "Rasmus";
            //person2.FirstName = Rasmus


            Customer customer = new Customer();
            customer.FirstName = "Dennis";

            Employee employee = new Employee();


            Person person3 = customer; // person3 git, customer'ın referans numarasını tut.

            Console.WriteLine(person3.FirstName); // Dennis

            Console.WriteLine(((Customer)person3).CreditCardNumber); // boxing işlemi (person3 tip değiştirmesi yaptık bir nevi.)


            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            // Person classı base alan, yada onun referans numarasını tutanların alayını yollayabilirim buraya
            //(Çok iş, az kod - dry prensibine uygunluk)
        }
    }

    class Person // Kişi
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // base class : Person (Base sınıfa ondan inherit alan sınıfların, adres numarasını tutabilir, atayabilir.)

    class Customer:Person // Müşteri
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person // Çalışan
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}



