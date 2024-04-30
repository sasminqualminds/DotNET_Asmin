using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;

namespace EmployeeDb
{
   
    internal class EmployeeHelper
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Employee;Integrated Security=True;Pooling=False");
        SqlCommand sqlCommand;
        SqlDataReader reader;

        // Add an employee record
        public void addEmployeeRecord(EmployeeData employee)
        {
            try
            {
                sqlConn.Open();
                string stringData = $"Insert into EmpTable values({employee.Id},'{employee.Name}',{employee.Salary},{employee.Age})";
                sqlCommand = new SqlCommand(stringData, sqlConn);
                int recs = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(recs + " Record added successfully in DB");
                
            }catch(Exception ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    Console.WriteLine("Error: An employee with the same ID already exists.");
                }
                else
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            sqlConn.Close();

        }

        // delete an employee record
        public void deleteEmployeeRecord(int id)
        {
            sqlConn.Open();
            string stringData = $"Delete FROM EmpTable where id={id}";
            sqlCommand = new SqlCommand(stringData, sqlConn);
            int recs = sqlCommand.ExecuteNonQuery();
            if(recs > 0)
            {
                Console.WriteLine(recs + " Record deleted successfully in DB");

            }
            else
            {
                Console.WriteLine($"No record found with id: {id}");
            }
            sqlConn.Close();
        }

        // display an employee record
        public void DisplayEmployeeRecord(int id)
        {
            sqlConn.Open();
            string stringData = $"Select * FROM EmpTable where id={id}";
            sqlCommand = new SqlCommand(stringData, sqlConn);
            reader=sqlCommand.ExecuteReader();           
            if (reader.Read())
            {
                Console.WriteLine("Employee id is:" + reader[0].ToString());
                Console.WriteLine("Employee name is:" + reader[1].ToString());
                Console.WriteLine("Employee salary is:" + reader[2].ToString());
                Console.WriteLine("Employee age is:" + reader[3].ToString());
            }
            else
            {
                Console.WriteLine("No Record Found");
            }           
            sqlConn.Close();
            reader.Close();
            
        }

        // display all employee records
        public void displayAllRecords()
        {
            sqlConn.Open();
            string stringData = $"Select * FROM EmpTable";
            sqlCommand = new SqlCommand(stringData, sqlConn);
            reader = sqlCommand.ExecuteReader();
            if(reader.HasRows) {
                while (reader.Read())
                {
                    Console.WriteLine($"Employee id is: {reader[0].ToString()}, name is: {reader[1].ToString()}, salary is {reader[2].ToString()} , age is: {reader[3].ToString()}");
                    //Console.WriteLine("Employee name is:" + reader[1].ToString());
                    //Console.WriteLine("Employee salary is:" + reader[2].ToString());
                    //Console.WriteLine("Employee age is:" + reader[3].ToString());
                }
            }
            else
            {
                Console.WriteLine("No Record Found");
            }
            sqlConn.Close();
            reader.Close();
        }

        // update an employee record
        public void updateEmployeeRecord(int id, EmployeeData employee) {
            sqlConn.Open();
            string stringData = $"UPDATE EmpTable SET Name = '{employee.Name}', Salary = {employee.Salary}, Age = {employee.Age} WHERE Id = {id}";
            sqlCommand = new SqlCommand(stringData, sqlConn);
            int recs = sqlCommand.ExecuteNonQuery();
            if(recs > 0)
            {
                Console.WriteLine(recs + " Record updated successfully in DB");
            }
            else
            {
                Console.WriteLine($"No record found id : {id}");
            }
            sqlConn.Close();
        }


    }
}
