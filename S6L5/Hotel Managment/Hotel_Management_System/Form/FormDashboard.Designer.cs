namespace Hotel_Management_System
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userControlReservation1 = new Hotel_Management_System.User_Control.UserControlReservation();
            this.userControlRoom1 = new Hotel_Management_System.User_Control.UserControlRoom();
            this.userControlClient1 = new Hotel_Management_System.User_Control.UserControlClient();
            this.userControlSetting1 = new Hotel_Management_System.User_Control.UserControlSetting();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlDashboard1 = new Hotel_Management_System.User_Control.UserControlDashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 720);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 202);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 46);
            this.panelSlide.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Image = global::Hotel_Management_System.Properties.Resources.icons8_settings_25px_2;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(12, 410);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(252, 46);
            this.buttonSetting.TabIndex = 5;
            this.buttonSetting.Text = "          Setting";
            this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Image = global::Hotel_Management_System.Properties.Resources.icons8_booking_25px;
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(12, 358);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(252, 46);
            this.buttonReservation.TabIndex = 4;
            this.buttonReservation.Text = "          Reservation";
            this.buttonReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.ForeColor = System.Drawing.Color.White;
            this.buttonRoom.Image = global::Hotel_Management_System.Properties.Resources.icons8_room_25px;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(12, 306);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(252, 46);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = "          Room";
            this.buttonRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Image = global::Hotel_Management_System.Properties.Resources.icons8_administrator_male_25px;
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(12, 254);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(252, 46);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "          Client";
            this.buttonClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::Hotel_Management_System.Properties.Resources.icons8_flipboard_25px;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(12, 202);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(252, 46);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "          Dashboard";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 197);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotel Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_Management_System.Properties.Resources.icons8_home_100px_1;
            this.pictureBox2.Location = new System.Drawing.Point(86, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel3.Controls.Add(this.labelUsername);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(264, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 194);
            this.panel3.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(134, 127);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(21, 23);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.labelDateTime);
            this.panel4.Controls.Add(this.linkLabelLogOut);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1102, 78);
            this.panel4.TabIndex = 0;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.labelDateTime.Location = new System.Drawing.Point(6, 45);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(18, 19);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "?";
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogOut.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabelLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabelLogOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabelLogOut.Location = new System.Drawing.Point(954, 45);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(58, 16);
            this.linkLabelLogOut.TabIndex = 0;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log Out";
            this.linkLabelLogOut.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel_Management_System.Properties.Resources.icons8_account_64px;
            this.pictureBox1.Location = new System.Drawing.Point(891, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(264, 656);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1102, 64);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2020. All Rights Reserved. C# MODERN DESIGN";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userControlDashboard1);
            this.panel6.Controls.Add(this.userControlReservation1);
            this.panel6.Controls.Add(this.userControlRoom1);
            this.panel6.Controls.Add(this.userControlClient1);
            this.panel6.Controls.Add(this.userControlSetting1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(264, 194);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1102, 462);
            this.panel6.TabIndex = 0;
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.BackColor = System.Drawing.Color.White;
            this.userControlReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReservation1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlReservation1.Location = new System.Drawing.Point(0, 0);
            this.userControlReservation1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1102, 462);
            this.userControlReservation1.TabIndex = 0;
            this.userControlReservation1.Visible = false;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.BackColor = System.Drawing.Color.White;
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1102, 462);
            this.userControlRoom1.TabIndex = 0;
            this.userControlRoom1.Visible = false;
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.Color.White;
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClient1.Location = new System.Drawing.Point(0, 0);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1102, 462);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.BackColor = System.Drawing.Color.White;
            this.userControlSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting1.Location = new System.Drawing.Point(0, 0);
            this.userControlSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(1102, 462);
            this.userControlSetting1.TabIndex = 0;
            this.userControlSetting1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1102, 462);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel_Management_System | Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlReservation userControlReservation1;
        private User_Control.UserControlDashboard userControlDashboard1;
    }
}