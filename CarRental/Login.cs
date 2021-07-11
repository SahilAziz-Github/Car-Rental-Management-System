using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CarRental
{
    public partial class Login : MetroForm
    {
       SqlCommand cmd;
        SqlConnection con;
        private DataSet DS { get; set; }
       // private SqlConnection sqlcon;
        public Login()
        {
            InitializeComponent();
        }


        private void buttonSignin_Click(object sender, EventArgs e)
        {
            Signin sign = new Signin();
            sign.Show();
            this.Hide();

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");



            cmd = new SqlCommand("SELECT * from Login", con);
            //cmd.Parameters.AddWithValue("@idid", IdBox.Text);
            //cmd.Parameters.AddWithValue("@pass", PassBox.Text);
            con.Open();
            bool flag = false;
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string uId = oReader["Email"].ToString();
                    string uPass = oReader["Password"].ToString();
                    string Admin = oReader["Email"].ToString();
                    if (uId.Equals(this.textEmail.Text) && uPass.Equals(this.textPassword.Text))
                    {
                        flag = true;
                        if (Admin == "s@gmail.com")
                        {
                            this.Hide();
                            ManagerHome MgHome = new ManagerHome();
                            MgHome.Show();
                        }
                        else
                        {
                            this.Hide();
                            //CustomerHome CsHome = new CustomerHome(this.textEmail.Text);
                            CustomerProfile CsProfile = new CustomerProfile(this.textEmail.Text);
                            CustomerHome CsHome = new CustomerHome(this.textEmail.Text);
                            CsHome.Show();
                        }
                    }

                }
                if (!flag)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (textPassword.PasswordChar == '✹') textPassword.PasswordChar = '\0';
            else textPassword.PasswordChar = '✹';
        }

        private void buttonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (textPassword.PasswordChar == '✹') textPassword.PasswordChar = '\0';
            else textPassword.PasswordChar = '✹';
        }
    }
}
