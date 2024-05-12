using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
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
    public partial class frmAdminPassenger : Form
    {
        public frmAdminPassenger()
        {
            InitializeComponent();
        }

        private void frmAdminPassenger_Load(object sender, EventArgs e)
        {
            loadPassenger(listPassenger);

        }

        MySqlConnection connection;
        MySqlCommand mycommand;
        MySqlDataReader reader;
        string myconnection = "Server=localhost; Database=dbluxspaceairways; Uid=root; pwd=;";

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminHome adminHome = new frmAdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void loadPassenger(ListView lvwlist)
        {
            string sql = "SELECT * FROM tbl_customer ORDER BY customer_id";
            connection = new MySqlConnection(myconnection);
            connection.Open();
            mycommand = new MySqlCommand(sql, connection);
            reader = mycommand.ExecuteReader();
            lvwlist.Items.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lvwlist.Items.Add(reader[0].ToString());
                    lvwlist.Items[lvwlist.Items.Count - 1].SubItems.Add(reader[1].ToString());
                    lvwlist.Items[lvwlist.Items.Count - 1].SubItems.Add(reader[2].ToString());
                    lvwlist.Items[lvwlist.Items.Count - 1].SubItems.Add(reader[3].ToString());
                    lvwlist.Items[lvwlist.Items.Count - 1].SubItems.Add(reader[4].ToString());
                    lvwlist.Items[lvwlist.Items.Count - 1].SubItems.Add(reader[5].ToString());
                    lvwlist.Items[lvwlist.Items.Count - 1].SubItems.Add(reader[6].ToString());
                }
            }
            connection.Close();
            connection.Dispose();
            reader.Close();
        }

        private void loadPassengerSearch(ListView lvwItems)
        {
            string sql = "SELECT customer_id, firstname, lastname, nationality, birthday, email FROM tbl_customer WHERE firstname LIKE '%" + txtSearchBar.Text + "%' OR lastname LIKE '%" + txtSearchBar.Text + "%' OR nationality LIKE '%" + txtSearchBar.Text + "%' OR birthday LIKE '%" + txtSearchBar.Text + "%' OR email LIKE '%" + txtSearchBar.Text + "%'";
            connection = new MySqlConnection(myconnection);
            connection.Open();
            mycommand = new MySqlCommand(sql, connection);
            reader = mycommand.ExecuteReader();
            lvwItems.Items.Clear();

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem newItem = new ListViewItem(reader[0].ToString());

                        for (int i = 1; i < 7; i++)
                        {
                            if (i < reader.FieldCount)
                            {
                                newItem.SubItems.Add(reader[i].ToString());
                            }
                            else
                            {
                                newItem.SubItems.Add(string.Empty);
                            }
                        }

                        lvwItems.Items.Add(newItem);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
                reader.Close();
            }
        }


        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadPassengerSearch(listPassenger);
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            loadPassengerSearch(listPassenger);
        }
    }
}
