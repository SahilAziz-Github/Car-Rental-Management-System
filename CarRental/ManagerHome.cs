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
    public partial class ManagerHome : MetroForm 
    {
        SqlCommand cmd;
        SqlConnection con;

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public ManagerHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
        }









        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = this.gridManagerHome.CurrentRow.Cells["C_Id"].Value.ToString();
            
            
            try
            {
                //this.Da.ExecuteUpdateQuery(sql);
                // DataAccess.ExecuteQuery(sql);
                CarInformationRepository ObjectDel = new CarInformationRepository();
                ObjectDel.DeleteCarInformation(Convert.ToInt32(id));
                MessageBox.Show("Deletion Done.");
                this.PopulateGridViewManager();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CarInformationRepository Save = new CarInformationRepository();
            string sql = "select * from CarInformation where C_Id ='" + this.textID.Text + "';";
            //this.Ds = this.Da.ExecuteQuery(sql);
            this.Ds = DataAccess.GetDataSet(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                
                try
                {
                    
                    Save.UpdateCarInformation(this.textModel.Text, this.textBrand.Text, Convert.ToInt32(this.textRent.Text), Convert.ToInt32(this.textSeat.Text), this.textType.Text, Convert.ToInt32(this.textID.Text));
                    MessageBox.Show("Upgradation Done.");
                    this.PopulateGridViewManager();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                //sql = @"insert into CarInformation
                //values ('" + this.textID.Text + "', '" + this.textModel.Text + "', '" + this.textBrand.Text + "', " + this.textRent.Text + ", '" + this.textSeat.Text + "','" + this.textType.Text + "');";
                try
                {
                   // LoginRepository Insert = new LoginRepository();
                    Save.InsertCarInformation(Convert.ToInt32(this.textID.Text), this.textModel.Text, this.textBrand.Text, Convert.ToInt32(this.textRent.Text), Convert.ToInt32(this.textSeat.Text), this.textType.Text);
                    //this.Da.ExecuteUpdateQuery(sql);
                   // DataAccess.ExecuteQuery(sql);

                    MessageBox.Show("Insertion Done.");
                    this.PopulateGridViewManager();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void gridManagerHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textID.Text = this.gridManagerHome.CurrentRow.Cells["C_Id"].Value.ToString();
            this.textModel.Text = this.gridManagerHome.CurrentRow.Cells["Model"].Value.ToString();
            this.textBrand.Text = this.gridManagerHome.CurrentRow.Cells["Brand"].Value.ToString();
            this.textRent.Text = this.gridManagerHome.CurrentRow.Cells["Rent"].Value.ToString();
            this.textSeat.Text = this.gridManagerHome.CurrentRow.Cells["Seat"].Value.ToString();
            this.textType.Text = this.gridManagerHome.CurrentRow.Cells["Type"].Value.ToString();
        }

        public void PopulateGridViewManager(string sql = "select * from CarInformation;")
        {
            //this.Ds = this.Da.ExecuteQuery(sql);
            this.Ds = DataAccess.GetDataSet(sql);
            this.gridManagerHome.AutoGenerateColumns = true;
            this.gridManagerHome.DataSource = this.Ds.Tables[0];
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from CarInformation where Model like '%" + this.textSearch.Text + "%';";
            this.PopulateGridViewManager(sql);
        }

        

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            string sql = " select * from CarInformation ; ";
            this.PopulateGridViewManager(sql);

            // This is the manager grid view populator.
           

            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");
            var cmd = new SqlCommand("select * from Booking where nStatus = (@data)", con);
            string temp = "Pending";
            cmd.Parameters.AddWithValue("@data", temp);
            con.Open();

            SqlDataReader DR = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            dataGridViewBooking.DataSource = source;
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login LogOut1 = new Login();
            LogOut1.Show();
        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // string C_Id = this.dataGridViewBooking.CurrentRow.Cells["C_Id"].Value.ToString();
        }

       /* private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string C_Iden = this.dataGridViewBooking.CurrentRow.Cells["BookingID"].Value.ToString();
            

            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sahil\Downloads\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");
            var cmd = new SqlCommand("update Booking set nStatus = (@data) where BookingID = (@data2)", con);
            string temp = "Approved";
            cmd.Parameters.AddWithValue("@data", temp);
            cmd.Parameters.AddWithValue("@data2", C_Iden);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Booking Sent for Approval");
        }*/

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void textID_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            string C_Iden = this.dataGridViewBooking.CurrentRow.Cells["BookingID"].Value.ToString();


            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\project Backup\CarRental\CarRental.mdf;Integrated Security=True;Connect Timeout=30");
            var cmd = new SqlCommand("update Booking set nStatus = (@data) where BookingID = (@data2)", con);
            string temp = "Approved";
            cmd.Parameters.AddWithValue("@data", temp);
            cmd.Parameters.AddWithValue("@data2", C_Iden);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Booking Confirmed");

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBrand.Text = " ";
            this.textID.Text = " ";
            this.textModel.Text = " ";
            this.textRent.Text = " ";
            this.textSeat.Text = " ";
            this.textType.Text = " ";
            this.textSearch.Text = " ";
        }
    }
}
