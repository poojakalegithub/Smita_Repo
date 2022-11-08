using PracticeCSharp.Assignments;
using System;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
            //variable declaration
            int num1 = 10;
            int num2 = 20;
            
            //Creating object of vardemo class which is in PracticeCode folder
            PracticeCode.vardemo var=new PracticeCode.vardemo();

            Console.WriteLine("Mathematical Operations");
            //calling functions
            int add=var.Add( num1,num2);
            Console.WriteLine("Addition is:"+add);
            int substract=var.Substract(num1,num2);
            Console.WriteLine("Substraction is:"+substract);
            int multiply=var.Multiply(num1,num2);
            Console.WriteLine("Multiplication is:"+multiply);
            int divide=var.Divide(num1,num2);
            Console.WriteLine("Division is:"+divide);

            Console.WriteLine("_______________________________________________________");

            PracticeCode.ifelsedemo ifelseobj = new PracticeCode.ifelsedemo();
            ifelseobj.FindGreaterNumber();

            Console.WriteLine("_______________________________________________________");

            PracticeCode.forloop forObj = new PracticeCode.forloop();
            forObj.printTable();

            Console.WriteLine("_______________________________________________________");

            Assignments.StringOperations StringObj=new Assignments.StringOperations();
            StringObj.concatStrings();

            Console.WriteLine("_______________________________________________________");
            StringObj.compareStrings();

            Console.WriteLine("_______________________________________________________");
            StringObj.findSubString();

            Console.WriteLine("_______________________________________________________");
            StringObj.reverse();

            Console.WriteLine("_______________________________________________________");
            Assignments.EmailValidation emailobj = new Assignments.EmailValidation();
            emailobj.validateEmail();

            Assignments.countriesEnum enumobj = new Assignments.countriesEnum();
            enumobj.showData();
            */
           
           List<BankDetails> bank = new List<BankDetails>();  
            while (true)
            {
                Console.Write(
                    "1. create account\n" +
                    "2. Check balance\n" +
                    "3. Deposit\n" +
                    "4. Withdraw\n");
                String operation=Console.ReadLine();
                Console.WriteLine("\n");

                if (operation == "1")
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Type of Account Saving/Current: ");
                    string type = Console.ReadLine();
                    Console.Write("Enter initial balance: ");
                    double initialBalance = double.Parse(Console.ReadLine());
                    bank.Add(new BankDetails(name, initialBalance));
                    Console.WriteLine("Bank Account Added!");
                    Console.ReadLine();
                }
                else if(operation == "2")
                {
                   // Console.WriteLine("welcome to Check Balance");
                    Console.Write("Enter name: ");
                    string nmChk = Console.ReadLine();
                    for (int ix = 0; ix < bank.Count; ix++)
                    {
                        if (bank[ix].name == nmChk)
                        {
                            Console.WriteLine("Account Found!\nName: {0}\nBalance: {1}", bank[ix].name, bank[ix].balance);
                        }
                    }
                    Console.ReadLine();
                }
                else if (operation == "3")
                {
                    Console.WriteLine("Deposit");
                }
                else if(operation =="4")
                {
                        Console.WriteLine("Withdraw");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    Console.ReadLine();
                }
                
                
            }


            
        }
    }
}