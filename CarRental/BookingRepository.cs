using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental
{   
    class BookingRepository
    {
        SqlCommand cmd;
        SqlConnection con;

        internal int BookCar(int C_Id,DateTime BookDate , string customerEmail)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            cmd = new SqlCommand("insert into Booking(CarID, Email, nStatus, DateTimen) values( @c, @e, @s, @d)", con);

            cmd.Parameters.AddWithValue("@c", C_Id);
            cmd.Parameters.AddWithValue("@e", customerEmail);
            cmd.Parameters.AddWithValue("@s", "Pending");
            cmd.Parameters.AddWithValue("@d", BookDate);
            cmd.ExecuteNonQuery();

            return 0;
        }

    }
}
