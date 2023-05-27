using System;
using System.Net.Http;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dortİslem dortİslem = new Dortİslem(2, 3);
            //Console.WriteLine(dortİslem.Topla2());
            //Console.WriteLine(dortİslem.Topla(3, 4));

            // Ben buradakileri Reflection ile yapmak istiyorum , yani çalışma anında.

            var tip = typeof(Dortİslem);
            //Dortİslem dortİslem = (Dortİslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortİslem.Topla(4,5));
            //Console.WriteLine(dortİslem.Topla2());

            var instance = Activator.CreateInstance(tip,6,5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


        }
    }

    public class Dortİslem
    {
        private int _sayi1;
        private int _sayi2;
        public Dortİslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public Dortİslem()
        {

        }

        public int Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
