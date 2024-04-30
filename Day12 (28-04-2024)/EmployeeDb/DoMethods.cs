using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDb
{
    internal class DoMethods
    {
        private EmployeeHelper employeeHelper;

        public DoMethods(EmployeeHelper employeeHelper)
        {
            this.employeeHelper = employeeHelper;
        }

        public void doAdd(EmployeeData employee)
        {
            try
            {
                string query = $"INSERT INTO EmpTable VALUES ({employee.Id}, '{employee.Name}', {employee.Salary}, {employee.Age})";
                employeeHelper.ExecuteNonQuery(query);
                Console.WriteLine("Record added successfully in DB");
            }

            catch (Exception ex)
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
        }

        public void doDelete(int id)
        {
            string query = $"DELETE FROM EmpTable WHERE id = {id}";

            int recs = employeeHelper.ExecuteNonQuery(query);
            if (recs > 0)
            {
                Console.WriteLine(recs + " Record deleted successfully in DB");

            }
            else
            {
                Console.WriteLine($"No record found with id: {id}");
            }
        }

        public void doDisplayRecord(int id)
        {
            string query = $"SELECT * FROM EmpTable WHERE id = {id}";
            DataTable dataTable = employeeHelper.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                Console.WriteLine($"Employee id: {row["id"]}, Name: {row["name"]}, Salary: {row["salary"]}, Age: {row["age"]}");
            }
            else
            {
                Console.WriteLine("No Record Found");
            }
        }

        public void doDisplayAllRecords()
        {
            string query = "SELECT * FROM EmpTable";
            DataTable dataTable = employeeHelper.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"Employee id: {row["id"]}, Name: {row["name"]}, Salary: {row["salary"]}, Age: {row["age"]}");
            }
        }

        public void doUpdateRecord(int id, EmployeeData employee)
        {
            string query = $"UPDATE EmpTable SET Name = '{employee.Name}', Salary = {employee.Salary}, Age = {employee.Age} WHERE Id = {id}";
            int recs = employeeHelper.ExecuteNonQuery(query);
            if (recs > 0)
            {
                Console.WriteLine(recs + " Record updated successfully in DB");
            }
            else
            {
                Console.WriteLine($"No record found id : {id}");
            }
        }
    }
}
