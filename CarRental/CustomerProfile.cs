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
    public partial class CustomerProfile : MetroForm
    {
        SqlCommand cmc;
        SqlConnection con;

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        string customerEmail;
        public CustomerProfile()
        {
            // Do nothing.
        }
        public CustomerProfile(string customeremail)
        {
            InitializeComponent();
            customerEmail = customeremail;
            //string sql = "select Name,Designation,Password from login where email ='" + customerEmail + "';";
            // DataAccess.ExecuteQuery(sql);

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");

            

            cmc = new SqlCommand("select Name,Designation,Password from Login where email = (@data)", con);
            cmc.Parameters.AddWithValue("@data", customerEmail);
            con.Open();
            //SqlDataReader Pr = cmc.ExecuteReader();


            
            using (SqlDataReader oReader = cmc.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string UName = oReader["Name"].ToString();
                    string UPassword = oReader["Password"].ToString();


                    this.labelUserName.Text = UName;
                    this.labelShowEmail.Text = customerEmail;
                    this.labelShowName.Text = UName;
                    this.labelShowPassword.Text = UPassword;
                }
            }


            /*
            private void labelUserName_Click(object sender, EventArgs e)
            {
                string sql = "select Name from Login where Email = '" + this.textEmail.Text + "'";

            }
            */


        }

       

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChange PassChange = new PasswordChange(customerEmail);
            PassChange.Show();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
