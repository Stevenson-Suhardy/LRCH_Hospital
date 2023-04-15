namespace LRCH_Hospital
{
    partial class AddEditRoom
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
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.textBoxRoomLocation = new System.Windows.Forms.TextBox();
            this.labelRoomLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(105, 182);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(170, 37);
            this.comboBoxRoomType.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(217, 327);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 42);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonOK.Location = new System.Drawing.Point(53, 327);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(120, 42);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRoomType.Location = new System.Drawing.Point(100, 150);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(139, 29);
            this.labelRoomType.TabIndex = 9;
            this.labelRoomType.Text = "Room Type";
            // 
            // textBoxRoomLocation
            // 
            this.textBoxRoomLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxRoomLocation.Location = new System.Drawing.Point(105, 113);
            this.textBoxRoomLocation.Name = "textBoxRoomLocation";
            this.textBoxRoomLocation.Size = new System.Drawing.Size(170, 34);
            this.textBoxRoomLocation.TabIndex = 8;
            // 
            // labelRoomLocation
            // 
            this.labelRoomLocation.AutoSize = true;
            this.labelRoomLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRoomLocation.Location = new System.Drawing.Point(100, 81);
            this.labelRoomLocation.Name = "labelRoomLocation";
            this.labelRoomLocation.Size = new System.Drawing.Size(175, 29);
            this.labelRoomLocation.TabIndex = 7;
            this.labelRoomLocation.Text = "Room Location";
            // 
            // AddEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.textBoxRoomLocation);
            this.Controls.Add(this.labelRoomLocation);
            this.Name = "AddEditRoom";
            this.Text = "Add or Edit Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.TextBox textBoxRoomLocation;
        private System.Windows.Forms.Label labelRoomLocation;
    }
}