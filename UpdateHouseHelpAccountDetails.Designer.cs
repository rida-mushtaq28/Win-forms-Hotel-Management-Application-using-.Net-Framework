namespace BusinessApplicationGUI
{
    partial class UpdateHouseHelpAccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateHouseHelpAccountDetails));
            this.cmbUserlist = new System.Windows.Forms.ComboBox();
            this.lblHousehelpID = new System.Windows.Forms.Label();
            this.txtHousehelpID = new System.Windows.Forms.TextBox();
            this.btnupdateID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbUserlist
            // 
            this.cmbUserlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserlist.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserlist.FormattingEnabled = true;
            this.cmbUserlist.Location = new System.Drawing.Point(63, 122);
            this.cmbUserlist.Name = "cmbUserlist";
            this.cmbUserlist.Size = new System.Drawing.Size(121, 24);
            this.cmbUserlist.TabIndex = 0;
            // 
            // lblHousehelpID
            // 
            this.lblHousehelpID.AutoSize = true;
            this.lblHousehelpID.BackColor = System.Drawing.Color.Transparent;
            this.lblHousehelpID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHousehelpID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHousehelpID.Location = new System.Drawing.Point(59, 176);
            this.lblHousehelpID.Name = "lblHousehelpID";
            this.lblHousehelpID.Size = new System.Drawing.Size(162, 19);
            this.lblHousehelpID.TabIndex = 1;
            this.lblHousehelpID.Text = "Update HouseHelp ID";
            this.lblHousehelpID.Click += new System.EventHandler(this.lblHousehelpID_Click);
            // 
            // txtHousehelpID
            // 
            this.txtHousehelpID.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHousehelpID.Location = new System.Drawing.Point(63, 198);
            this.txtHousehelpID.Name = "txtHousehelpID";
            this.txtHousehelpID.Size = new System.Drawing.Size(158, 21);
            this.txtHousehelpID.TabIndex = 2;
            this.txtHousehelpID.TextChanged += new System.EventHandler(this.txtHousehelpID_TextChanged);
            // 
            // btnupdateID
            // 
            this.btnupdateID.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateID.Location = new System.Drawing.Point(239, 248);
            this.btnupdateID.Name = "btnupdateID";
            this.btnupdateID.Size = new System.Drawing.Size(75, 23);
            this.btnupdateID.TabIndex = 3;
            this.btnupdateID.Text = "Update";
            this.btnupdateID.UseVisualStyleBackColor = true;
            this.btnupdateID.Click += new System.EventHandler(this.btnupdateID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select HouseHelp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(264, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Update HouseHelp Details";
            // 
            // UpdateHouseHelpAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdateID);
            this.Controls.Add(this.txtHousehelpID);
            this.Controls.Add(this.lblHousehelpID);
            this.Controls.Add(this.cmbUserlist);
            this.Name = "UpdateHouseHelpAccountDetails";
            this.Text = "UpdateHouseHelpAccountDetails";
            this.Load += new System.EventHandler(this.UpdateHouseHelpAccountDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserlist;
        private System.Windows.Forms.Label lblHousehelpID;
        private System.Windows.Forms.TextBox txtHousehelpID;
        private System.Windows.Forms.Button btnupdateID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}