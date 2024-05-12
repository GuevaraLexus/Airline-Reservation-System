using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Airline_Reservation_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Focus();
        }

        MySqlConnection connection;
        MySqlCommand mycommand;
        MySqlDataReader rdr;
        string myconnection = "Server=localhost; Database=dbluxspaceairways; Uid=root; pwd=;";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                frmAdminHome a_home = new frmAdminHome();
                a_home.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderWarning.SetError(txtEmail, "Please enter a valid email!");
                errorProviderWrong.SetError(txtEmail, "");
                errorProviderCorrect.SetError(txtEmail, "");

                errorProviderWarning.SetError(txtPassword, "Please enter a password!");
                errorProviderWrong.SetError(txtPassword, "");
                errorProviderCorrect.SetError(txtPassword, "");

                txtEmail.Clear();
                txtPassword.Clear();
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                errorProviderWarning.SetError(txtEmail, "Please enter a valid email!");
                errorProviderWrong.SetError(txtEmail, "");
                errorProviderCorrect.SetError(txtEmail, "");

                txtPassword.Clear();
            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    String sql = "SELECT * FROM tbl_customer WHERE email = '" + txtEmail.Text + "' and password = '" + txtPassword.Text + "'";
                    connection = new MySqlConnection(myconnection);

                    try
                    {
                        connection.Open();
                        mycommand = new MySqlCommand(sql, connection);
                        rdr = mycommand.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            this.Hide();
                            frmHome c_home = new frmHome();
                            c_home.ShowDialog();
                        }
                        else if (!IsEmailRegistered(txtEmail.Text))
                        {
                            errorProviderWarning.SetError(txtEmail, "Email is not registered!");
                            txtPassword.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Email/Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtEmail.Clear();
                            txtPassword.Clear();

                            errorProviderWarning.SetError(txtEmail, "");
                            errorProviderWrong.SetError(txtEmail, "Incorrect Email!");
                            errorProviderCorrect.SetError(txtEmail, "");

                            errorProviderWarning.SetError(txtPassword, "");
                            errorProviderWrong.SetError(txtPassword, "Incorrect Password!");
                            errorProviderCorrect.SetError(txtPassword, "");

                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup signup = new frmSignup();
            signup.ShowDialog();
        }

        private bool IsEmailRegistered(string email)
        {
            string sql = "SELECT COUNT(*) FROM tbl_customer WHERE email = @email";
            using (MySqlConnection conn = new MySqlConnection(myconnection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0; // If count is greater than 0, the email is registered.
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            errorProviderWarning.SetError(txtEmail, "");
            errorProviderWrong.SetError(txtEmail, "");
            errorProviderCorrect.SetError(txtEmail, "");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorProviderWarning.SetError(txtPassword, "");
            errorProviderWrong.SetError(txtPassword, "");
            errorProviderCorrect.SetError(txtPassword, "");
        }
    }
}
