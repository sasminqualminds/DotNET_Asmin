using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdapterExample
{

    internal class Adapter
    {
        SqlConnection sqlConn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Employee;Integrated Security=True;Pooling=False");
        SqlDataAdapter adapter;
        DataSet ds=new DataSet();
        public DataSet Data()
        {
            
            adapter = new SqlDataAdapter("Select * from EmpTable",sqlConn);
            adapter.Fill(ds);
            return ds;
        }


    }
}
