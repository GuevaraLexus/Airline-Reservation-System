using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Airline_Reservation_System
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        MySqlCommand command;
        MySqlConnection connection;
        MySqlDataReader reader;

        string myconnection = "Server=localhost; Database=dbluxspaceairways; Uid=root; pwd=";

        private void frmSignup_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(myconnection);
            connection.Open();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string nationality = cmbNationality.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            DateTime birthday = dateBirthday.Value;
            DateTime birthdayWithoutTime = new DateTime(birthday.Year, birthday.Month, birthday.Day, 0, 0, 0);
            string birthdayString = birthdayWithoutTime.ToString("MM/dd/yyyy");


            if (String.IsNullOrEmpty(firstname) || String.IsNullOrEmpty(lastname) || String.IsNullOrEmpty(nationality)
                || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill up all the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "SELECT * FROM tbl_customer WHERE email = '" + txtEmail.Text + "'";
                connection = new MySqlConnection(myconnection);

                try
                {
                    connection.Open();
                    command = new MySqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    
                        sql = "INSERT INTO tbl_customer(firstname, lastname, nationality, birthday, email, password) VALUES"
                        + "('" + firstname + "','" + lastname + "','" + nationality + "','" + birthdayString + "','" + email + "','" + password + "')";
                        connection = new MySqlConnection(myconnection);
                        connection.Open();

                        command = new MySqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();

                        MessageBox.Show("Successfully Sign-up.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                        cmbNationality.SelectedIndex = -1;

                        txtFirstName.Focus();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                errorProviderWarning.SetError(txtEmail, "Please enter an email address.");
                errorProviderWrong.SetError(txtEmail, "");
                errorProviderCorrect.SetError(txtEmail, "");
                return;
            }
            else if (email.Contains("@gmail.com"))
            {
                // Check if the email already exists in the database
                string sql = "SELECT * FROM tbl_customer WHERE email = '" + email + "'";
                using (MySqlConnection conn = new MySqlConnection(myconnection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            errorProviderWarning.SetError(txtEmail, "Email already exists!");
                            errorProviderWrong.SetError(txtEmail, "");
                            errorProviderCorrect.SetError(txtEmail, "");
                            return;
                        }
                        else
                        {
                            errorProviderWarning.SetError(txtEmail, "");
                            errorProviderWrong.SetError(txtEmail, "");
                            errorProviderCorrect.SetError(txtEmail, "Correct");
                            return;
                        }
                    }
                }
            }
            else
            {
                errorProviderWarning.SetError(txtEmail, "");
                errorProviderWrong.SetError(txtEmail, "Please enter the valid email!");
                errorProviderCorrect.SetError(txtEmail, "");
                return;
            }
        }
    }
}

        

