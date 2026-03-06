using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    internal class BankAccount
    {
        public string OwnerName { get; set; }

        public int AccountNumber { get; set; }

        public double Ballance {  get; set; }

        public BankAccount(string ownerName, int accountNumber, double ballance)
        {
            OwnerName = ownerName;
            AccountNumber = accountNumber;
            Ballance = ballance;
        }

        public void Deposit(double Amount)
        {
            Ballance = Ballance + Amount;
            Console.WriteLine("New balance: " + Ballance);

        }
        public void Withdraw(double Amount)
        {
            Ballance -= Amount;
            Console.WriteLine("New balance: " + Ballance);
        }

        public double GetBallance()
        { return Ballance; }

        public void PrintInfo()
        {
            Console.WriteLine(OwnerName + AccountNumber + Ballance);
        }


    }

}



