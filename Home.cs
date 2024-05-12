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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            imgSlideshowPic.ImageLocation = string.Format(@"Images\{0}.png", imageNumber);
            imageNumber++;
        }

        private void radioRoundTrip_CheckedChanged_1(object sender, EventArgs e)
        {
            lblReturnDate.Visible = true;
            lblReturnTime.Visible = true;

            cmbDepartureDate.Visible = true;
            cmbDepartureTime.Visible = true;

            cmbReturnDate.Visible = true;
            cmbReturnTime.Visible = true;
        }

        private void radioOneWay_CheckedChanged_1(object sender, EventArgs e)
        {
            lblReturnDate.Visible = false;
            lblReturnTime.Visible = false;

            cmbReturnDate.Visible = false;
            cmbReturnTime.Visible = false;
        }
    }
}
