using System;

namespace AttributesMyWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,FirstName="Sayit",LastName="Koca",Age=20 };
            CustomerDal customerDal = new CustomerDal();
            // customerDal.Add(customer);
            customerDal.AddNew(customer);
            

        }
    }

    [ToTable("Customers")]
    [ToTable("Tbl_Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class , AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    class CustomerDal
    {
        [Obsolete("Don't use add, instead use AddNew method.")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} , {1} , {2} , {3} eklendi.",customer.FirstName,customer.LastName , customer.Age , customer.Id );
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0} , {1} , {2} , {3} eklendi.", customer.FirstName, customer.LastName, customer.Age, customer.Id);
        }
    }
}
