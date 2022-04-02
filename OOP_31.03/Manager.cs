using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_31._03
{
    class Manager:Account
    {
        public int Salary { get; set; }
        public Manager(string name,string lastName, string login, string password,int salary): base(name,lastName,login,password)
        {
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\tSalary: {Salary}\n";
        }
        public void AddCustomer(Customer customer)
        {
            File.AppendAllText(Login + ".txt", customer.Name + " " + customer.LastName + " " + customer.Login + " " + customer.Password + " " + customer.Money + "\n");
        }
        public void AddSalesHistory(Produkt produkt)
        {
            File.AppendAllText("History" + Login + ".txt", produkt.Name + " " + produkt.Price + "\n");
        }
        public void ReadFileCustomer()
        {
           string file= File.ReadAllText(Login + ".txt");
            Console.WriteLine(file);
        }
        public void ReadFileSalesHistory()
        {
            string file = File.ReadAllText("History" + Login + ".txt");
            Console.WriteLine(file);
        }
    }
}
