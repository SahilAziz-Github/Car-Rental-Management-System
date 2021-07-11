using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    
     public class DataAccess
    {
        private static SqlConnection sqcon;

        public static SqlConnection Sqcon
        {
            get
            {
                if (sqcon == null)
                {
                    sqcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");
                }
                else if(sqcon.State != ConnectionState.Open)
                {
                    sqcon.Open();
                }
                return sqcon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query,Sqcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static void ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            sqcom.ExecuteNonQuery();
            
        }
    }
}
