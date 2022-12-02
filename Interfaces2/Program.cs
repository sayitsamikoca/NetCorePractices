using System;

namespace Interfaces2 // İyi Programcı Serisi - Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            // Müşteri Eklendi

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            // Personel Eklendi


            // ---------------------------------------------------------

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new CustomerManager());
            projectManager.Update(new CustomerManager());

            projectManager.Add(new EmployeeManager());
            projectManager.Update(new EmployeeManager());

            // Yeni birşey eklediğimde mimarim bozulmadı,hiç dokunmadım ona !
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());


        }
    }

    interface IPersonManager
    {
        // unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi..");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi..");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
