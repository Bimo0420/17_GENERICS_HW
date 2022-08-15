using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class BankAccount<T>
    {
        public T Num { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        //public BankAccount (T num, double balance, string name) //конструктор //-1 вариант
        //{
        //    Num = num;
        //    Balance = balance;
        //    Name = name;
        //}

        public string GetInfo()
        {
            return $"{Num} {Balance} {Name}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета:");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T)); //!!

            Console.WriteLine("Введите баланс:");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();
           
        }
    }
}
