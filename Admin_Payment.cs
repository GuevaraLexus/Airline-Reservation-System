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
    public partial class frmAdminPayment : Form
    {
        public frmAdminPayment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminHome adminhome = new frmAdminHome();
            adminhome.Show();
            this.Hide();
        }
    }
}
