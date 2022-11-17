﻿using System.Data.SqlClient;
using System.Xml.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        SqlConnection sqlConnection;
        string connectionString = @"Data Source=PUN-NB-LE3B6L9\MSSQLSERVER01;Initial Catalog=Students;Integrated Security=True";
        sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        try
        { 
            string answer;
            Console.WriteLine("Connection Established");
            do { 
            Console.WriteLine("Select the option\n 1. Create \n 2. Retrieve \n 3. Update \n 4. Delete ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //Insert data
                    Console.WriteLine("Enter Student name");
                    String student_Name = Console.ReadLine();

                    Console.WriteLine("Enter Student Age");
                    String student_Age = Console.ReadLine();

                    string insertQuery = "insert into Student_Details(student_name,student_Age) values('" + student_Name + "'," + student_Age + ")";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Data inserted into table");
                    break;

                case 2:

                    //Retrive Data
                    String displayQuery = "SELECT * FROM Student_Details";
                    SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
                    SqlDataReader dataReader = viewCommand.ExecuteReader();
                   
                    while (dataReader.Read())
                    {
                        Console.WriteLine("ID: " + dataReader.GetValue(0).ToString());
                        Console.WriteLine("Name: " + dataReader.GetValue(1).ToString());
                        Console.WriteLine("Age: " + dataReader.GetValue(2).ToString());
                    }
                    dataReader.Close();
                    break;

                case 3:

                    //Update student_Age by using Id

                    int id;
                    int age;
                    Console.WriteLine("Enter id that you like to update");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter age of student to update");
                    age = int.Parse(Console.ReadLine());
                    String updateQuery = "UPDATE Student_Details SET student_Age = '" + age + "' WHERE ID = " + id + "";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                    updateCommand.ExecuteNonQuery();
                    break;

                case 4:

                    //delete data by using Id
                    int idToDelete;
                    Console.WriteLine("Enter id that you like to Delete");
                    idToDelete = int.Parse(Console.ReadLine());
                    String deleteQuery = "DELETE FROM Student_Details WHERE ID = " + idToDelete + "";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Successfully deleted");
                    break;
                default:
                    Console.WriteLine("Choose correct option");
                    break;
            }
            Console.WriteLine("Do you want to continue? Enter No to exit");
             answer = Console.ReadLine();
        }while(answer != "No");
               
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            sqlConnection.Close();
        }
    }
}