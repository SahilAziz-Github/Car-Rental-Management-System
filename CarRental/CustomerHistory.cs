using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CarRental
{
    public partial class CustomerHistory : MetroForm
    {
        SqlCommand cmc;
        SqlConnection con;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        string customerhistory;
      
        public CustomerHistory()
        {
            //InitializeComponent();

        }

        public CustomerHistory(string customerhistory)
        {
            InitializeComponent();
            this.customerhistory = customerhistory;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");

            cmc = new SqlCommand("SELECT * from Booking where email=(@data)", con);
            cmc.Parameters.AddWithValue("@data", customerhistory);

            con.Open();

            SqlDataReader DR = cmc.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = DR;

            gridCustomerHistory.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
