namespace Billets
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpAssigned = new System.Windows.Forms.GroupBox();
            this.dgvAssigned = new System.Windows.Forms.DataGridView();
            this.btnBillet = new System.Windows.Forms.Button();
            this.grpUnassigned = new System.Windows.Forms.GroupBox();
            this.dgvUnassigned = new System.Windows.Forms.DataGridView();
            this.grpFamily = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.lstFamilies = new System.Windows.Forms.ListBox();
            this.txtFamilyID = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.grpAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigned)).BeginInit();
            this.grpUnassigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassigned)).BeginInit();
            this.grpFamily.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(726, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // grpAssigned
            // 
            this.grpAssigned.Controls.Add(this.dgvAssigned);
            this.grpAssigned.Location = new System.Drawing.Point(404, 197);
            this.grpAssigned.Name = "grpAssigned";
            this.grpAssigned.Size = new System.Drawing.Size(290, 160);
            this.grpAssigned.TabIndex = 39;
            this.grpAssigned.TabStop = false;
            this.grpAssigned.Text = "Children Assigned to this Family";
            // 
            // dgvAssigned
            // 
            this.dgvAssigned.AllowUserToAddRows = false;
            this.dgvAssigned.AllowUserToDeleteRows = false;
            this.dgvAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssigned.Location = new System.Drawing.Point(9, 23);
            this.dgvAssigned.Name = "dgvAssigned";
            this.dgvAssigned.ReadOnly = true;
            this.dgvAssigned.Size = new System.Drawing.Size(275, 117);
            this.dgvAssigned.TabIndex = 3;
            // 
            // btnBillet
            // 
            this.btnBillet.Location = new System.Drawing.Point(324, 259);
            this.btnBillet.Name = "btnBillet";
            this.btnBillet.Size = new System.Drawing.Size(64, 40);
            this.btnBillet.TabIndex = 36;
            this.btnBillet.Text = "Billet child";
            // 
            // grpUnassigned
            // 
            this.grpUnassigned.Controls.Add(this.dgvUnassigned);
            this.grpUnassigned.Location = new System.Drawing.Point(12, 197);
            this.grpUnassigned.Name = "grpUnassigned";
            this.grpUnassigned.Size = new System.Drawing.Size(290, 160);
            this.grpUnassigned.TabIndex = 38;
            this.grpUnassigned.TabStop = false;
            this.grpUnassigned.Text = "Children Requiring Billets";
            // 
            // dgvUnassigned
            // 
            this.dgvUnassigned.AllowUserToAddRows = false;
            this.dgvUnassigned.AllowUserToDeleteRows = false;
            this.dgvUnassigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnassigned.Location = new System.Drawing.Point(9, 23);
            this.dgvUnassigned.Name = "dgvUnassigned";
            this.dgvUnassigned.ReadOnly = true;
            this.dgvUnassigned.Size = new System.Drawing.Size(275, 117);
            this.dgvUnassigned.TabIndex = 3;
            // 
            // grpFamily
            // 
            this.grpFamily.BackColor = System.Drawing.SystemColors.Control;
            this.grpFamily.Controls.Add(this.txtPostalCode);
            this.grpFamily.Controls.Add(this.txtProvince);
            this.grpFamily.Controls.Add(this.txtFamilyName);
            this.grpFamily.Controls.Add(this.lstFamilies);
            this.grpFamily.Controls.Add(this.txtFamilyID);
            this.grpFamily.Controls.Add(this.txtStreet);
            this.grpFamily.Controls.Add(this.txtCity);
            this.grpFamily.Controls.Add(this.Label5);
            this.grpFamily.Controls.Add(this.Label8);
            this.grpFamily.Controls.Add(this.Label7);
            this.grpFamily.Controls.Add(this.Label6);
            this.grpFamily.Controls.Add(this.Label2);
            this.grpFamily.Controls.Add(this.Label1);
            this.grpFamily.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFamily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpFamily.Location = new System.Drawing.Point(21, 10);
            this.grpFamily.Name = "grpFamily";
            this.grpFamily.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpFamily.Size = new System.Drawing.Size(667, 171);
            this.grpFamily.TabIndex = 37;
            this.grpFamily.TabStop = false;
            this.grpFamily.Text = "Select a Family";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AcceptsReturn = true;
            this.txtPostalCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostalCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPostalCode.Location = new System.Drawing.Point(317, 127);
            this.txtPostalCode.MaxLength = 0;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPostalCode.Size = new System.Drawing.Size(73, 20);
            this.txtPostalCode.TabIndex = 14;
            // 
            // txtProvince
            // 
            this.txtProvince.AcceptsReturn = true;
            this.txtProvince.BackColor = System.Drawing.SystemColors.Window;
            this.txtProvince.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProvince.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProvince.Location = new System.Drawing.Point(223, 127);
            this.txtProvince.MaxLength = 0;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProvince.Size = new System.Drawing.Size(88, 20);
            this.txtProvince.TabIndex = 13;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.AcceptsReturn = true;
            this.txtFamilyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFamilyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFamilyName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFamilyName.Location = new System.Drawing.Point(319, 46);
            this.txtFamilyName.MaxLength = 0;
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.ReadOnly = true;
            this.txtFamilyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFamilyName.Size = new System.Drawing.Size(153, 20);
            this.txtFamilyName.TabIndex = 12;
            // 
            // lstFamilies
            // 
            this.lstFamilies.BackColor = System.Drawing.SystemColors.Window;
            this.lstFamilies.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstFamilies.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFamilies.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstFamilies.ItemHeight = 14;
            this.lstFamilies.Location = new System.Drawing.Point(6, 30);
            this.lstFamilies.Name = "lstFamilies";
            this.lstFamilies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstFamilies.Size = new System.Drawing.Size(142, 130);
            this.lstFamilies.TabIndex = 28;
            // 
            // txtFamilyID
            // 
            this.txtFamilyID.AcceptsReturn = true;
            this.txtFamilyID.BackColor = System.Drawing.SystemColors.Window;
            this.txtFamilyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFamilyID.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFamilyID.Location = new System.Drawing.Point(220, 46);
            this.txtFamilyID.MaxLength = 0;
            this.txtFamilyID.Name = "txtFamilyID";
            this.txtFamilyID.ReadOnly = true;
            this.txtFamilyID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFamilyID.Size = new System.Drawing.Size(89, 20);
            this.txtFamilyID.TabIndex = 11;
            // 
            // txtStreet
            // 
            this.txtStreet.AcceptsReturn = true;
            this.txtStreet.BackColor = System.Drawing.SystemColors.Window;
            this.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStreet.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStreet.Location = new System.Drawing.Point(223, 84);
            this.txtStreet.MaxLength = 0;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStreet.Size = new System.Drawing.Size(198, 20);
            this.txtStreet.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.AcceptsReturn = true;
            this.txtCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCity.Location = new System.Drawing.Point(427, 84);
            this.txtCity.MaxLength = 0;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCity.Size = new System.Drawing.Size(149, 20);
            this.txtCity.TabIndex = 9;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(220, 69);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(65, 17);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Street";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(316, 107);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(74, 17);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "Postal Code";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.SystemColors.Control;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(220, 107);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(73, 17);
            this.Label7.TabIndex = 18;
            this.Label7.Text = "Province";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(427, 69);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(81, 17);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "City";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(319, 30);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(72, 17);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Family Name";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(220, 30);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(80, 17);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Family ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpAssigned);
            this.Controls.Add(this.btnBillet);
            this.Controls.Add(this.grpUnassigned);
            this.Controls.Add(this.grpFamily);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigned)).EndInit();
            this.grpUnassigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassigned)).EndInit();
            this.grpFamily.ResumeLayout(false);
            this.grpFamily.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.GroupBox grpAssigned;
        internal System.Windows.Forms.DataGridView dgvAssigned;
        internal System.Windows.Forms.Button btnBillet;
        internal System.Windows.Forms.GroupBox grpUnassigned;
        internal System.Windows.Forms.DataGridView dgvUnassigned;
        public System.Windows.Forms.GroupBox grpFamily;
        public System.Windows.Forms.TextBox txtPostalCode;
        public System.Windows.Forms.TextBox txtProvince;
        public System.Windows.Forms.TextBox txtFamilyName;
        public System.Windows.Forms.ListBox lstFamilies;
        public System.Windows.Forms.TextBox txtFamilyID;
        public System.Windows.Forms.TextBox txtStreet;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label8;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
    }
}

