using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing.Printing; //??

namespace N1 //Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного различными типам. Заполнить его поля и вывести информацию об экземпляре класса на печать.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите номер счета:");   //1 вариант
            //int numInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите баланс:");
            //double balance1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите имя:");
            //string name1 = Console.ReadLine();
            //BankAccount<int> bankAccount1 = new BankAccount<int>(numInt, balance1, name1);
            //Console.WriteLine(bankAccount1.GetInfo());

            //Console.WriteLine("Введите номер счета:");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите баланс:");
            //double balance2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите имя:");
            //string name2 = Console.ReadLine();
            //BankAccount<string> bankAccount2 = new BankAccount<string>(numString, balance2, name2);
            //Console.WriteLine(bankAccount2.GetInfo());


            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Input();
            Console.WriteLine(bankAccount1.GetInfo());

            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Input();
            Console.WriteLine(bankAccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
