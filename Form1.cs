// Omar Obeid 20201009
// Omar Khalil 20200889
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Project
{
    public partial class Form1 : Form
    {   
        // Doctor you might need to change the path in the
        // connection depending on where the repos folder is
        // placed on your laptop

        // The data in the database used is all real information..
        // You can contact these people on the records..

        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\admin\source\repos\Project\bin\Debug\Travelopedia.db;Pooling=true;FailIfMissing=false;Version=3");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SQLiteDataReader dr;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tpRegister;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = "Insert Into Passengers (FirstName, LastName, Email, Password, PhoneNumber, Nationality, Age)"
                + " Values (@FirstName, @LastName, @Email, @Password, @PhoneNumber, @Nationality, @Age)";

            cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail2.Text);
            cmd.Parameters.AddWithValue("Password", txtPassword2.Text);
            cmd.Parameters.AddWithValue("PhoneNumber", txtPhone.Text);
            cmd.Parameters.AddWithValue("Nationality", txtNation.Text);
            cmd.Parameters.AddWithValue("Age", numericUpDownAge.Value);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MessageBox.Show("Error! Record Not Added.");
            } else
            {
                MessageBox.Show("Record Added Successfully!");
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtEmail2.Text = string.Empty;
                txtPassword2.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtNation.Text = string.Empty;
                numericUpDownAge.Value = 2;
                this.tabControl1.SelectedTab = tpBooking;
            }

            conn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = "Select * from Passengers WHERE Email = @Email and Password = @Password";

            cmd.Parameters.AddWithValue("Email", txtEmail);
            cmd.Parameters.AddWithValue("Password", txtPassword);

            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("Wrong email or password!");
            } else
            {
                MessageBox.Show("Login successfull!");
                this.tabControl1.SelectedTab = tpBooking;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }

            dr.Close();
            conn.Close();
        }

        int price;
        DateTime dateOfDep;
        DateTime dateOfArr;
        private void dtpDateOfDep_ValueChanged(object sender, EventArgs e)
        {
            dateOfDep = dtpDateOfDep.Value;

            if (cboxFrom.SelectedIndex == cboxTo.SelectedIndex)
            {
                dateOfArr = dateOfDep.AddHours(1);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 1 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 0 && cboxFrom.SelectedIndex <= 3) && (cboxTo.SelectedIndex >= 0 && cboxTo.SelectedIndex <= 3))
            {
                dateOfArr = dateOfDep.AddHours(2);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 2 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 0 && cboxFrom.SelectedIndex <= 3) && (cboxTo.SelectedIndex >= 4 && cboxTo.SelectedIndex <= 5))
            {
                dateOfArr = dateOfDep.AddHours(3);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 3 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 0 && cboxFrom.SelectedIndex <= 3) && (cboxTo.SelectedIndex >= 6 && cboxTo.SelectedIndex <= 7))
            {
                dateOfArr = dateOfDep.AddHours(6);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 6 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 0 && cboxFrom.SelectedIndex <= 3) && (cboxTo.SelectedIndex == 8))
            {
                dateOfArr = dateOfDep.AddHours(12);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 12 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 4 && cboxFrom.SelectedIndex <= 5) && (cboxTo.SelectedIndex >= 0 && cboxTo.SelectedIndex <= 3))
            {
                dateOfArr = dateOfDep.AddHours(3);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 3 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 4 && cboxFrom.SelectedIndex <= 5) && (cboxTo.SelectedIndex >= 4 && cboxTo.SelectedIndex <= 5))
            {
                dateOfArr = dateOfDep.AddHours(1);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 1 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 4 && cboxFrom.SelectedIndex <= 5) && (cboxTo.SelectedIndex >= 6 && cboxTo.SelectedIndex <= 7))
            {
                dateOfArr = dateOfDep.AddHours(5);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 5 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 4 && cboxFrom.SelectedIndex <= 5) && (cboxTo.SelectedIndex == 8))
            {
                dateOfArr = dateOfDep.AddHours(12);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 12 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 6 && cboxFrom.SelectedIndex <= 7) && (cboxTo.SelectedIndex >= 0 && cboxTo.SelectedIndex <= 3))
            {
                dateOfArr = dateOfDep.AddHours(6);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 6 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 6 && cboxFrom.SelectedIndex <= 7) && (cboxTo.SelectedIndex >= 4 && cboxTo.SelectedIndex <= 5))
            {
                dateOfArr = dateOfDep.AddHours(5);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 5 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 6 && cboxFrom.SelectedIndex <= 7) && (cboxTo.SelectedIndex >= 6 && cboxTo.SelectedIndex <= 7))
            {
                dateOfArr = dateOfDep.AddHours(2);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 2 + 300;
            }
            else if ((cboxFrom.SelectedIndex >= 6 && cboxFrom.SelectedIndex <= 7) && (cboxTo.SelectedIndex == 8))
            {
                dateOfArr = dateOfDep.AddHours(12);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 12 + 300;
            }
            else if ((cboxFrom.SelectedIndex == 8) && (cboxTo.SelectedIndex >= 0 && cboxTo.SelectedIndex <= 3))
            {
                dateOfArr = dateOfDep.AddHours(12);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 12 + 300;
            }
            else if ((cboxFrom.SelectedIndex == 8) && (cboxTo.SelectedIndex >= 4 && cboxTo.SelectedIndex <= 5))
            {
                dateOfArr = dateOfDep.AddHours(12);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 12 + 300;
            }
            else if ((cboxFrom.SelectedIndex == 8) && (cboxTo.SelectedIndex >= 6 && cboxTo.SelectedIndex <= 7))
            {
                dateOfArr = dateOfDep.AddHours(12);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 12 + 300;
            }
            else
            {
                dateOfArr = dateOfDep.AddHours(4);
                txtArrivalDate.Text = dateOfArr.ToLongDateString();
                txtArrivalTime.Text = dateOfArr.ToLongTimeString();
                price = 15 * 4 + 300;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "Insert Into Flights (Source, Destination, DateOfDeparture, DateOfArrival, Price)"
                    + " Values (@Source, @Destination, @DateOfDeparture, @DateOfArrival, @Price)";

                cmd.Parameters.AddWithValue("Source", cboxFrom.Text);
                cmd.Parameters.AddWithValue("Destination", cboxTo.Text);
                cmd.Parameters.AddWithValue("DateOfDeparture", dateOfDep.ToString());
                cmd.Parameters.AddWithValue("DateOfArrival", dateOfArr.ToString());
                cmd.Parameters.AddWithValue("Price", price);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Error! Flight Not Booked.");
                }
                else
                {
                    MessageBox.Show("Flight Booked Successfully!");
                    cboxFrom.Text = string.Empty;
                    cboxTo.Text = string.Empty;
                    txtArrivalDate.Text = string.Empty;
                    txtArrivalTime.Text = string.Empty;
                }
            } catch (SQLiteException ex) 
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            } finally
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clboxBucketlist.Items.Add(txtBucketlist.Text);
            txtBucketlist.Text = string.Empty;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tpFlights;

            conn.Open();

            string strCmd = "SELECT * FROM Flights ORDER BY FlightNO";
            cmd = new SQLiteCommand(strCmd, conn);

            da = new SQLiteDataAdapter(strCmd, conn);

            ds = new DataSet();
            da.Fill(ds, "FlightNO");

            dataGridView1.DataSource = ds.Tables["FlightNO"].DefaultView;

            conn.Close();
        }
    }
}
