﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramewokDemo
{
    public class Product
    {
        public int ProductId { get; set; } // PrimaryKey
        public int CategoryId { get; set; } // ForeignKey
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
