using System;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(String[] args)
        {
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
        }


    }
}