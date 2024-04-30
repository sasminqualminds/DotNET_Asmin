using System.Data;

namespace AdapterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            DataSet ds = adapter.Data(); 
            foreach(DataRow dr in ds.Tables[0].Rows) {
                Console.WriteLine("Id :"+dr[0].ToString()+",name :"+  dr[1].ToString()+",salary :" + dr[2].ToString()+",age :" + dr[3].ToString());
            }
            adapter.Data();
           

           
        }
    }
}
