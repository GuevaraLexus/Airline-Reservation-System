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
using System.Xml.Linq;

namespace Airline_Reservation_System
{
    public partial class frmAdminFlights : Form
    {


        public frmAdminFlights()
        {
            InitializeComponent();

            cmbTravelClassFilter.SelectedIndex = 0;

        }

        private void frmAdminFlights_Load(object sender, EventArgs e)
        {
            LoadFlights();

            txtFlightID.ReadOnly = true;
            cmbTravelClass.Enabled = false;
            cmbFrom.Enabled = false;
            cmbTo.Enabled = false;
            dateDepart.Enabled = false;
            numericTimeHours.Enabled = false;
            numericTimeMinutes.Enabled = false;
            txtCapacity.Enabled = false;
            txtPrice.Enabled = false;

            btnEdit.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        MySqlConnection connection;
        MySqlCommand mycommand;
        MySqlDataReader reader;
        string myconnection = "Server=localhost; Database=dbluxspaceairways; Uid=root; pwd=;";

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminHome adminhome = new frmAdminHome();
            adminhome.Show();
            this.Hide();
        }

        private void LoadFlights()
        {
            try
            {
                string sql = "SELECT * FROM tbl_economy_flight " +
                             "UNION ALL " +
                             "SELECT * FROM tbl_business_flight " +
                             "UNION ALL " +
                             "SELECT * FROM tbl_firstclass_flight;";

                connection = new MySqlConnection(myconnection);
                connection.Open();
                mycommand = new MySqlCommand(sql, connection);
                reader = mycommand.ExecuteReader();
                listFlight.Items.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["flight_id"].ToString());
                        item.SubItems.Add(reader["flight_class"].ToString());
                        item.SubItems.Add(reader["from_country"].ToString());
                        item.SubItems.Add(reader["to_country"].ToString());
                        item.SubItems.Add(reader["date"].ToString());
                        item.SubItems.Add(reader["time"].ToString());
                        item.SubItems.Add(reader["capacity"].ToString());
                        item.SubItems.Add(reader["price"].ToString());

                        listFlight.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void listFlight_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem itm = listFlight.SelectedItems[0];
            txtFlightID.Text = itm.Text;
            cmbTravelClass.Text = itm.SubItems[1].Text;
            cmbFrom.Text = itm.SubItems[2].Text;
            cmbTo.Text = itm.SubItems[3].Text;

            if (DateTime.TryParse(itm.SubItems[4].Text, out DateTime departureDate))
            {
                dateDepart.Value = departureDate;
            }

            string timeString = itm.SubItems[5].Text;
            if (!string.IsNullOrEmpty(timeString) && timeString.Contains(":"))
            {
                string[] timeParts = timeString.Split(':');
                if (timeParts.Length == 2 && int.TryParse(timeParts[0], out int hours) && int.TryParse(timeParts[1], out int minutes))
                {
                    numericTimeHours.Value = hours;
                    numericTimeMinutes.Value = minutes;
                }
            }

            txtCapacity.Text = itm.SubItems[6].Text;
            txtPrice.Text = itm.SubItems[7].Text;


            txtFlightID.ReadOnly = true;
            cmbTravelClass.Enabled = false;
            cmbFrom.Enabled = false;
            cmbTo.Enabled = false;
            dateDepart.Enabled = false;
            numericTimeHours.Enabled = false;
            numericTimeMinutes.Enabled = false;
            txtCapacity.Enabled = false;
            txtPrice.Enabled = false;

            btnEdit.Visible = true;
            btnDelete.Visible = true;

        }

        private void cmbTravelClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter the ListView based on the selected travel class.
            string selectedTravelClass = cmbTravelClassFilter.SelectedItem.ToString();
            FilterFlightsByTravelClass(selectedTravelClass);
        }

