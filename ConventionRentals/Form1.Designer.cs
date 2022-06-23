namespace ConventionRentals
{
    partial class RentalForm
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Xbox Controller");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Playstation Controller");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Switch Controller");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Controllers", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Xbox");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Playstation");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Switch");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Consoles", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Sony");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Visio");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Samsung");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Televisions", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.RentalsBox = new System.Windows.Forms.GroupBox();
            this.StockBox = new System.Windows.Forms.GroupBox();
            this.StockButton = new System.Windows.Forms.Button();
            this.OutstandingRentalsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RentalsBox.SuspendLayout();
            this.StockBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightGray;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(229, 34);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "XboxControllersNode";
            treeNode13.Text = "Xbox Controller";
            treeNode14.Name = "PlaystationControllersNode";
            treeNode14.Text = "Playstation Controller";
            treeNode15.Name = "SwitchControllerNode";
            treeNode15.Text = "Switch Controller";
            treeNode16.Name = "ControllersNode";
            treeNode16.Text = "Controllers";
            treeNode17.Name = "XboxNode";
            treeNode17.Text = "Xbox";
            treeNode18.Name = "PlaystationNode";
            treeNode18.Text = "Playstation";
            treeNode19.Name = "SwitchNode";
            treeNode19.Text = "Switch";
            treeNode20.Name = "ConsolesNode";
            treeNode20.Text = "Consoles";
            treeNode21.Name = "SonyNode";
            treeNode21.Text = "Sony";
            treeNode22.Name = "VisioNode";
            treeNode22.Text = "Visio";
            treeNode23.Name = "SamsungNode";
            treeNode23.Text = "Samsung";
            treeNode24.Name = "TelevisionsNode";
            treeNode24.Text = "Televisions";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(275, 382);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CheckInButton
            // 
            this.CheckInButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckInButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CheckInButton.Location = new System.Drawing.Point(6, 19);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(112, 40);
            this.CheckInButton.TabIndex = 2;
            this.CheckInButton.Text = "Check In Selected";
            this.CheckInButton.UseVisualStyleBackColor = false;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.White;
            this.CheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckOutButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckOutButton.Location = new System.Drawing.Point(6, 74);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(112, 46);
            this.CheckOutButton.TabIndex = 3;
            this.CheckOutButton.Text = "Check Out Selected";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // RentalsBox
            // 
            this.RentalsBox.AutoSize = true;
            this.RentalsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentalsBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RentalsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RentalsBox.Controls.Add(this.StockBox);
            this.RentalsBox.Controls.Add(this.CheckOutButton);
            this.RentalsBox.Controls.Add(this.CheckInButton);
            this.RentalsBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RentalsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalsBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RentalsBox.Location = new System.Drawing.Point(52, 34);
            this.RentalsBox.Name = "RentalsBox";
            this.RentalsBox.Size = new System.Drawing.Size(130, 367);
            this.RentalsBox.TabIndex = 4;
            this.RentalsBox.TabStop = false;
            this.RentalsBox.Text = "Rentals";
            this.RentalsBox.Enter += new System.EventHandler(this.RentalsBox_Enter);
            // 
            // StockBox
            // 
            this.StockBox.Controls.Add(this.OutstandingRentalsButton);
            this.StockBox.Controls.Add(this.StockButton);
            this.StockBox.Location = new System.Drawing.Point(0, 181);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(124, 161);
            this.StockBox.TabIndex = 5;
            this.StockBox.TabStop = false;
            this.StockBox.Text = "Stock";
            this.StockBox.Enter += new System.EventHandler(this.StockBox_Enter);
            // 
            // StockButton
            // 
            this.StockButton.BackColor = System.Drawing.Color.White;
            this.StockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StockButton.Location = new System.Drawing.Point(6, 25);
            this.StockButton.Name = "StockButton";
            this.StockButton.Size = new System.Drawing.Size(112, 52);
            this.StockButton.TabIndex = 0;
            this.StockButton.Text = "Current Stock";
            this.StockButton.UseVisualStyleBackColor = false;
            // 
            // OutstandingRentalsButton
            // 
            this.OutstandingRentalsButton.BackColor = System.Drawing.Color.White;
            this.OutstandingRentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OutstandingRentalsButton.Location = new System.Drawing.Point(6, 99);
            this.OutstandingRentalsButton.Name = "OutstandingRentalsButton";
            this.OutstandingRentalsButton.Size = new System.Drawing.Size(112, 56);
            this.OutstandingRentalsButton.TabIndex = 1;
            this.OutstandingRentalsButton.Text = "Outstanding Rentals";
            this.OutstandingRentalsButton.UseVisualStyleBackColor = false;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RentalsBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convention Rental Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RentalsBox.ResumeLayout(false);
            this.StockBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.GroupBox RentalsBox;
        private System.Windows.Forms.GroupBox StockBox;
        private System.Windows.Forms.Button StockButton;
        private System.Windows.Forms.Button OutstandingRentalsButton;
    }
}

