using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_31._03
{
    class Produkt
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Produkt()
        {
            Name = "";
            Price = 0;
        }
        public Produkt(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}\tPrice: {Price}\n";
        }
    }
}
