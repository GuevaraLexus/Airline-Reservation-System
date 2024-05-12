namespace Airline_Reservation_System
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBook = new System.Windows.Forms.Panel();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.radioOneWay = new System.Windows.Forms.RadioButton();
            this.cmbReturnDate = new System.Windows.Forms.ComboBox();
            this.cmbDepartureDate = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.radioRoundTrip = new System.Windows.Forms.RadioButton();
            this.imgSlideshowPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartureTime = new System.Windows.Forms.ComboBox();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.cmbReturnTime = new System.Windows.Forms.ComboBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlideshowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.btnSignup);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.imgLogo);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(786, 90);
            this.panel.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(452, 47);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 30);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Black;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(608, 47);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(150, 30);
            this.btnSignup.TabIndex = 29;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(784, 422);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Airline_Reservation_System.Properties.Resources.Lux_space__7_;
            this.imgLogo.Location = new System.Drawing.Point(22, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(270, 65);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(0, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 20);
            this.panel2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBook
            // 
            this.panelBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBook.Controls.Add(this.lblReturnTime);
            this.panelBook.Controls.Add(this.cmbReturnTime);
            this.panelBook.Controls.Add(this.label1);
            this.panelBook.Controls.Add(this.cmbDepartureTime);
            this.panelBook.Controls.Add(this.btnBookFlight);
            this.panelBook.Controls.Add(this.cmbClass);
            this.panelBook.Controls.Add(this.lblClass);
            this.panelBook.Controls.Add(this.lblFrom);
            this.panelBook.Controls.Add(this.pictureBox4);
            this.panelBook.Controls.Add(this.pictureBox3);
            this.panelBook.Controls.Add(this.lblReturnDate);
            this.panelBook.Controls.Add(this.lblDepart);
            this.panelBook.Controls.Add(this.lblTo);
            this.panelBook.Controls.Add(this.radioOneWay);
            this.panelBook.Controls.Add(this.cmbReturnDate);
            this.panelBook.Controls.Add(this.cmbDepartureDate);
            this.panelBook.Controls.Add(this.cmbTo);
            this.panelBook.Controls.Add(this.cmbFrom);
            this.panelBook.Controls.Add(this.radioRoundTrip);
            this.panelBook.Location = new System.Drawing.Point(25, 306);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(733, 210);
            this.panelBook.TabIndex = 3;
            this.panelBook.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBook_Paint);
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.Color.Black;
            this.btnBookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.ForeColor = System.Drawing.Color.White;
            this.btnBookFlight.Location = new System.Drawing.Point(532, 169);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(150, 25);
            this.btnBookFlight.TabIndex = 28;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = false;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Economy",
            "Business Class",
            "First Class"});
            this.cmbClass.Location = new System.Drawing.Point(51, 73);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(200, 21);
            this.cmbClass.TabIndex = 27;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(52, 55);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(67, 15);
            this.lblClass.TabIndex = 26;
            this.lblClass.Text = "Travel Class";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(293, 57);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 15);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "From";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Airline_Reservation_System.Properties.Resources.Red_White_Simple_Star_Wings_Airline_Transport_Logo__7_;
            this.pictureBox4.Location = new System.Drawing.Point(484, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Airline_Reservation_System.Properties.Resources.Red_White_Simple_Star_Wings_Airline_Transport_Logo__7_;
            this.pictureBox3.Location = new System.Drawing.Point(276, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(373, 115);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(70, 15);
            this.lblReturnDate.TabIndex = 13;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(48, 115);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(88, 15);
            this.lblDepart.TabIndex = 12;
            this.lblDepart.Text = "Departure Date";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(502, 55);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 15);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To";
            // 
            // radioOneWay
            // 
            this.radioOneWay.AutoSize = true;
            this.radioOneWay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOneWay.Location = new System.Drawing.Point(207, 19);
            this.radioOneWay.Name = "radioOneWay";
            this.radioOneWay.Size = new System.Drawing.Size(80, 21);
            this.radioOneWay.TabIndex = 10;
            this.radioOneWay.TabStop = true;
            this.radioOneWay.Text = "One-way";
            this.radioOneWay.UseVisualStyleBackColor = true;
            this.radioOneWay.CheckedChanged += new System.EventHandler(this.radioOneWay_CheckedChanged);
            // 
            // cmbReturnDate
            // 
            this.cmbReturnDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnDate.FormattingEnabled = true;
            this.cmbReturnDate.Location = new System.Drawing.Point(376, 131);
            this.cmbReturnDate.Name = "cmbReturnDate";
            this.cmbReturnDate.Size = new System.Drawing.Size(150, 21);
            this.cmbReturnDate.TabIndex = 8;
            // 
            // cmbDepartureDate
            // 
            this.cmbDepartureDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartureDate.FormattingEnabled = true;
            this.cmbDepartureDate.Location = new System.Drawing.Point(51, 131);
            this.cmbDepartureDate.Name = "cmbDepartureDate";
            this.cmbDepartureDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDepartureDate.Size = new System.Drawing.Size(150, 21);
            this.cmbDepartureDate.TabIndex = 6;
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(482, 73);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(200, 21);
            this.cmbTo.TabIndex = 4;
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(276, 73);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(200, 21);
            this.cmbFrom.TabIndex = 2;
            // 
            // radioRoundTrip
            // 
            this.radioRoundTrip.AutoSize = true;
            this.radioRoundTrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRoundTrip.Location = new System.Drawing.Point(51, 19);
            this.radioRoundTrip.Name = "radioRoundTrip";
            this.radioRoundTrip.Size = new System.Drawing.Size(92, 21);
            this.radioRoundTrip.TabIndex = 0;
            this.radioRoundTrip.TabStop = true;
            this.radioRoundTrip.Text = "Round-trip";
            this.radioRoundTrip.UseVisualStyleBackColor = true;
            this.radioRoundTrip.CheckedChanged += new System.EventHandler(this.radioRoundTrip_CheckedChanged);
            // 
            // imgSlideshowPic
            // 
            this.imgSlideshowPic.Image = global::Airline_Reservation_System.Properties.Resources._10;
            this.imgSlideshowPic.Location = new System.Drawing.Point(0, 90);
            this.imgSlideshowPic.Name = "imgSlideshowPic";
            this.imgSlideshowPic.Size = new System.Drawing.Size(784, 459);
            this.imgSlideshowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlideshowPic.TabIndex = 1;
            this.imgSlideshowPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Departure Time";
            // 
            // cmbDepartureTime
            // 
            this.cmbDepartureTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartureTime.FormattingEnabled = true;
            this.cmbDepartureTime.Location = new System.Drawing.Point(207, 131);
            this.cmbDepartureTime.Name = "cmbDepartureTime";
            this.cmbDepartureTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDepartureTime.Size = new System.Drawing.Size(150, 21);
            this.cmbDepartureTime.TabIndex = 29;
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTime.Location = new System.Drawing.Point(529, 115);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(72, 15);
            this.lblReturnTime.TabIndex = 32;
            this.lblReturnTime.Text = "Return Time";
            // 
            // cmbReturnTime
            // 
            this.cmbReturnTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnTime.FormattingEnabled = true;
            this.cmbReturnTime.Location = new System.Drawing.Point(532, 131);
            this.cmbReturnTime.Name = "cmbReturnTime";
            this.cmbReturnTime.Size = new System.Drawing.Size(150, 21);
            this.cmbReturnTime.TabIndex = 31;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.imgSlideshowPic);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lux Space Airways";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlideshowPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgSlideshowPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.RadioButton radioOneWay;
        private System.Windows.Forms.ComboBox cmbReturnDate;
        private System.Windows.Forms.ComboBox cmbDepartureDate;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.RadioButton radioRoundTrip;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.ComboBox cmbReturnTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartureTime;
    }
}

