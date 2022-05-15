using System;

namespace ConsoleApp
{
    class FIO
    {
        protected string name;//2) Продемонстрировать применение модификатора protected
        protected string surname;
        protected string patronymic;
        public FIO() {}
        public FIO(string surname) {
            this.surname = surname;
        }
        public FIO(string name, string surname, string patronymic) {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public void Enter()
        {
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("Введите имя: ");
                    name = Console.ReadLine();
                    if (name == "") throw new Exception("Ошибка! Пустая строка.");
                    Console.Write("Введите фамилию: ");
                    surname = Console.ReadLine();
                    if (surname == "") throw new Exception("Ошибка! Пустая строка.");
                    Console.Write("Введите Отчество: ");
                    patronymic = Console.ReadLine();
                    if (patronymic == "") throw new Exception("Ошибка! Пустая строка.");
                    a = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Для продолжения нажмите ENTER.");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                }
            }
        }
        public virtual void Print()
        {
            if (!Equals(surname, null))
            {
                if (!Equals(name, null))
                    Console.Write($"Имя: {name}  ");
                Console.Write($"Фамилия: {surname}  ");
                if (!Equals(patronymic, null))
                    Console.Write($"Отчество: {patronymic}  ");
            }
            Console.WriteLine();
        }
    }
}