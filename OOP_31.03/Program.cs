using System;

namespace OOP_31._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Ilya", "Shevchenko", "InkaShev", "Ilya2905");
            Manager manager1 = new Manager("Leon", "Sheva", "Leo444", "Lev", 1000);
            //Manager manager2 = new Manager("Alisa", "Hsevchuk", "Iva333", "Ivan444", 20000);
            //admin.AddManager(manager1);
            //admin.AddManager(manager2);
            //admin.ReadAllFile();
            //Account account = new Account("Ivan", "Butov", "Iva333", "Ivan444");
            //Console.WriteLine(manager1.ToString());
            //admin.ChangeLogin("Iva333", "Iva555");

            Customer customer1 = new Customer("Boris", "Filatov", "Fil777", "Filll555", 400);
            //Customer customer2 = new Customer("Boris", "Filatov", "Fil777", "Filll555", 400);
            Sugar sugar = new Sugar("Sugar", 50.60);
            customer1.Purchase(sugar);
            //customer2.Purchase(sugar);
            manager1.AddCustomer(customer1);
            manager1.AddSalesHistory(sugar);
            manager1.ReadFileCustomer();
            manager1.ReadFileSalesHistory();
            //manager1.AddCustomer(customer2);
        }
    }
}
