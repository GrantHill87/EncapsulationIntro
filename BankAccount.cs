using System;
using System.Collections.Generic;

namespace EncapsulationIntro
{
    internal class BankAccount
    {
        private double balance; //by creating a private access modifier, the value of 'balance' is protected from public access.

        public double CheckingAccount(double amount)
        {
            return balance;
        }
        public void Deposit(double amount)
        {
            Console.WriteLine($"Synthesizing your deposit of {amount, 0:c}"); //weird that the variable, 'amount' is able to emulate the user's input from another variable entirely (depositedAmount).
            balance = amount; //initializing amount to balance.
        }
        public void DepositVariant(double DepositAmount)       //only within the class that is titled 'balance' can balance be accessed.
        {
            balance += DepositAmount;
        }
        
        public double GetBalance() //method to be called for when we want to know what the user's balance is. We can do this without error, because 'balance' has already been defined
        {                          //by the variable, 'amount', and when the method 'Deposit' gets called by the main script, the variable 'amount' is implemented as a means of storing
            return balance;        //the information taken in by the variable, 'depositedAmount'. Perhaps it's like two different programs talking to eachother -- they call the same
        }                          //information different things.
        public void Withdrawal(double WithdrawalAmount) //both methods, 'Deposit', and 'Withdrawal', are written within the class of 'balance'.
        {                                               //therefore, they can access stored information pertaining to 'balance'.
            balance -= WithdrawalAmount;
        }
    }
}
