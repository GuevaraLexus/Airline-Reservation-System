using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class frmAdminHome : Form
    {
        private MySqlCommand command;
        private MySqlConnection connection;
        private string myconnection = "Server=localhost; Database=dbluxspaceairways; Uid=root; Password=";

        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                Console.Write("Logout");
            }
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(myconnection);
            connection.Open();

            string from_country = cmbFrom.SelectedItem?.ToString();
            string to_country = cmbTo.SelectedItem?.ToString();
            string capacity = txtCapacity.Text;
            string price = txtPrice.Text;

            int timehours = (int)numericTimeHours.Value;
            int timeminutes = (int)numericTimeMinutes.Value;

            string time = timehours.ToString("D2") + " : " + timeminutes.ToString("D2");

            DateTime depart = dateDepart.Value;
            DateTime departWithoutTime = new DateTime(depart.Year, depart.Month, depart.Day, 0, 0, 0);
            string departString = departWithoutTime.ToString("MM/dd/yyyy");

            try
            {
                if (string.IsNullOrEmpty(from_country) || string.IsNullOrEmpty(to_country) || string.IsNullOrEmpty(capacity) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(departString))
                {
                    MessageBox.Show("Please fill up all the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (radioEconomy.Checked)
                    {
                        string travel_class = "Economy Class";

                        string sql = "INSERT INTO tbl_flights (flight_class, from_country, to_country, date, time, capacity, price) VALUES " +
                       "('" + travel_class + "','" + from_country + "', '" + to_country + "', '" + departString + "', '" + time + "','" + capacity + "' , '" + price + "')";

                        command = new MySqlCommand(sql, connection);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cmbFrom.SelectedIndex = -1;
                            cmbTo.SelectedIndex = -1;
                            txtCapacity.Clear();
                            txtPrice.Clear();

                            radioEconomy.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the flight.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else if (radioBusinessClass.Checked)
                    {
                        string travel_class = "Business Class";

                        string sql = "INSERT INTO tbl_flights (flight_class,from_country, to_country, date, time, capacity, price) VALUES " +
                       "('" + travel_class + "','" + from_country + "', '" + to_country + "', '" + departString + "', '" + time + "','" + capacity + "' , '" + price + "')";

                        command = new MySqlCommand(sql, connection);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cmbFrom.SelectedIndex = -1;
                            cmbTo.SelectedIndex = -1;
                            txtCapacity.Clear();
                            txtPrice.Clear();

                            radioBusinessClass.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the flight.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else if (radioFirstClass.Checked)
                    {
                        string travel_class = "First Class";

                        string sql = "INSERT INTO tbl_flights (flight_class,from_country, to_country, date, time, capacity, price) VALUES " +
                       "('" + travel_class + "','" + from_country + "', '" + to_country + "', '" + departString + "', '" + time + "','" + capacity + "' , '" + price + "')";

                        command = new MySqlCommand(sql, connection);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cmbFrom.SelectedIndex = -1;
                            cmbTo.SelectedIndex = -1;
                            txtCapacity.Clear();
                            txtPrice.Clear();

                            radioFirstClass.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the flight.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choice a travel class.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error: " + ex.Message);
            }
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            frmAdminFlights adminflight = new frmAdminFlights();
            adminflight.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmAdminPayment adminpayment = new frmAdminPayment();
            adminpayment.Show();
            this.Hide();
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            frmAdminPassenger adminpassengers = new frmAdminPassenger();
            adminpassengers.Show();
            this.Hide();
        }

        private void frmAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure the connection is closed when the form is closing.
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true; 
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true; 
            }
        }

        private void numericTimeHours_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericTimeHours.Value;

            if (value >= 1 && value <= 9)
            {
                numericTimeHours.Text = value.ToString("D2");
            }
            else
            {
                numericTimeHours.Text = value.ToString();
            }
            UpdateTime();
        }

        private void numericTimeMinutes_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericTimeMinutes.Value;

            if (value >= 0 && value <= 9)
            {
                numericTimeMinutes.Text = value.ToString("D2");
            }
            else
            {
                numericTimeMinutes.Text = value.ToString();
            }
            UpdateTime();
        }

        private void UpdateTime()
        {
            int hours = (int)numericTimeHours.Value;
            int minutes = (int)numericTimeMinutes.Value;

            string time = hours.ToString("D2") + " : " + minutes.ToString("D2");
        }
    }
}