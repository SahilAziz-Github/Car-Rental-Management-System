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

    public partial class CustomerHome : MetroForm
    {
        SqlCommand cmd;
        SqlConnection con;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
       
        private string customerEmail;
        public CustomerHome()
        {
            // Do nothing.
        }
        public CustomerHome(string customerEmail)
        {
            InitializeComponent();
            this.customerEmail = customerEmail;
            ShowUserName();
        }

        private void ShowUserName()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");
            //Showing User Name on top left
            cmd = new SqlCommand("select Name from Login where email = (@data)", con);
            cmd.Parameters.AddWithValue("@data", this.customerEmail);
            con.Open();


            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string UName = oReader["Name"].ToString();
                    this.labelShow.Text = UName;
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            contextMenu.Show(buttonMenu, 0, buttonMenu.Height);
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from CarInformation where Model like '%" + this.textSearch.Text + "%';";
            this.PopulateGridViewCustomer(sql);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login LogOut2 = new Login();
            LogOut2.Show();
        }
        
        public void PopulateGridViewCustomer(string sql = "select * from CarInformation;")
        {
            
            this.Ds = DataAccess.GetDataSet(sql);

            this.gridCustomerHome.AutoGenerateColumns = true;
            this.gridCustomerHome.DataSource = this.Ds.Tables[0];
        }

        private void gridCustomerHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.gridCustomerHome.CurrentRow.Cells["C_Id"].Value.ToString();
            this.gridCustomerHome.CurrentRow.Cells["Model"].Value.ToString();
            this.gridCustomerHome.CurrentRow.Cells["Brand"].Value.ToString();
            this.gridCustomerHome.CurrentRow.Cells["Rent"].Value.ToString();
            this.gridCustomerHome.CurrentRow.Cells["Seat"].Value.ToString();
            this.gridCustomerHome.CurrentRow.Cells["Type"].Value.ToString();

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            string sql = " select * from CarInformation ; ";
            this.PopulateGridViewCustomer(sql);
        }

       

       

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CustomerProfile CustomerData = new CustomerProfile(customerEmail);
            CustomerData.Show();
            
            
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            this.buttonBook.Enabled = false;
            DateTime BookDate = this.buttonDateTime.Value;
            string C_Id = this.gridCustomerHome.CurrentRow.Cells["C_Id"].Value.ToString();


            BookingRepository BookCar = new BookingRepository();
            BookCar.BookCar(Convert.ToInt32(C_Id), BookDate, customerEmail);

            MessageBox.Show("Booking sent for Approval");


        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerHistory cHistory = new CustomerHistory(customerEmail);
            cHistory.Show();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            Invoice bill = new Invoice(customerEmail);
            bill.Show();
        }
    }
}
