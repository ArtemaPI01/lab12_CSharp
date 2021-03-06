using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Owner : FIO
    {
        private int income;
        private int expenses;
        public Owner(string name, string surname, string patronymic, int income, int expenses) 
            :base(name, surname, patronymic)//4) Продемонстрировать в конструкторе производного класса с параметрами вызов конструктора базового класса
        {

            this.income = income;
            this.expenses = expenses;
        }
        public Owner() : base() { }
        public Owner(string surname) : base(surname) {}
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
        public void Enter(FIO fio)
        {
            bool a = true;
            while (a)
            {
                try
                {
                    name = fio.Name;
                    name = fio.Surname;
                    name = fio.Patronymic;
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
        public override void Print()//7) Придумать разумное использование виртуальных функций и создать их в вашем проекте.
        {
            Console.WriteLine("\nИнформация о владельце:\n");
            base.Print();
            int profit;
            ProfitOwner(out profit);
            Console.WriteLine($"Доходы: {income}  Расходы: {expenses} Прибыль: {profit}");
        }
        public void ProfitOwner(out int profit)
        {
            profit = income - expenses;
        }
    }
}