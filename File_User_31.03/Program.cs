using System;
using System.IO;
namespace File_User_31._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, patronymic, year, month, day;
            int size = 3;
            string[] mas = new string[size];
            DateTime[] dateTime = new DateTime[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter lastname: ");
                surname = Console.ReadLine();
                Console.Write("Enter patronymik: ");
                patronymic = Console.ReadLine();
                Console.Write("Enter year: ");
                year = Console.ReadLine();
                Console.Write("Enter month: ");
                month = Console.ReadLine();
                Console.Write("Enter day: ");
                day = Console.ReadLine();
                mas[i] = name + " " + surname + " " + patronymic + " " + year + " " + month + " " + day + "\n";
                File.AppendAllText("text.txt", mas[i]);
            }
            for (int i = 0; i < mas.Length; i++)
            {
                string[] mas1 = mas[i].Split(" ");
                for (int j = 0; j < mas1.Length; j++)
                {
                    dateTime[i] = new DateTime(Int32.Parse(mas1[3]), Int32.Parse(mas1[4]), Int32.Parse(mas1[5]));
                }
            }
            DateTime dateNow = DateTime.Now;
            int x = 0;
            int max = 0;
            int min = 0;
            for (int i = 1; i < size; i++)
            {
                if (dateNow.Subtract(dateTime[i]) > dateNow.Subtract(dateTime[x]))
                {
                    x++;
                    max = i;
                }
                else
                {
                    min = i;
                }
            }
            File.AppendAllText("text.txt", "Max:\n"+mas[max].ToString());
            File.AppendAllText("text.txt", "Min:\n"+mas[min].ToString());
        }
    }
}