        private void FilterFlightsByTravelClass(string selectedTravelClass)
        {
            if (selectedTravelClass == "All")
            {
                LoadFlights();
            }
            else
            {
                try
                {
                    string tableName = GetTableNameFromTravelClass(selectedTravelClass);
                    if (tableName == null)
                    {
                        MessageBox.Show("Invalid selection. Please choose a valid travel class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = $"SELECT * FROM {tableName}";

                    connection = new MySqlConnection(myconnection);
                    connection.Open();
                    mycommand = new MySqlCommand(sql, connection);
                    reader = mycommand.ExecuteReader();
                    listFlight.Items.Clear();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["flight_id"].ToString());
                            item.SubItems.Add(reader["flight_class"].ToString());
                            item.SubItems.Add(reader["from_country"].ToString());
                            item.SubItems.Add(reader["to_country"].ToString());
                            item.SubItems.Add(reader["date"].ToString());
                            item.SubItems.Add(reader["time"].ToString());
                            item.SubItems.Add(reader["capacity"].ToString());
                            item.SubItems.Add(reader["price"].ToString());

                            listFlight.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private string GetTableNameFromTravelClass(string selectedTravelClass)
        {

            switch (selectedTravelClass)
            {
                case "Economy Class":
                    return "tbl_economy_flight";
                case "Business Class":
                    return "tbl_business_flight";
                case "First Class":
                    return "tbl_firstclass_flight";
                default:
                    return null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFlightID.ReadOnly = true;
            cmbTravelClass.Enabled = true;
            cmbFrom.Enabled = true;
            cmbTo.Enabled = true;
            dateDepart.Enabled = true;
            numericTimeHours.Enabled = true;
            numericTimeMinutes.Enabled = true;
            txtCapacity.Enabled = true;
            txtPrice.Enabled = true;

            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int flightID = int.Parse(txtFlightID.Text);
            string flightClass = cmbTravelClass.Text;
            string tableName = GetTableNameFromTravelClass(flightClass);

            if (tableName != null)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = $"DELETE FROM {tableName} WHERE flight_id = {flightID}";
                        connection = new MySqlConnection(myconnection);
                        connection.Open();
                        mycommand = new MySqlCommand(sql, connection);
                        int rowsAffected = mycommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadFlights();
                            MessageBox.Show("Successfully Deleted!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtFlightID.Clear();
                            cmbTravelClass.SelectedIndex = -1;
                            cmbFrom.SelectedIndex = -1;
                            cmbTo.SelectedIndex = -1;
                            dateDepart.Value = DateTime.Now;
                            numericTimeHours.Value = 1;
                            numericTimeMinutes.Value = 0;
                            txtCapacity.Clear();
                            txtPrice.Clear();

                            btnEdit.Visible = false;
                            btnDelete.Visible = false;
                            btnUpdate.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Flight ID not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid travel class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int flightID = int.Parse(txtFlightID.Text);
                string travelclass = cmbTravelClass.SelectedItem.ToString();
                string from = cmbFrom.SelectedItem.ToString();
                string to = cmbTo.SelectedItem.ToString();
                int capacity = int.Parse(txtCapacity.Text);
                int price = int.Parse(txtPrice.Text);
                int timehours = (int)numericTimeHours.Value;
                int timeminutes = (int)numericTimeMinutes.Value;
                string time = timehours.ToString("D2") + " : " + timeminutes.ToString("D2");

                DateTime depart = dateDepart.Value;
                DateTime departWithoutTime = new DateTime(depart.Year, depart.Month, depart.Day, 0, 0, 0);
                string departString = departWithoutTime.ToString("MM/dd/yyyy");

                string flightClass = cmbTravelClass.Text;
                string currentTableName = GetTableNameFromTravelClass(flightClass);
                string newTableName = GetTableNameFromTravelClass(travelclass);

                DialogResult result = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (connection = new MySqlConnection(myconnection))
                    {
                        connection.Open();

                        // Check if the travel class has changed.
                        if (currentTableName != newTableName)
                        {
                            // Delete the old record from the old travel class table.
                            string deleteSql = $"DELETE FROM {currentTableName} WHERE flight_id = {flightID}";
                            using (mycommand = new MySqlCommand(deleteSql, connection))
                            {
                                mycommand.ExecuteNonQuery();
                            }

                            // Determine the new flight ID for the new travel class table.
                            string sql = $"SELECT MAX(flight_id) + 1 FROM {newTableName}";
                            using (mycommand = new MySqlCommand(sql, connection))
                            {
                                var newFlightID = mycommand.ExecuteScalar();
                            }
                        }

                        // Insert the updated or new record into the new travel class table.
                        string insertSql = $"INSERT INTO {newTableName} (flight_id, flight_class, from_country, to_country, date, time, capacity, price) " +
                            $"VALUES ({flightID}, @travelclass, @from, @to, @departString, @time, @capacity, @price)";
                        using (var cmd = new MySqlCommand(insertSql, connection))
                        {
                            cmd.Parameters.AddWithValue("@travelclass", travelclass);
                            cmd.Parameters.AddWithValue("@from", from);
                            cmd.Parameters.AddWithValue("@to", to);
                            cmd.Parameters.AddWithValue("@departString", departString);
                            cmd.Parameters.AddWithValue("@time", time);
                            cmd.Parameters.AddWithValue("@capacity", capacity);
                            cmd.Parameters.AddWithValue("@price", price);

                            cmd.ExecuteNonQuery();
                        }

                        // Refresh the list of flights and reset UI elements.
                        LoadFlights();

                        MessageBox.Show("Successfully Updated!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtFlightID.Clear();
                        cmbTravelClass.SelectedIndex = -1;
                        cmbFrom.SelectedIndex = -1;
                        cmbTo.SelectedIndex = -1;
                        dateDepart.Value = DateTime.Now;
                        numericTimeHours.Value = 1;
                        numericTimeMinutes.Value = 0;
                        txtCapacity.Clear();
                        txtPrice.Clear();

                        txtFlightID.ReadOnly = true;
                        cmbTravelClass.Enabled = false;
                        cmbFrom.Enabled = false;
                        cmbTo.Enabled = false;
                        dateDepart.Enabled = false;
                        numericTimeHours.Enabled = false;
                        numericTimeMinutes.Enabled = false;
                        txtCapacity.Enabled = false;
                        txtPrice.Enabled = false;

                        btnEdit.Visible = false;
                        btnDelete.Visible = false;
                        btnUpdate.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}