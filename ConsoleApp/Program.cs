using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FIO fio = new FIO("A", "Б", "В");
                Owner Alisher = new Owner();
                Alisher.EnterFIO();
                Alisher.PrintFIO();
                int N = 2;
                Shop[] shop = new Shop[N];
                for (int i = 0; i < N; i++)
                {
                    shop[i] = new Shop("1", "2", "3", "10:00-20:00");
                    shop[i].print();
                    shop[i].cloakShop();
                }
                Shop.CountOfShop();
                Warehouse home = new Warehouse();
                home.Enter();
                home.print();
                home.Poisk("AVS");
                int a = 20;
                int time = 0;
                home.cloakWarehouse(ref time, a);
                Console.WriteLine($"Время разгрузки {a} тонн товара: { time } минут");
                Boxoffice box = new Boxoffice(fio, 10, 10);
                Console.WriteLine($"Кол-во рабочих: {box.Workers}");
                box.Workers = 20;
                box++;
                box.Print();
                Boxoffice box1 = new Boxoffice(fio, 10, 10);
                box1 += box;
                box1.Print();
                box1.CloakBoxoffice(100);
                FIO Sur = new FIO("Klimov");
                Console.WriteLine($"Фамилия {Sur.Surname}.");
                Shop magaz = new Shop();
                magaz.Name = "Ashan";
                Console.WriteLine($"Название {magaz.Name}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для продолжения нажмите ENTER.");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            }
        }
    }
}