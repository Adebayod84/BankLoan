using System;

namespace BankLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyInBankAccount = 1010;
            decimal costOfCar = 1000;
            bool requestForLoan = true;
            decimal illegibleLoanAmount = 510;
            if (moneyInBankAccount >= costOfCar)
            {
                Console.WriteLine("I can afford a car");
            }
            else if (requestForLoan && moneyInBankAccount + illegibleLoanAmount >= costOfCar)
            {
                Console.WriteLine("I can not afford a car due to not having enough money");
                Console.WriteLine("If I request for a loan, I will be able to afford a car");
            }
            else if (requestForLoan && moneyInBankAccount + illegibleLoanAmount >= costOfCar * 0.9m)
            {
                Console.WriteLine("I have about 90% of the fund needed to buy a car");
            }
            else if (requestForLoan && moneyInBankAccount + illegibleLoanAmount > costOfCar / 2)
            {
                Console.WriteLine("I have about 50% of the fund to buy a car");
            }
            else
            {
                Console.WriteLine("I do not have fund to buy a car");
            }
        }
    }
}
