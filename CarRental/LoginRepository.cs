using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class LoginRepository
    {
        SqlCommand cmd;
        SqlConnection con;

        internal int UpdatePassword(string PasswordChange,string NewPassword)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string SqlUpdate = @"update Login
                set Password = '" + NewPassword + @"'
                where Email = '" + PasswordChange + "';";
            //Updating User Password
            cmd = new SqlCommand("update Login set Password = (@data1) where email = (@data)", con);
            cmd.Parameters.AddWithValue("@data", PasswordChange);
            cmd.Parameters.AddWithValue("@data1", NewPassword);
            cmd.ExecuteNonQuery();

            return 0;
        }
    }
}
