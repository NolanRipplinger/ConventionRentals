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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Xbox Controller");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Playstation Controller");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Switch Controller");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Controllers", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Xbox");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Playstation");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Switch");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Consoles", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sony");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Visio");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Samsung");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Televisions", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.RentalsBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RentalsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightGray;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(229, 34);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "XboxControllersNode";
            treeNode1.Text = "Xbox Controller";
            treeNode2.Name = "PlaystationControllersNode";
            treeNode2.Text = "Playstation Controller";
            treeNode3.Name = "SwitchControllerNode";
            treeNode3.Text = "Switch Controller";
            treeNode4.Name = "ControllersNode";
            treeNode4.Text = "Controllers";
            treeNode5.Name = "XboxNode";
            treeNode5.Text = "Xbox";
            treeNode6.Name = "PlaystationNode";
            treeNode6.Text = "Playstation";
            treeNode7.Name = "SwitchNode";
            treeNode7.Text = "Switch";
            treeNode8.Name = "ConsolesNode";
            treeNode8.Text = "Consoles";
            treeNode9.Name = "SonyNode";
            treeNode9.Text = "Sony";
            treeNode10.Name = "VisioNode";
            treeNode10.Text = "Visio";
            treeNode11.Name = "SamsungNode";
            treeNode11.Text = "Samsung";
            treeNode12.Name = "TelevisionsNode";
            treeNode12.Text = "Televisions";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
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
            this.CheckOutButton.Location = new System.Drawing.Point(6, 78);
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
            this.RentalsBox.Controls.Add(this.CheckOutButton);
            this.RentalsBox.Controls.Add(this.CheckInButton);
            this.RentalsBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RentalsBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RentalsBox.Location = new System.Drawing.Point(52, 34);
            this.RentalsBox.Name = "RentalsBox";
            this.RentalsBox.Size = new System.Drawing.Size(124, 143);
            this.RentalsBox.TabIndex = 4;
            this.RentalsBox.TabStop = false;
            this.RentalsBox.Text = "Rentals";
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
            this.Text = "Convention Rental Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RentalsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.GroupBox RentalsBox;
    }
}

