﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public byte[] Image { get; set; }
    }
}