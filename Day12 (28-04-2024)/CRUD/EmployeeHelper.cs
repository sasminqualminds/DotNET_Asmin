using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class EmployeeHelper
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Employee;Integrated Security=True;Pooling=False");
        SqlDataAdapter adapter;
        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
        public DataSet read()
        {
            DataSet dataSet = new DataSet();
            adapter = new SqlDataAdapter("Select * from EmpTable", sqlConnection);
            adapter.Fill(dataSet);
            return dataSet;
        }
 
        public void insert(DataRow newRow)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from EmpTable", sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet=new DataSet();
            adapter.Fill(dataSet);
            DataRow newRowCopy = dataSet.Tables[0].NewRow();
            newRowCopy.ItemArray = newRow.ItemArray;
            dataSet.Tables[0].Rows.Add(newRowCopy);
            adapter.Update(dataSet);
        }
 
        public void update(DataRow updatedRow)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM EmpTable", sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            // Find the DataRow to update using its primary key (Assuming Id is the primary key)
            DataRow[] foundRows = dataSet.Tables[0].Select($"Id = {updatedRow["Id"]}");
            if (foundRows.Length > 0)
            {
                // Update the values of the found DataRow
                foundRows[0].ItemArray = updatedRow.ItemArray;
            }
            // Update the database
            adapter.Update(dataSet);

            sqlConnection.Close();
        }
 
        public void delete(int idToDelete)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM EmpTable", sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            // Find the DataRow to delete using its primary key (Assuming Id is the primary key)
            DataRow[] foundRows = dataSet.Tables[0].Select($"Id = {idToDelete}");
            if (foundRows.Length > 0)
            {
                // Delete the DataRow from the DataSet
                foundRows[0].Delete();
            }
            // Update the database
            adapter.Update(dataSet);
            sqlConnection.Close();
        }
    }
}
