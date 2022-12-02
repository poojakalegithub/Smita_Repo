using StudentInformation_CRUD_Using_ADO;
using System.Data.SqlClient;
using System.Xml.Linq;
class Program
{
    private static void Main(string[] args)
    {
        var logger = new Logger();
        SqlConnection sqlConnection;
        string connectionString = @"Data Source=PUN-NB-LE3B6L9\MSSQLSERVER01;Initial Catalog=Students;Integrated Security=True";
        sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        try
        {  
            logger.Log("Connection created");
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
                    string student_Name = Console.ReadLine();

                    Console.WriteLine("Enter Student Age");
                    string student_Age = Console.ReadLine();

                    string insertQuery = "insert into Student_Details(student_name,student_Age) values('" + student_Name + "'," + student_Age + ")";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Data inserted into table");
                    break;

                case 2:

                    //Retrive Data
                    string displayQuery = "SELECT * FROM Student_Details";
                    SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
                    SqlDataReader dataReader = viewCommand.ExecuteReader();
                    Console.WriteLine("Id--------Name--------Age");
                    
                    while (dataReader.Read())
                    {
                            Console.Write(dataReader.GetValue(0).ToString()+"        ");
                            Console.Write(dataReader.GetValue(1).ToString() + "        ");
                            Console.Write(dataReader.GetValue(2).ToString() + "        ");
                            Console.WriteLine("\n");
                    }
                    dataReader.Close();
                    break;

                case 3:

                    //Update student_Age by Id

                    int id;
                    int age;
                    Console.WriteLine("Enter id that you like to update");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter age of student to update");
                    age = int.Parse(Console.ReadLine());
                    string updateQuery = "UPDATE Student_Details SET student_Age = '" + age + "' WHERE ID = " + id + "";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                    updateCommand.ExecuteNonQuery();
                    break;

                case 4:

                    //delete data by Id
                    int idToDelete;
                    Console.WriteLine("Enter id that you like to Delete");
                    idToDelete = int.Parse(Console.ReadLine());
                    string deleteQuery = "DELETE FROM Student_Details WHERE ID = " + idToDelete + "";
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
            logger.Log("Connection closed");
            sqlConnection.Close();
        }
    }
}