using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface IAddStar
    {
        // Kahve alan müşteriye yıldız eklenecek.
        void AddStar(Customer customer);
    }
}
