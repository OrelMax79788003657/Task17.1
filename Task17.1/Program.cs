using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task17._1
{
    public class PersonalBankAccount : BankAccount<string>
    {
        public PersonalBankAccount(string num, float bal, string fcs) : base(num, bal, fcs)
        {
        }
    }
    public class DepositBankAccount : BankAccount<int>
    {
        public DepositBankAccount(int num, float bal, string fcs) : base(num, bal, fcs)
        {
        }
    }
    public class CommercialBankAccount : BankAccount<float>
    {
        public CommercialBankAccount(float num, float bal, string fcs) : base(num, bal, fcs)
        {
        }
    }
    public class BankAccount<T>
    {
        T number { get; set; }
        float balanse { get; set; }
        string FCs { get; set; }

        public BankAccount(T num, float bal, string fcs)
        {
            this.number = num;
            this.balanse = bal;
            this.FCs = fcs;
        }
        public void GetParams()
        {
            Console.WriteLine($"Номер счета: {number}\nФИО: {FCs}\nБаланс: {balanse}");
        }
        public void SetParams(T num, float bal, string fcs)
        {
            this.number = num;
            this.balanse = bal;
            this.FCs = fcs;
            Console.WriteLine($"Параметры счета успешно установлены!");
        }
    }

    internal class Program
    {
        static void Main()
        {
            PersonalBankAccount personal = new PersonalBankAccount("abcd", 1000, "Воробей В.");
            DepositBankAccount deposit = new DepositBankAccount(123456789, 10000, "Голубь Г.");
            CommercialBankAccount commercial = new CommercialBankAccount(0.5f, 1000000, "Орел М.");

            Console.WriteLine("\nПервый пользователь:");
            personal.GetParams();
            personal.SetParams("abcd", 1000, "Воробей В.");
            personal.GetParams();

            Console.WriteLine("\nВторой пользователь:");
            deposit.GetParams();
            deposit.SetParams(123456789, 10000, "Голубь Г.");
            deposit.GetParams();

            Console.WriteLine("\nТретий пользователь:");
            commercial.GetParams();
            commercial.SetParams(0.5f, 1000000, "Орел М.");
            commercial.GetParams();

            Console.ReadKey();
        }

    }
}
