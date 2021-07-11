using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CarRental
{
    public partial class Invoice : MetroForm
    {
        SqlCommand cmc;
        SqlCommand cmc1;
        
        SqlConnection con;

        string customeremail;
        public Invoice()
        {
           // InitializeComponent();
        }
        public Invoice(string customerEmail)
        {
            InitializeComponent();
            this.customeremail = customerEmail;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");

            cmc = new SqlCommand("select Name from Login where email = (@data)", con);
            cmc.Parameters.AddWithValue("@data", customeremail);
            con.Open();
          
            using (SqlDataReader readinfo = cmc.ExecuteReader())
            {
                while (readinfo.Read())
                {
                    string UName = readinfo["Name"].ToString();
                    this.labelNameU.Text = UName;
                }
            }
            con.Close();
            //cmc1 = new SqlCommand("select BookingID,DateTimen from Booking where Email =(@data1) AND nStatus = (@data)", con);
            cmc1 = new SqlCommand("select BookingID, DateTimen, Model, Brand, Rent FROM Booking B, CarInformation C where CarID = C_Id AND Email =(@data1) AND nStatus = (@data)", con);
            string temp = "Approved";
            cmc1.Parameters.AddWithValue("@data", temp);
            cmc1.Parameters.AddWithValue("@data1", customeremail);
            con.Open();
            using (SqlDataReader Udata = cmc1.ExecuteReader())
            {
                while (Udata.Read())
                {
                    string UBookId = Udata["BookingID"].ToString();
                    string UDate = Udata["DateTimen"].ToString();
                    string UModel = Udata["Model"].ToString();
                    string UBrand = Udata["Brand"].ToString();
                    string URent = Udata["Rent"].ToString();

                    this.labelDateU.Text = UDate;
                    this.labelBookingIDU.Text = UBookId;
                    this.labelBrandU.Text = UBrand;
                    this.labelCarModelU.Text = UModel;
                    this.labelRentU.Text = URent;
                }
            } 

            


        } 

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
