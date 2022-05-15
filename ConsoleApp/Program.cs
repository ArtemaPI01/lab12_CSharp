using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FIO fio = new FIO();
                fio.Enter();
                Owner Alisher = new Owner();
                Alisher.Enter(fio);//3) Продемонстрировать перегрузку метода базового класса в производном классе 
                Alisher.Print();
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
                Warehouse home2 = (Warehouse)home.Clone();//мелкое копирование
                Warehouse home3 = (Warehouse)home.Clone();//глубокое копирование
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
                Shape[] shape = new Shape[2];
                shape[0] = new Rectangle(3, 3);
                shape[1] = new Circle(3);
                for (int i=0; i <2 ;i++)
                    shape[i].PrintShape();
                IShape[] ishape = new IShape[2];
                ishape[0] = new Rectangle2(3, 3);
                ishape[1] = new Circle2(3);
                for (int i = 0; i < 2; i++)
                    shape[i].PrintShape();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для продолжения нажмите ENTER.");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            }
        }
    }
}