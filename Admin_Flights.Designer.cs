namespace Airline_Reservation_System
{
    partial class frmAdminFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminFlights));
            this.panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.listFlight = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTravelClassFilter = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flightID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flightclass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flightrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depart_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.return_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Firebrick;
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.imgLogo);
            this.panel.Location = new System.Drawing.Point(-1, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(903, 125);
            this.panel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(699, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 28);
            this.label11.TabIndex = 67;
            this.label11.Text = "Admin";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(26, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 50);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 20);
            this.panel2.TabIndex = 31;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Airline_Reservation_System.Properties.Resources.Lux_space__6_;
            this.imgLogo.Location = new System.Drawing.Point(241, 31);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(300, 70);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Location = new System.Drawing.Point(0, 543);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 20);
            this.panel4.TabIndex = 58;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(68, 155);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(123, 45);
            this.lblFrom.TabIndex = 60;
            this.lblFrom.Text = "Flights";
            // 
            // listFlight
            // 
            this.listFlight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.flightID,
            this.flightclass,
            this.flightrip,
            this.from,
            this.to,
            this.Depart,
            this.depart_time,
            this.Return,
            this.return_time,
            this.capacity,
            this.price});
            this.listFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFlight.GridLines = true;
            this.listFlight.HideSelection = false;
            this.listFlight.Location = new System.Drawing.Point(12, 210);
            this.listFlight.Name = "listFlight";
            this.listFlight.Size = new System.Drawing.Size(760, 326);
            this.listFlight.TabIndex = 61;
            this.listFlight.UseCompatibleStateImageBehavior = false;
            this.listFlight.View = System.Windows.Forms.View.Details;
            this.listFlight.DoubleClick += new System.EventHandler(this.listFlight_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Filter";
            // 
            // cmbTravelClassFilter
            // 
            this.cmbTravelClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTravelClassFilter.FormattingEnabled = true;
            this.cmbTravelClassFilter.Items.AddRange(new object[] {
            "All",
            "Economy Class",
            "Business Class",
            "First Class"});
            this.cmbTravelClassFilter.Location = new System.Drawing.Point(651, 183);
            this.cmbTravelClassFilter.Name = "cmbTravelClassFilter";
            this.cmbTravelClassFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbTravelClassFilter.TabIndex = 63;
            this.cmbTravelClassFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTravelClassFilter_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Airline_Reservation_System.Properties.Resources.Red_White_Simple_Star_Wings_Airline_Transport_Logo__7_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // flightID
            // 
            this.flightID.Text = "Flight ID";
            // 
            // flightclass
            // 
            this.flightclass.Text = "Flight Class";
            this.flightclass.Width = 80;
            // 
            // flightrip
            // 
            this.flightrip.Text = "Flight Trip";
            this.flightrip.Width = 80;
            // 
            // from
            // 
            this.from.Text = "From";
            this.from.Width = 125;
            // 
            // to
            // 
            this.to.Text = "To";
            this.to.Width = 125;
            // 
            // Depart
            // 
            this.Depart.Text = "Depart";
            // 
            // depart_time
            // 
            this.depart_time.Text = "Time";
            // 
            // Return
            // 
            this.Return.Text = "Return";
            // 
            // return_time
            // 
            this.return_time.Text = "Time";
            // 
            // capacity
            // 
            this.capacity.Text = "Capacity";
            // 
            // price
            // 
            this.price.Text = "Price";
            // 
            // frmAdminFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTravelClassFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFlight);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lux Space Airways";
            this.Load += new System.EventHandler(this.frmAdminFlights_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ListView listFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTravelClassFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader flightID;
        private System.Windows.Forms.ColumnHeader flightclass;
        private System.Windows.Forms.ColumnHeader flightrip;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ColumnHeader Depart;
        private System.Windows.Forms.ColumnHeader depart_time;
        private System.Windows.Forms.ColumnHeader Return;
        private System.Windows.Forms.ColumnHeader return_time;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader price;
    }
}