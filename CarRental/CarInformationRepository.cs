using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class CarInformationRepository 
    {
        SqlCommand cmd;
        SqlConnection con;

        internal int UpdateCarInformation(string Model, string Brand, int Rent, int Seat, string Type,int id)
        {
         
           string SqlUpdate = @"update CarInformation
                set Model = '" + Model + @"',
                Brand = '" + Brand + @"',
                Rent = '" + Rent + @"',
                Seat = '" + Seat + @"',
                Type = '" + Type + @"'
                where C_Id = '" + id + "';";
             DataAccess.ExecuteQuery(SqlUpdate);
            return 0;
        }
        internal int DeleteCarInformation(int Id)
        {
            int id = Id;
            string sql = "delete from CarInformation where C_Id = '" + id + "';";
            DataAccess.ExecuteQuery(sql);
            return 0;

        }
        internal int InsertCarInformation(int Id,string Model,string Brand,int Rent,int Seat,string Type)
        {
            string sql = @"insert into CarInformation
                values ('" + Id + "', '" + Model + "', '" + Brand + "', " + Rent + ", '" + Seat + "','" + Type + "');";

            DataAccess.ExecuteQuery(sql);
            return 0;
        }
     
    }
}
