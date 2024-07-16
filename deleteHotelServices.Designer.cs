namespace BusinessApplicationGUI
{
    partial class deleteHotelServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteHotelServices));
            this.cmbServicesList = new System.Windows.Forms.ComboBox();
            this.btnDeleteServices = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbServicesList
            // 
            this.cmbServicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicesList.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicesList.FormattingEnabled = true;
            this.cmbServicesList.Location = new System.Drawing.Point(32, 149);
            this.cmbServicesList.Name = "cmbServicesList";
            this.cmbServicesList.Size = new System.Drawing.Size(244, 24);
            this.cmbServicesList.TabIndex = 0;
            this.cmbServicesList.SelectedIndexChanged += new System.EventHandler(this.cmbServicesList_SelectedIndexChanged);
            // 
            // btnDeleteServices
            // 
            this.btnDeleteServices.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteServices.Location = new System.Drawing.Point(253, 203);
            this.btnDeleteServices.Name = "btnDeleteServices";
            this.btnDeleteServices.Size = new System.Drawing.Size(89, 27);
            this.btnDeleteServices.TabIndex = 1;
            this.btnDeleteServices.Text = "Delete";
            this.btnDeleteServices.UseVisualStyleBackColor = true;
            this.btnDeleteServices.Click += new System.EventHandler(this.btnDeleteServices_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdd.Location = new System.Drawing.Point(235, 48);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(246, 31);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Delete Hotel Servie";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select The Room Which You Want to Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteHotelServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnDeleteServices);
            this.Controls.Add(this.cmbServicesList);
            this.Name = "deleteHotelServices";
            this.Text = "deleteHotelServices";
            this.Load += new System.EventHandler(this.deleteHotelServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbServicesList;
        private System.Windows.Forms.Button btnDeleteServices;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label1;
    }
}