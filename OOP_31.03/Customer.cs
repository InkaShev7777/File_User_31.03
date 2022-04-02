using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_31._03
{
    class Customer: Account
    {
        public double Money { get; set; }
        public Customer(string name,string lastname,string login,string password,double money):base(name,lastname,login,password)
        {
            Money = money;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Money: {Money}";
        }
        public void Purchase(Produkt produkt)
        {
            if(Money> produkt.Price)
            {
                Money -= produkt.Price;
                Console.WriteLine(produkt.ToString());
            }
            else
            {
                Console.WriteLine("You dont have much money!!!\n");
            }
        }
    }
}
