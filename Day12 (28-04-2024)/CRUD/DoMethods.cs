using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    internal class DoMethods
    {
        EmployeeHelper employeeHelper=new EmployeeHelper();
        
        // Getting data from database to dataset
        public DataSet doRead()
        {           
                DataSet ds=employeeHelper.read();
                Console.WriteLine("Records in DataSet");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine("Id :" + dr[0].ToString() + ",name :" + dr[1].ToString() + ",salary :" + dr[2].ToString() + ",age :" + dr[3].ToString());
                }
                return ds;            
        }

        // getting data from database into dataSet and adding a row in dataSet and inserting the new row in database
        public void doAdd()
        {
            try
            {
                Console.WriteLine("Current employees:");
                DataSet ds = doRead();
                // Add a new record to the DataSet
                DataRow newRow = ds.Tables[0].NewRow();
                Console.WriteLine("\nEnter details for the new employee:");
                Console.Write("Enter employee ID: ");
                newRow["Id"] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter employee name: ");
                newRow["Name"] = Console.ReadLine();
                Console.Write("Enter employee salary: ");
                newRow["Salary"] = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter employee age: ");
                newRow["Age"] = Convert.ToInt32(Console.ReadLine());
                // Add the new record to the DataSet
                employeeHelper.insert(newRow);
                Console.WriteLine("Added into dataBase");
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

        // getting data from database into dataSet and updating a row in dataSet and changing row in database
        public void doUpdate()
        {
            Console.Write("Enter the ID of the employee to update: ");
            int idToUpdate = Convert.ToInt32(Console.ReadLine());

            DataSet ds = doRead();
            DataRow[] rowsToUpdate = ds.Tables[0].Select($"Id = {idToUpdate}");
            if (rowsToUpdate.Length > 0)
            {
                Console.WriteLine("Enter updated details for the employee:");
                Console.Write("Enter employee name: ");
                rowsToUpdate[0]["Name"] = Console.ReadLine();
                Console.Write("Enter employee salary: ");
                rowsToUpdate[0]["Salary"] = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter employee age: ");
                rowsToUpdate[0]["Age"] = Convert.ToInt32(Console.ReadLine());
                employeeHelper.update(rowsToUpdate[0]);
                Console.WriteLine("Record updated successfully.");
            }
            else
            {
                Console.WriteLine($"No employee found with ID: {idToUpdate}");
            }
        }

        // getting data from database into dataSet and deleting a row in dataSet and changing or deleting the row in database
        public void doDelete()
        {
            Console.Write("Enter the ID of the employee to delete: ");
            int idToDelete = Convert.ToInt32(Console.ReadLine());

            DataSet ds = doRead();
            DataRow[] rowsToDelete = ds.Tables[0].Select($"Id = {idToDelete}");
            if (rowsToDelete.Length > 0)
            {
                // Delete the DataRow from the DataSet
                rowsToDelete[0].Delete();
                // Update the database
                employeeHelper.delete(idToDelete);
                Console.WriteLine("Record deleted successfully.");
            }
            else
            {
                Console.WriteLine($"No employee found with ID: {idToDelete}");
            }
        }
    }
}
