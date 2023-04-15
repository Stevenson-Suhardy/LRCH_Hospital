namespace LRCH_Hospital
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabPageRoom = new System.Windows.Forms.TabPage();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonAddRoomType = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.listViewOccupancyByRooms = new System.Windows.Forms.ListView();
            this.listViewDischargingPatient = new System.Windows.Forms.ListView();
            this.listViewOccupancyByRoomType = new System.Windows.Forms.ListView();
            this.tabPagePhysicianPatient = new System.Windows.Forms.TabPage();
            this.groupBoxPatientData = new System.Windows.Forms.GroupBox();
            this.listViewAppoitmentHistory = new System.Windows.Forms.ListView();
            this.colAppoitmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTreatment = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelTreamentPlan = new System.Windows.Forms.Label();
            this.labelAppoitmentHistory = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.tabPageLogout = new System.Windows.Forms.TabPage();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageRoom.SuspendLayout();
            this.tabPagePhysicianPatient.SuspendLayout();
            this.groupBoxPatientData.SuspendLayout();
            this.tabPageLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogin);
            this.tabControl1.Controls.Add(this.tabPageRoom);
            this.tabControl1.Controls.Add(this.tabPagePhysicianPatient);
            this.tabControl1.Controls.Add(this.tabPageLogout);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 617);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.textBoxPassword);
            this.tabPageLogin.Controls.Add(this.textBoxUsername);
            this.tabPageLogin.Controls.Add(this.labelPassword);
            this.tabPageLogin.Controls.Add(this.buttonLogin);
            this.tabPageLogin.Controls.Add(this.labelUsername);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Size = new System.Drawing.Size(993, 588);
            this.tabPageLogin.TabIndex = 2;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.Location = new System.Drawing.Point(373, 286);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(189, 34);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.Location = new System.Drawing.Point(373, 214);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(189, 34);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(401, 254);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(120, 29);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(402, 326);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(119, 43);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(397, 182);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(124, 29);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Controls.Add(this.labelInfo);
            this.tabPageRoom.Controls.Add(this.buttonAddRoomType);
            this.tabPageRoom.Controls.Add(this.buttonAddRoom);
            this.tabPageRoom.Controls.Add(this.listViewOccupancyByRooms);
            this.tabPageRoom.Controls.Add(this.listViewDischargingPatient);
            this.tabPageRoom.Controls.Add(this.listViewOccupancyByRoomType);
            this.tabPageRoom.Location = new System.Drawing.Point(4, 25);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoom.Size = new System.Drawing.Size(993, 588);
            this.tabPageRoom.TabIndex = 0;
            this.tabPageRoom.Text = "Room Utilization";
            this.tabPageRoom.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelInfo.Location = new System.Drawing.Point(22, 144);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(253, 155);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "NOTE: \r\nDouble click any \r\nof the rooms on the \r\nlist to edit\r\n\r\n";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAddRoomType
            // 
            this.buttonAddRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddRoomType.Location = new System.Drawing.Point(8, 94);
            this.buttonAddRoomType.Name = "buttonAddRoomType";
            this.buttonAddRoomType.Size = new System.Drawing.Size(296, 47);
            this.buttonAddRoomType.TabIndex = 11;
            this.buttonAddRoomType.Text = "Add New Room Type";
            this.buttonAddRoomType.UseVisualStyleBackColor = true;
            this.buttonAddRoomType.Click += new System.EventHandler(this.buttonAddRoomType_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddRoom.Location = new System.Drawing.Point(8, 41);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(296, 47);
            this.buttonAddRoom.TabIndex = 10;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // listViewOccupancyByRooms
            // 
            this.listViewOccupancyByRooms.HideSelection = false;
            this.listViewOccupancyByRooms.Location = new System.Drawing.Point(324, 25);
            this.listViewOccupancyByRooms.Name = "listViewOccupancyByRooms";
            this.listViewOccupancyByRooms.Size = new System.Drawing.Size(661, 181);
            this.listViewOccupancyByRooms.TabIndex = 7;
            this.listViewOccupancyByRooms.UseCompatibleStateImageBehavior = false;
            this.listViewOccupancyByRooms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOccupancyByRooms_MouseDoubleClick);
            // 
            // listViewDischargingPatient
            // 
            this.listViewDischargingPatient.HideSelection = false;
            this.listViewDischargingPatient.Location = new System.Drawing.Point(324, 401);
            this.listViewDischargingPatient.Name = "listViewDischargingPatient";
            this.listViewDischargingPatient.Size = new System.Drawing.Size(661, 181);
            this.listViewDischargingPatient.TabIndex = 9;
            this.listViewDischargingPatient.UseCompatibleStateImageBehavior = false;
            // 
            // listViewOccupancyByRoomType
            // 
            this.listViewOccupancyByRoomType.HideSelection = false;
            this.listViewOccupancyByRoomType.Location = new System.Drawing.Point(324, 212);
            this.listViewOccupancyByRoomType.Name = "listViewOccupancyByRoomType";
            this.listViewOccupancyByRoomType.Size = new System.Drawing.Size(661, 181);
            this.listViewOccupancyByRoomType.TabIndex = 8;
            this.listViewOccupancyByRoomType.UseCompatibleStateImageBehavior = false;
            this.listViewOccupancyByRoomType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOccupancyByRoomType_MouseDoubleClick);
            // 
            // tabPagePhysicianPatient
            // 
            this.tabPagePhysicianPatient.Controls.Add(this.groupBoxPatientData);
            this.tabPagePhysicianPatient.Controls.Add(this.listBoxPatient);
            this.tabPagePhysicianPatient.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhysicianPatient.Name = "tabPagePhysicianPatient";
            this.tabPagePhysicianPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhysicianPatient.Size = new System.Drawing.Size(993, 588);
            this.tabPagePhysicianPatient.TabIndex = 1;
            this.tabPagePhysicianPatient.Text = "Physician-Patient";
            this.tabPagePhysicianPatient.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatientData
            // 
            this.groupBoxPatientData.Controls.Add(this.listViewAppoitmentHistory);
            this.groupBoxPatientData.Controls.Add(this.textBoxTreatment);
            this.groupBoxPatientData.Controls.Add(this.textBoxGender);
            this.groupBoxPatientData.Controls.Add(this.textBoxLastName);
            this.groupBoxPatientData.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatientData.Controls.Add(this.textBoxID);
            this.groupBoxPatientData.Controls.Add(this.labelTreamentPlan);
            this.groupBoxPatientData.Controls.Add(this.labelAppoitmentHistory);
            this.groupBoxPatientData.Controls.Add(this.labelGender);
            this.groupBoxPatientData.Controls.Add(this.labelLastName);
            this.groupBoxPatientData.Controls.Add(this.labelFirstName);
            this.groupBoxPatientData.Controls.Add(this.labelID);
            this.groupBoxPatientData.Location = new System.Drawing.Point(412, 137);
            this.groupBoxPatientData.Name = "groupBoxPatientData";
            this.groupBoxPatientData.Size = new System.Drawing.Size(445, 314);
            this.groupBoxPatientData.TabIndex = 4;
            this.groupBoxPatientData.TabStop = false;
            this.groupBoxPatientData.Text = "Patient Details";
            // 
            // listViewAppoitmentHistory
            // 
            this.listViewAppoitmentHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAppoitmentID,
            this.colDate});
            this.listViewAppoitmentHistory.HideSelection = false;
            this.listViewAppoitmentHistory.Location = new System.Drawing.Point(250, 90);
            this.listViewAppoitmentHistory.Name = "listViewAppoitmentHistory";
            this.listViewAppoitmentHistory.Size = new System.Drawing.Size(174, 97);
            this.listViewAppoitmentHistory.TabIndex = 8;
            this.listViewAppoitmentHistory.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxTreatment
            // 
            this.textBoxTreatment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTreatment.Location = new System.Drawing.Point(28, 229);
            this.textBoxTreatment.Multiline = true;
            this.textBoxTreatment.Name = "textBoxTreatment";
            this.textBoxTreatment.ReadOnly = true;
            this.textBoxTreatment.Size = new System.Drawing.Size(174, 68);
            this.textBoxTreatment.TabIndex = 9;
            // 
            // textBoxGender
            // 
            this.textBoxGender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxGender.Location = new System.Drawing.Point(103, 150);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(89, 22);
            this.textBoxGender.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLastName.Location = new System.Drawing.Point(103, 114);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(89, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFirstName.Location = new System.Drawing.Point(103, 78);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(89, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxID.Location = new System.Drawing.Point(103, 44);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(89, 22);
            this.textBoxID.TabIndex = 3;
            // 
            // labelTreamentPlan
            // 
            this.labelTreamentPlan.AutoSize = true;
            this.labelTreamentPlan.Location = new System.Drawing.Point(25, 195);
            this.labelTreamentPlan.Name = "labelTreamentPlan";
            this.labelTreamentPlan.Size = new System.Drawing.Size(95, 16);
            this.labelTreamentPlan.TabIndex = 6;
            this.labelTreamentPlan.Text = "Treament Plan";
            // 
            // labelAppoitmentHistory
            // 
            this.labelAppoitmentHistory.AutoSize = true;
            this.labelAppoitmentHistory.Location = new System.Drawing.Point(247, 48);
            this.labelAppoitmentHistory.Name = "labelAppoitmentHistory";
            this.labelAppoitmentHistory.Size = new System.Drawing.Size(120, 16);
            this.labelAppoitmentHistory.TabIndex = 4;
            this.labelAppoitmentHistory.Text = "Appoitment History";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(25, 150);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 16);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(25, 114);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(69, 16);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "LastName";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(25, 81);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 16);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(25, 48);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.ItemHeight = 16;
            this.listBoxPatient.Location = new System.Drawing.Point(115, 137);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.Size = new System.Drawing.Size(157, 260);
            this.listBoxPatient.TabIndex = 3;
            // 
            // tabPageLogout
            // 
            this.tabPageLogout.Controls.Add(this.buttonLogout);
            this.tabPageLogout.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogout.Name = "tabPageLogout";
            this.tabPageLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogout.Size = new System.Drawing.Size(993, 588);
            this.tabPageLogout.TabIndex = 3;
            this.tabPageLogout.Text = "Logout";
            this.tabPageLogout.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogout.Location = new System.Drawing.Point(412, 245);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(119, 43);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageRoom.ResumeLayout(false);
            this.tabPageRoom.PerformLayout();
            this.tabPagePhysicianPatient.ResumeLayout(false);
            this.groupBoxPatientData.ResumeLayout(false);
            this.groupBoxPatientData.PerformLayout();
            this.tabPageLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TabPage tabPageRoom;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonAddRoomType;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.ListView listViewOccupancyByRooms;
        private System.Windows.Forms.ListView listViewDischargingPatient;
        private System.Windows.Forms.ListView listViewOccupancyByRoomType;
        private System.Windows.Forms.TabPage tabPagePhysicianPatient;
        private System.Windows.Forms.GroupBox groupBoxPatientData;
        private System.Windows.Forms.ListView listViewAppoitmentHistory;
        private System.Windows.Forms.ColumnHeader colAppoitmentID;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.TextBox textBoxTreatment;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelTreamentPlan;
        private System.Windows.Forms.Label labelAppoitmentHistory;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.TabPage tabPageLogout;
        private System.Windows.Forms.Button buttonLogout;
    }
}

