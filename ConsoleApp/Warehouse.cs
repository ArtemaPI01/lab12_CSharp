using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Warehouse
    {
        private string[] product;
        private int station;

        public Warehouse(string[] product, int station)
        {
            this.product = product;
            this.station = station;
        }

        public Warehouse(string[] product)
        {
            this.product = product;
        }
        public Warehouse() {
            product = new string[] { };
        }

        public string[] Product
        {
            set
            {
                product = value;
            }
            get { 
                return product; 
            }
        }

        public int Station
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    station = value;
            }
            get { return station; }
        }

        public void Enter()
        {
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("Введите товар:");
                    product = Console.ReadLine().Split(' ');
                    Console.Write("Введите кол-во пунктов приема: ");
                    station = Convert.ToInt32(Console.ReadLine());
                    if (station < 0) throw new Exception("Ошибка! Отрицательное число.");
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
            Console.Write($"Склад:\nТовар: ");
            if (product.Length > 0)
            {
                foreach (string element in product)
                    Console.Write($"{element} ");
            }
            else
                Console.Write($"пусто.");
            Console.WriteLine($"\nКол-во пунктов приема: {station}");
        }

        public void cloakWarehouse(ref int time, int x)
        {
            try
            {
                int i = 0;
                while (i < x)
                {
                    time += 15;
                    i += station;
                }
                if (time < 0) throw new Exception("Ошибка! Отрицательное число.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для продолжения нажмите ENTER.");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            }
        }

        public void Poisk(string str)
        {
            foreach (string element in product)
            {
                if(string.Compare(element, str) == 0)
                {
                    Console.WriteLine($"{str} есть на складе.");
                    return;
                }
            }
            Console.WriteLine($"{str} нет на складе.");       
        }
    }
}
