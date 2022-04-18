using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Owner
    {
        private FIO fio;
        private int income;
        private int expenses;


        public Owner(FIO fio, int income, int expenses)
        {
            this.fio = fio;
            this.income = income;
            this.expenses = expenses;
        }

        public Owner(FIO fio)
        {
            this.fio = fio;
        }

        public Owner() {
            fio = new FIO();
        }

        public int Income
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    income = value;
            }
            get { return income; }
        }

        public FIO Fio
        {
            get { return fio; }
        }

        public int Expenses
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    expenses = value;
            }
            get { return expenses; }
        }

        public void enter()
        {
            bool a = true;
            while (a)
            {
                try
                {
                    fio.enter();
                    Console.Write("Введите доходы: ");
                    income = Convert.ToInt32(Console.ReadLine());
                    if (income < 0) throw new Exception("Ошибка! Отрицательное число.");
                    Console.Write("Введите расходы: ");
                    expenses = Convert.ToInt32(Console.ReadLine());
                    if (expenses < 0) throw new Exception("Ошибка! Отрицательное число.");
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
            Console.WriteLine("\nИнформация о владельце:\n");
            fio.print();
            int profit;
            profitOwner(out profit);
            Console.WriteLine($"Доходы: {income}  Расходы: {expenses} Прибыль: {profit}");
        }
        void profitOwner(out int profit)
        {
            profit = income - expenses;
        }
    }
}