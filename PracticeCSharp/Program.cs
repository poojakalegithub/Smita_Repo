using PracticeCSharp.Assignments;
using System;
using System.Security.Cryptography.X509Certificates;

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
            //Creating object
            PracticeCode.ifelsedemo ifelseobj = new PracticeCode.ifelsedemo();
            ifelseobj.FindGreaterNumber();

            Console.WriteLine("_______________________________________________________");
            //creating object 
            PracticeCode.forloop forObj = new PracticeCode.forloop();
            forObj.printTable();

            Console.WriteLine("_______________________________________________________");
            //creating object of StringOperations class
            Assignments.StringOperations StringObj=new Assignments.StringOperations();
            StringObj.concatStrings();

            Console.WriteLine("_______________________________________________________");
            StringObj.compareStrings();

            Console.WriteLine("_______________________________________________________");
            StringObj.findSubString();

            Console.WriteLine("_______________________________________________________");
            StringObj.reverse();

            Console.WriteLine("_______________________________________________________");
            //creating object of Emailvalidation class
            Assignments.EmailValidation emailobj = new Assignments.EmailValidation();
            emailobj.validateEmail();
            emailobj.ValidateUsingRegex();

            Console.WriteLine("_______________________________________________________");
            //creating object of countriesEnum class
            Assignments.countriesEnum enumobj = new Assignments.countriesEnum();
            enumobj.showData();

            Console.WriteLine("_______________________________________________________");
            Console.Write("Empoyee Information: ");

            //To take User input for employee data
            Console.Write("Enter First name: ");
            string Fname = Console.ReadLine();

            Console.Write("Enter Last name: ");
            string Lname = Console.ReadLine();

            Console.Write("Enter age: ");
            string val = Console.ReadLine();
            //converting string into byte
            byte age=Convert.ToByte(val);

            Console.Write("Enter Job Title: ");
            string jobTitle = Console.ReadLine();

            Console.Write("Enter Salary: ");
            string val2 = Console.ReadLine();
            //converting string into decimal
            decimal salary = Convert.ToDecimal(val2);

            //Creating object of emplyee class and passing parameters
            Assignments.Employee emp = new Assignments.Employee(Fname,Lname,age,jobTitle,salary);
            Console.ReadLine();
            

            //Creating object
            Assignment2.ValidatioUsingRegex regexObj = new Assignment2.ValidatioUsingRegex();
            regexObj.ValidateUsingRegex();

            
            
        
            //creating object
            Assignment2.ErrorHandling errorObj = new Assignment2.ErrorHandling();
            
            //Default Exceptions
            errorObj.HandlingNullReferenceException();
            Console.WriteLine("_______________________________________________________");
            
            errorObj.HandlingDivideByZeroException();
            Console.WriteLine("_______________________________________________________");
            
            //User defined Exceptopn
            Assignment2.UserDefinedException userObj=new Assignment2.UserDefinedException();
            userObj.divide();
            Console.WriteLine("_______________________________________________________");

            //To Read File
            Assignment2.ReadFile fileobj=new Assignment2.ReadFile();    
            fileobj.readfile();
                      

            //To sort Employees list based on salary
            Assignment2.Employee empSort=new Assignment2.Employee();
            empSort.sortEmp();
            Assignment2.EmployeeList empobj = new Assignment2.EmployeeList();
            empobj.showEmployee();
            Console.ReadLine();
            
            Assignment2.Student stdObj = new Assignment2.Student();
            stdObj.StudentList();
            


            

        }
    }
}