namespace BusinessApplicationGUI
{
    partial class AddHoteldetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHoteldetails));
            this.AddHotelServices = new System.Windows.Forms.Label();
            this.TypeofRoom = new System.Windows.Forms.Label();
            this.PriceOfroom = new System.Windows.Forms.Label();
            this.txtTypeOfRoom = new System.Windows.Forms.TextBox();
            this.AddHotelServicesIntoList = new System.Windows.Forms.Button();
            this.txtPriceofroom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddHotelServices
            // 
            this.AddHotelServices.AutoSize = true;
            this.AddHotelServices.BackColor = System.Drawing.Color.Transparent;
            this.AddHotelServices.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHotelServices.ForeColor = System.Drawing.Color.Transparent;
            this.AddHotelServices.Location = new System.Drawing.Point(256, 39);
            this.AddHotelServices.Name = "AddHotelServices";
            this.AddHotelServices.Size = new System.Drawing.Size(242, 31);
            this.AddHotelServices.TabIndex = 0;
            this.AddHotelServices.Text = "Add Hotel Services";
            // 
            // TypeofRoom
            // 
            this.TypeofRoom.AutoSize = true;
            this.TypeofRoom.BackColor = System.Drawing.Color.Transparent;
            this.TypeofRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeofRoom.ForeColor = System.Drawing.SystemColors.Control;
            this.TypeofRoom.Location = new System.Drawing.Point(70, 92);
            this.TypeofRoom.Name = "TypeofRoom";
            this.TypeofRoom.Size = new System.Drawing.Size(123, 20);
            this.TypeofRoom.TabIndex = 1;
            this.TypeofRoom.Text = "Type Of Room";
            this.TypeofRoom.Click += new System.EventHandler(this.TypeofRoom_Click);
            // 
            // PriceOfroom
            // 
            this.PriceOfroom.AutoSize = true;
            this.PriceOfroom.BackColor = System.Drawing.Color.Transparent;
            this.PriceOfroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceOfroom.ForeColor = System.Drawing.SystemColors.Control;
            this.PriceOfroom.Location = new System.Drawing.Point(70, 176);
            this.PriceOfroom.Name = "PriceOfroom";
            this.PriceOfroom.Size = new System.Drawing.Size(125, 20);
            this.PriceOfroom.TabIndex = 2;
            this.PriceOfroom.Text = "Price Of Room";
            // 
            // txtTypeOfRoom
            // 
            this.txtTypeOfRoom.Location = new System.Drawing.Point(72, 125);
            this.txtTypeOfRoom.Name = "txtTypeOfRoom";
            this.txtTypeOfRoom.Size = new System.Drawing.Size(185, 20);
            this.txtTypeOfRoom.TabIndex = 5;
            // 
            // AddHotelServicesIntoList
            // 
            this.AddHotelServicesIntoList.BackColor = System.Drawing.Color.Transparent;
            this.AddHotelServicesIntoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHotelServicesIntoList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddHotelServicesIntoList.Location = new System.Drawing.Point(262, 257);
            this.AddHotelServicesIntoList.Name = "AddHotelServicesIntoList";
            this.AddHotelServicesIntoList.Size = new System.Drawing.Size(62, 27);
            this.AddHotelServicesIntoList.TabIndex = 9;
            this.AddHotelServicesIntoList.Text = "Add";
            this.AddHotelServicesIntoList.UseVisualStyleBackColor = false;
            this.AddHotelServicesIntoList.Click += new System.EventHandler(this.AddHotelServicesIntoList_Click);
            // 
            // txtPriceofroom
            // 
            this.txtPriceofroom.Location = new System.Drawing.Point(72, 210);
            this.txtPriceofroom.Name = "txtPriceofroom";
            this.txtPriceofroom.Size = new System.Drawing.Size(191, 20);
            this.txtPriceofroom.TabIndex = 7;
            // 
            // AddHoteldetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddHotelServicesIntoList);
            this.Controls.Add(this.txtPriceofroom);
            this.Controls.Add(this.txtTypeOfRoom);
            this.Controls.Add(this.PriceOfroom);
            this.Controls.Add(this.TypeofRoom);
            this.Controls.Add(this.AddHotelServices);
            this.Name = "AddHoteldetails";
            this.Text = "AddHoteldetails";
            this.Load += new System.EventHandler(this.AddHoteldetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddHotelServices;
        private System.Windows.Forms.Label TypeofRoom;
        private System.Windows.Forms.Label PriceOfroom;
        private System.Windows.Forms.TextBox txtTypeOfRoom;
        private System.Windows.Forms.Button AddHotelServicesIntoList;
        private System.Windows.Forms.TextBox txtPriceofroom;
    }
}