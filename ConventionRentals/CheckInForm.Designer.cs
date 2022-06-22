namespace ConventionRentals
{
    partial class CheckInForm
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
            this.CheckInID = new System.Windows.Forms.TextBox();
            this.CheckInIDLabel = new System.Windows.Forms.Label();
            this.CheckInTime = new System.Windows.Forms.DateTimePicker();
            this.CheckInTimeLabel = new System.Windows.Forms.Label();
            this.CheckInNumLabel = new System.Windows.Forms.Label();
            this.CheckInAmount = new System.Windows.Forms.NumericUpDown();
            this.CheckInSubmit = new System.Windows.Forms.Button();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.CheckInItemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckInID
            // 
            this.CheckInID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CheckInID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInID.HideSelection = false;
            this.CheckInID.Location = new System.Drawing.Point(222, 37);
            this.CheckInID.MaxLength = 100;
            this.CheckInID.Name = "CheckInID";
            this.CheckInID.Size = new System.Drawing.Size(225, 31);
            this.CheckInID.TabIndex = 0;
            this.CheckInID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckInIDLabel
            // 
            this.CheckInIDLabel.AutoSize = true;
            this.CheckInIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInIDLabel.Location = new System.Drawing.Point(12, 37);
            this.CheckInIDLabel.Name = "CheckInIDLabel";
            this.CheckInIDLabel.Size = new System.Drawing.Size(147, 25);
            this.CheckInIDLabel.TabIndex = 1;
            this.CheckInIDLabel.Text = "Convention ID";
            // 
            // CheckInTime
            // 
            this.CheckInTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInTime.CustomFormat = "h:mm tt, MMM dd yyyy";
            this.CheckInTime.Enabled = false;
            this.CheckInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckInTime.Location = new System.Drawing.Point(222, 252);
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Size = new System.Drawing.Size(225, 26);
            this.CheckInTime.TabIndex = 2;
            this.CheckInTime.Value = new System.DateTime(2022, 6, 21, 19, 13, 5, 0);
            // 
            // CheckInTimeLabel
            // 
            this.CheckInTimeLabel.AutoSize = true;
            this.CheckInTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInTimeLabel.Location = new System.Drawing.Point(12, 252);
            this.CheckInTimeLabel.Name = "CheckInTimeLabel";
            this.CheckInTimeLabel.Size = new System.Drawing.Size(200, 25);
            this.CheckInTimeLabel.TabIndex = 3;
            this.CheckInTimeLabel.Text = "Check In Date/Time";
            // 
            // CheckInNumLabel
            // 
            this.CheckInNumLabel.AutoSize = true;
            this.CheckInNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInNumLabel.Location = new System.Drawing.Point(11, 173);
            this.CheckInNumLabel.Name = "CheckInNumLabel";
            this.CheckInNumLabel.Size = new System.Drawing.Size(201, 25);
            this.CheckInNumLabel.TabIndex = 4;
            this.CheckInNumLabel.Text = "Number Checked In";
            // 
            // CheckInAmount
            // 
            this.CheckInAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInAmount.Location = new System.Drawing.Point(222, 171);
            this.CheckInAmount.Name = "CheckInAmount";
            this.CheckInAmount.Size = new System.Drawing.Size(225, 31);
            this.CheckInAmount.TabIndex = 5;
            this.CheckInAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckInSubmit
            // 
            this.CheckInSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckInSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInSubmit.Location = new System.Drawing.Point(178, 321);
            this.CheckInSubmit.Name = "CheckInSubmit";
            this.CheckInSubmit.Size = new System.Drawing.Size(100, 53);
            this.CheckInSubmit.TabIndex = 6;
            this.CheckInSubmit.Text = "Submit";
            this.CheckInSubmit.UseVisualStyleBackColor = true;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(12, 108);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(114, 25);
            this.ItemNameLabel.TabIndex = 7;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // CheckInItemName
            // 
            this.CheckInItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckInItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInItemName.Location = new System.Drawing.Point(222, 108);
            this.CheckInItemName.MaxLength = 100;
            this.CheckInItemName.Name = "CheckInItemName";
            this.CheckInItemName.ReadOnly = true;
            this.CheckInItemName.Size = new System.Drawing.Size(225, 31);
            this.CheckInItemName.TabIndex = 8;
            this.CheckInItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(459, 386);
            this.Controls.Add(this.CheckInItemName);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.CheckInSubmit);
            this.Controls.Add(this.CheckInAmount);
            this.Controls.Add(this.CheckInNumLabel);
            this.Controls.Add(this.CheckInTimeLabel);
            this.Controls.Add(this.CheckInTime);
            this.Controls.Add(this.CheckInIDLabel);
            this.Controls.Add(this.CheckInID);
            this.Enabled = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            ((System.ComponentModel.ISupportInitialize)(this.CheckInAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CheckInID;
        private System.Windows.Forms.Label CheckInIDLabel;
        private System.Windows.Forms.DateTimePicker CheckInTime;
        private System.Windows.Forms.Label CheckInTimeLabel;
        private System.Windows.Forms.Label CheckInNumLabel;
        private System.Windows.Forms.NumericUpDown CheckInAmount;
        private System.Windows.Forms.Button CheckInSubmit;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox CheckInItemName;
    }
}