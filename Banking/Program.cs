using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {

            var sav1 = new Savings() {
                Id = 200, Desription = "1st Savings"
            };
            sav1.Deposit(100);
            sav1.CalculateAndPayInterest(1);
            Console.WriteLine(sav1);
            

           var acct1 = new Account() { 
            Id = 100, Balance = 100, Desription = "1st Account"
              };
              var acct2 = new Account() {
              Id = 200,
              Balance = 0,
               Desription = "2nd Account"
            };
            acct1.Deposit(100);
            Console.WriteLine(acct1);
            acct1.Withdraw(20);
            Console.WriteLine(acct1);
            // acct1.Deposit(-40);
            // Console.WriteLine(acct1);
            //acct1.Deposit(-50);
            //Console.WriteLine(acct1);
            acct1.Transfer(30, acct2);
        }
    }
}
