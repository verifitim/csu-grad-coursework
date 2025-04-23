namespace Program7
{
    partial class TruckRentalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpRentalInfo = new GroupBox();
            btnCalculateCost = new Button();
            lblRentalCharge = new Label();
            nudNumDays = new NumericUpDown();
            nudEndMiles = new NumericUpDown();
            nudBeginMiles = new NumericUpDown();
            txtCustomerName = new TextBox();
            lblNumDays = new Label();
            lblEndMiles = new Label();
            lblBeginMiles = new Label();
            lblCustomerName = new Label();
            btnExit = new Button();
            btnReset = new Button();
            lblDeveloper = new Label();
            grpRentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndMiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBeginMiles).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rental Car Cost Calculator";
            // 
            // grpRentalInfo
            // 
            grpRentalInfo.Controls.Add(btnCalculateCost);
            grpRentalInfo.Controls.Add(lblRentalCharge);
            grpRentalInfo.Controls.Add(nudNumDays);
            grpRentalInfo.Controls.Add(nudEndMiles);
            grpRentalInfo.Controls.Add(nudBeginMiles);
            grpRentalInfo.Controls.Add(txtCustomerName);
            grpRentalInfo.Controls.Add(lblNumDays);
            grpRentalInfo.Controls.Add(lblEndMiles);
            grpRentalInfo.Controls.Add(lblBeginMiles);
            grpRentalInfo.Controls.Add(lblCustomerName);
            grpRentalInfo.Location = new Point(12, 62);
            grpRentalInfo.Name = "grpRentalInfo";
            grpRentalInfo.Size = new Size(320, 228);
            grpRentalInfo.TabIndex = 1;
            grpRentalInfo.TabStop = false;
            grpRentalInfo.Text = "Rental Info:";
            // 
            // btnCalculateCost
            // 
            btnCalculateCost.Location = new Point(17, 178);
            btnCalculateCost.Name = "btnCalculateCost";
            btnCalculateCost.Size = new Size(130, 33);
            btnCalculateCost.TabIndex = 9;
            btnCalculateCost.Text = "&Calculate Cost";
            btnCalculateCost.UseVisualStyleBackColor = true;
            btnCalculateCost.Click += btnCalculateCost_Click;
            // 
            // lblRentalCharge
            // 
            lblRentalCharge.BorderStyle = BorderStyle.Fixed3D;
            lblRentalCharge.Location = new Point(173, 178);
            lblRentalCharge.Name = "lblRentalCharge";
            lblRentalCharge.Size = new Size(130, 31);
            lblRentalCharge.TabIndex = 8;
            lblRentalCharge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudNumDays
            // 
            nudNumDays.Location = new Point(183, 134);
            nudNumDays.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            nudNumDays.Name = "nudNumDays";
            nudNumDays.Size = new Size(120, 23);
            nudNumDays.TabIndex = 7;
            nudNumDays.TextAlign = HorizontalAlignment.Center;
            // 
            // nudEndMiles
            // 
            nudEndMiles.Location = new Point(183, 96);
            nudEndMiles.Maximum = new decimal(new int[] { 800000, 0, 0, 0 });
            nudEndMiles.Name = "nudEndMiles";
            nudEndMiles.Size = new Size(120, 23);
            nudEndMiles.TabIndex = 6;
            nudEndMiles.TextAlign = HorizontalAlignment.Center;
            nudEndMiles.ThousandsSeparator = true;
            // 
            // nudBeginMiles
            // 
            nudBeginMiles.Location = new Point(183, 60);
            nudBeginMiles.Maximum = new decimal(new int[] { 400000, 0, 0, 0 });
            nudBeginMiles.Name = "nudBeginMiles";
            nudBeginMiles.Size = new Size(120, 23);
            nudBeginMiles.TabIndex = 5;
            nudBeginMiles.TextAlign = HorizontalAlignment.Center;
            nudBeginMiles.ThousandsSeparator = true;
            nudBeginMiles.ValueChanged += nudBeginMiles_ValueChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(59, 26);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(244, 23);
            txtCustomerName.TabIndex = 4;
            // 
            // lblNumDays
            // 
            lblNumDays.AutoSize = true;
            lblNumDays.Location = new Point(11, 136);
            lblNumDays.Name = "lblNumDays";
            lblNumDays.Size = new Size(136, 15);
            lblNumDays.TabIndex = 3;
            lblNumDays.Text = "Number of Days Rented:";
            // 
            // lblEndMiles
            // 
            lblEndMiles.AutoSize = true;
            lblEndMiles.Location = new Point(11, 98);
            lblEndMiles.Name = "lblEndMiles";
            lblEndMiles.Size = new Size(150, 15);
            lblEndMiles.TabIndex = 2;
            lblEndMiles.Text = "Ending Odometer Reading:";
            // 
            // lblBeginMiles
            // 
            lblBeginMiles.AutoSize = true;
            lblBeginMiles.Location = new Point(11, 62);
            lblBeginMiles.Name = "lblBeginMiles";
            lblBeginMiles.Size = new Size(167, 15);
            lblBeginMiles.TabIndex = 1;
            lblBeginMiles.Text = "Beginning Odometer Reading:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(11, 29);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(42, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Name:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(29, 344);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 33);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(29, 296);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 33);
            btnReset.TabIndex = 3;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(177, 353);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(160, 15);
            lblDeveloper.TabIndex = 4;
            lblDeveloper.Text = "Developed by Timothy Miller";
            // 
            // TruckRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 387);
            Controls.Add(lblDeveloper);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(grpRentalInfo);
            Controls.Add(lblTitle);
            Name = "TruckRentalForm";
            Text = "Form1";
            grpRentalInfo.ResumeLayout(false);
            grpRentalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndMiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBeginMiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpRentalInfo;
        private TextBox txtCustomerName;
        private Label lblNumDays;
        private Label lblEndMiles;
        private Label lblBeginMiles;
        private Label lblCustomerName;
        private NumericUpDown nudNumDays;
        private NumericUpDown nudEndMiles;
        private NumericUpDown nudBeginMiles;
        private Label lblRentalCharge;
        private Button btnCalculateCost;
        private Button btnExit;
        private Button btnReset;
        private Label lblDeveloper;
    }
}
