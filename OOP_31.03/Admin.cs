using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_31._03
{
    class Admin : Account
    {
        public int Size { get; set; }
        public Manager[] Arr { get; set; }
        public string Path { get; set; }
        public Admin()
        {
            Size = 1;
            this.Arr = new Manager[Size];
        }
        public Admin(string name,string lastName,string login,string password):base(name,lastName,login,password)
        {
            Path = login;
            Size = 0;
            this.Arr = new Manager[Size];
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nPath:{Path}.txt";
        }
        public void AddManager(Manager manager)
        {
            File.AppendAllText(Path + ".txt", manager.Name+" "+manager.LastName + " " + manager.Login + " " + manager.Password + " " + manager.Salary+"\n");
        }
        public void ReadAllFile()
        {
            foreach (string per in File.ReadLines(Path+".txt"))
            {
                string[] mas = per.Split(" ");
                string name = mas[0];
                string lastname = mas[1];
                string login = mas[2];
                string password = mas[3];
                int sal = Int32.Parse(mas[4]);
                Manager man = new Manager(name, lastname, login, password, sal);
                Manager[] tmp = new Manager[Size + 1];
                for(int i=0;i<Size;i++)
                {
                    tmp[i] = Arr[i];
                }
                tmp[Size] = man;
                Arr = tmp;
                Size++;
            }
            for(int i=0;i<Size;i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
        public void ChangeLogin(string login,string ch_login)
        {
            ReadAllFile();
            for(int i=0;i<Size;i++)
            {
                if(Arr[i].Login == login)
                {
                    Arr[i].Login = ch_login;
                }
            }
            File.Delete(Path + ".txt");
            for (int i = 0; i < Size; i++)
            {
                File.AppendAllText(Path + ".txt", Arr[i].Name + " " + Arr[i].LastName + " " + Arr[i].Login + " " + Arr[i].Password + " " + Arr[i].Salary + "\n");
            }
        }
    }
}
