using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Shop
    {
        private static int counter;
        private string name;
        private string type;
        private string street;
        private string time;

        public Shop()
        {
            counter++;
        }

        public Shop(string name, string type, string street, string time)
        {
            counter++;
            this.name = name;
            this.type = type;
            this.street = street;
            this.time = time;
        }

        public Shop(string time)
        {
            counter++;
            this.time = time;
        }

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        } 

        public static void CountOfShop()
        {
            Console.WriteLine($"Кол-во магазинов: {counter}.\n");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public void enter()
        {
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("Введите название:");
                    name = Console.ReadLine();
                    if (name == "") throw new Exception("Ошибка! Пустая строка.");
                    Console.Write("Введите тип: ");
                    type = Console.ReadLine();
                    if (type == "") throw new Exception("Ошибка! Пустая строка.");
                    Console.Write("Введите улицу: ");
                    street = Console.ReadLine();
                    if (street == "") throw new Exception("Ошибка! Пустая строка.");
                    Console.Write("Введите время: ");
                    time = Console.ReadLine();
                    if (time == "") throw new Exception("Ошибка! Пустая строка.");
                    a = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Для продолжения нажмите ENTER.");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                }
            }
        }
        public void print()
        {
            if (!Equals(time, null))
            {
                if (!Equals(name, null))
                    Console.Write($"Название: {name}  ");
                if (!Equals(type, null))
                    Console.Write($"Тип: {type}  ");
                if (!Equals(street, null))
                    Console.Write($"  Улица: {street}  ");
                Console.Write($"Часы работы: {time}\n");
            }
            else
                Console.WriteLine("Нет информации о магазине.\n");
        }
        public void cloakShop()
        {
            try
            {
                string[] subs = time.Split(':', '-');
                int a = Convert.ToInt32(subs[2]) - Convert.ToInt32(subs[0]);
                int b = Convert.ToInt32(subs[3]) - Convert.ToInt32(subs[1]);
                if (b < 0)
                {
                    b+=60;
                    a--;
                }
                if (a > 24 || a < 0)
                    throw new Exception("Ошибка! Неправильно написано время.");
                Console.WriteLine($"Часы работы: {time}\nЧасы: {a}    Минуты: {b}");
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
