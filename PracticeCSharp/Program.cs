using PracticeCSharp.Assignments;
using System;
using System.Security.Cryptography.X509Certificates;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Choose Option to View Assignment.. \n 1. Assignment 1 \n 2. Assignment 2");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Assignment Number 1 Questions:");

                    Console.WriteLine("Q 1. Write a C# program that performs all string operations like COMPARE, CONCAT, SUBSTRING, REVERSE");

                    //creating object of StringOperations class
                    Assignments.StringOperations StringObj = new Assignments.StringOperations();
                    StringObj.concatStrings();

                    Console.WriteLine("_______________________________________________________");
                    StringObj.compareStrings();

                    Console.WriteLine("_______________________________________________________");
                    StringObj.findSubString();

                    Console.WriteLine("_______________________________________________________");
                    StringObj.reverse();


                    Console.WriteLine("Q 2. Write a C# program to validate an Email ID Using Custom logic");
                    //creating object of Emailvalidation class
                    Assignments.EmailValidation emailobj = new Assignments.EmailValidation();
                    emailobj.validateEmail();
                    Console.WriteLine("validate an Email ID Using regex");
                    emailobj.ValidateUsingRegex();

                    Console.WriteLine("Q 3. 3.\tWrite a C# program that demonstrates the use of Enums for countries – INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND");
                    //creating object of countriesEnum class
                    Assignments.countriesEnum enumobj = new Assignments.countriesEnum();
                    enumobj.showData();

                    Console.WriteLine("Q 4.Write a C# program which demoes the concept of OOPS ");

                    Console.Write("Empoyee Information: ");

                    //To take User input for employee data
                    Console.Write("Enter First name: ");
                    string Fname = Console.ReadLine();

                    Console.Write("Enter Last name: ");
                    string Lname = Console.ReadLine();

                    Console.Write("Enter age: ");
                    string val = Console.ReadLine();
                    //converting string into byte
                    byte age = Convert.ToByte(val);

                    Console.Write("Enter Job Title: ");
                    string jobTitle = Console.ReadLine();

                    Console.Write("Enter Salary: ");
                    string val2 = Console.ReadLine();

                    //converting string into decimal
                    decimal salary = Convert.ToDecimal(val2);

                    //Creating object of emplyee class and passing parameters
                    Assignments.Employee emp = new Assignments.Employee(Fname, Lname, age, jobTitle, salary);

                    //Creating object of vardemo class which is in PracticeCode folder
                    PracticeCode.vardemo var = new PracticeCode.vardemo();

                    //variable declaration
                    int num1 = 10;
                    int num2 = 20;
                    Console.WriteLine("Mathematical Operations");
                    //calling functions
                    int add = var.Add(num1, num2);
                    Console.WriteLine("Addition is:" + add);
                    int substract = var.Substract(num1, num2);
                    Console.WriteLine("Substraction is:" + substract);
                    int multiply = var.Multiply(num1, num2);
                    Console.WriteLine("Multiplication is:" + multiply);
                    int divide = var.Divide(num1, num2);
                    Console.WriteLine("Division is:" + divide);

                    Console.WriteLine("_______________________________________________________");
                    //Creating object
                    PracticeCode.ifelsedemo ifelseobj = new PracticeCode.ifelsedemo();
                    ifelseobj.FindGreaterNumber();

                    Console.WriteLine("_______________________________________________________");
                    //creating object 
                    PracticeCode.forloop forObj = new PracticeCode.forloop();
                    forObj.printTable();
                    
                    break;
                case 2:
                    Console.WriteLine("Assignment 2");

                    Console.WriteLine("Q 1. Write a C# program to validate an Email ID using – Using Regex");
                    //Creating object
                    Assignment2.ValidatioUsingRegex regexObj = new Assignment2.ValidatioUsingRegex();
                    regexObj.ValidateUsingRegex();

                    Console.WriteLine("2. Write a C# program that demonstrates NullReference, DivideByZero, StackOverFlow, Generic exceptions.\r\n");
                    //creating object
                    Assignment2.ErrorHandling errorObj = new Assignment2.ErrorHandling();

                    //Default Exceptions
                    errorObj.HandlingNullReferenceException();
                    Console.WriteLine("_______________________________________________________");

                    errorObj.HandlingDivideByZeroException();
                    Console.WriteLine("_______________________________________________________");

                    //User defined Exceptopn
                    Console.WriteLine("To Practice User Defined Exception");
                    Assignment2.UserDefinedException userObj = new Assignment2.UserDefinedException();
                    userObj.divide();
                    Console.WriteLine("_______________________________________________________");

                    Console.WriteLine("3. Write a C# Program to Display the Student Details using Select Clause LINQ.");
                    Assignment2.Student stdObj = new Assignment2.Student();
                    stdObj.StudentList();


                    Console.WriteLine("4. Write a C# Program to Read a Text File.");
                    //To Read File
                    Assignment2.ReadFile fileobj = new Assignment2.ReadFile();
                    fileobj.readfile();

                    Console.WriteLine("To sort Employees list based on salary");
                    //To sort Employees list based on salary
                    Assignment2.Employee empSort = new Assignment2.Employee();
                    empSort.sortEmp();

                    Console.WriteLine("5. Write a C# Program to sort a list of employees based on salary in descending order and whose department is XYZ \r\n");
                    Assignment2.EmployeeList empobj = new Assignment2.EmployeeList();
                    empobj.showEmployee();
                    Console.ReadLine();

                    Console.WriteLine("6.Write a C# Program to demonstrate the use of Generic classes and methods");
                    Assignment2.GenericClass<String, int> genericObj = new Assignment2.GenericClass<String, int>();
                    genericObj.showData("John", 20);
                    break;

                default:
                    Console.WriteLine("Choose correct option");
                    break;
            }
                


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
            
            */

            ////Creating object
            //Assignment2.ValidatioUsingRegex regexObj = new Assignment2.ValidatioUsingRegex();
            //regexObj.ValidateUsingRegex();
    
            ////creating object
            //Assignment2.ErrorHandling errorObj = new Assignment2.ErrorHandling();
            
            ////Default Exceptions
            //errorObj.HandlingNullReferenceException();
            //Console.WriteLine("_______________________________________________________");
            
            //errorObj.HandlingDivideByZeroException();
            //Console.WriteLine("_______________________________________________________");
            
            ////User defined Exceptopn
            //Assignment2.UserDefinedException userObj=new Assignment2.UserDefinedException();
            //userObj.divide();
            //Console.WriteLine("_______________________________________________________");

            ////To Read File
            //Assignment2.ReadFile fileobj=new Assignment2.ReadFile();    
            //fileobj.readfile();
                      
            ////To sort Employees list based on salary
            //Assignment2.Employee empSort=new Assignment2.Employee();
            //empSort.sortEmp();
            //Assignment2.EmployeeList empobj = new Assignment2.EmployeeList();
            //empobj.showEmployee();
            //Console.ReadLine();
            
            //Assignment2.Student stdObj = new Assignment2.Student();
            //stdObj.StudentList();

            //Assignment2.GenericClass<String,int> genericObj = new Assignment2.GenericClass<String,int>();
            //genericObj.showData("John",20);

            

        }
    }
}