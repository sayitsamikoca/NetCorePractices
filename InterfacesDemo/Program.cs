using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID - Interface Segregation Principle
            IWorker[] workers = new IWorker[]
            {
                new Worker(),
                new Robot(),
                new Manager()
            };

            IEat[] eats = new IEat[]
            {
                new Manager(),
                new Worker()
                // Burada Robot nesnesi gelmez. 
            };
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager:IEat, ISalary,IWorker
    {
        public void Eat()
        {
            // Eat
        }

        public void GetSalary()
        {
            // Salary
        }

        public void Work()
        {
            // Work
        }
    }

    class Worker : IEat, ISalary, IWorker
    {
        public void Eat()
        {
            // Eat
        }

        public void GetSalary()
        {
            // Salary
        }

        public void Work()
        {
            // Work
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            // Work
        }
    }
}
