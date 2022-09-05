using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();

            Console.WriteLine("This is an introduction to encapsulation.");
            Console.WriteLine();
            Console.WriteLine("We will write a script that stores a user's input, and protects it from being seen by anyone else.");
            Console.WriteLine();
            Console.WriteLine("Welcome to your local bank ATM. How much do you wish to deposit today?");
            Console.WriteLine();
            double depositedAmount = double.Parse(Console.ReadLine()); //user input gets stored in newly assigned variable.
            Console.WriteLine();
            account1.Deposit(depositedAmount); //previously defined script (method) in our other class file gets called, and runs. It is also taking the information
            double yourBalance = account1.GetBalance(); //from the user and allowing it to be stored on both programs.
            Console.WriteLine(); //in the above line, we take the stored information from the user and initialize plus assign it to another variable, that also uses (.) notation to call another predefined method which can then be used to print it.
            Console.WriteLine($"The remaining balance in your account is now {yourBalance, 0:c}"); //now, we want to showcase to the user what their remaining balance is.
            Console.WriteLine();
            //account1.Deposit(400);


            //account1.Withdrawal(100);

            //account.balance(); if we try to implement the values stored within the class, 'balance', visual studio will tell you that such a class
        }   //is not 'invocable', or usable, and this is because its access modifier has been set to private.
    }
}
