using System;
using System.IO;
namespace File_User_31._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name, surname, patronymic, year, month, day;
            //int size = 5;
            //string[] mas = new string[size];
            //DateTime[] dateTime = new DateTime[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Введите имя: ");
            //    name = Console.ReadLine();
            //    Console.Write("Введите фамилию: ");
            //    surname = Console.ReadLine();
            //    Console.Write("Введите отчество: ");
            //    patronymic = Console.ReadLine();
            //    Console.Write("Введите год: ");
            //    year = Console.ReadLine();
            //    Console.Write("Введите месяц: ");
            //    month = Console.ReadLine();
            //    Console.Write("Введите день: ");
            //    day = Console.ReadLine();
            //    mas[i] = name + " " + surname + " " + patronymic + " " + year + " " + month + " " + day + "\n";
            //    File.AppendAllText("text.txt", mas[i]);
            //}
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    string[] mas1 = mas[i].Split(" ");
            //    for(int j = 0;j<mas1.Length;j++)
            //    {
            //        Console.WriteLine(mas1[j]);
            //        dateTime[i] = new DateTime(Int32.Parse(mas1[3]), Int32.Parse(mas1[4]), Int32.Parse(mas1[5]));
            //    }
            //}
            //int i_max = 0, i_min = 0;
            //DateTime max = dateTime[0];
            //DateTime min = dateTime[0];
            //for (int i =1;i<size;i++)
            //{
            //    if(max < dateTime[i])
            //    {
            //        i_max = i;
            //    }
            //    if(min > dateTime[i])
            //    {
            //        i_min = i;
            //    }
            //}
            //File.AppendAllText("text_max_min_data.txt", "Max\n");
            //File.AppendAllText("text_max_min_data.txt", mas[i_max]);
            //File.AppendAllText("text_max_min_data.txt", "\nMin\n");
            //File.AppendAllText("text_max_min_data.txt", mas[i_min]);
            //Console.WriteLine(i_min);


            //Console.WriteLine(DateTime.Now.ToLongTimeString());


            DateTime dateTime = new DateTime(1972, 4, 29, 17, 10, 0, 0);
            Console.WriteLine(dateTime.TimeOfDay);

        }
    }
}
