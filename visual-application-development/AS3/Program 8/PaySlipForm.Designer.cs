namespace Program8
{
    partial class PaySlipForm
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
            lblEmployeeName = new Label();
            lblHoursWorked = new Label();
            lblPayRate = new Label();
            txtboxEmployeeName = new TextBox();
            nudHoursWorked = new NumericUpDown();
            nudPayRate = new NumericUpDown();
            btnCreatePaySlip = new Button();
            lblInfo = new Label();
            btnDisplaySummary = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblDeveloper = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHoursWorked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPayRate).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(121, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(175, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Calculate Pay Slip";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(14, 67);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(97, 15);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Employee Name:";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(25, 102);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(86, 15);
            lblHoursWorked.TabIndex = 2;
            lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblPayRate
            // 
            lblPayRate.AutoSize = true;
            lblPayRate.Location = new Point(36, 141);
            lblPayRate.Name = "lblPayRate";
            lblPayRate.Size = new Size(75, 15);
            lblPayRate.TabIndex = 3;
            lblPayRate.Text = "Pay Rate ($) :";
            // 
            // txtboxEmployeeName
            // 
            txtboxEmployeeName.Location = new Point(123, 64);
            txtboxEmployeeName.Name = "txtboxEmployeeName";
            txtboxEmployeeName.Size = new Size(212, 23);
            txtboxEmployeeName.TabIndex = 4;
            // 
            // nudHoursWorked
            // 
            nudHoursWorked.DecimalPlaces = 2;
            nudHoursWorked.Location = new Point(123, 100);
            nudHoursWorked.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudHoursWorked.Name = "nudHoursWorked";
            nudHoursWorked.Size = new Size(120, 23);
            nudHoursWorked.TabIndex = 5;
            nudHoursWorked.TextAlign = HorizontalAlignment.Center;
            // 
            // nudPayRate
            // 
            nudPayRate.DecimalPlaces = 2;
            nudPayRate.Location = new Point(123, 139);
            nudPayRate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPayRate.Name = "nudPayRate";
            nudPayRate.Size = new Size(120, 23);
            nudPayRate.TabIndex = 6;
            nudPayRate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCreatePaySlip
            // 
            btnCreatePaySlip.Location = new Point(260, 102);
            btnCreatePaySlip.Name = "btnCreatePaySlip";
            btnCreatePaySlip.Size = new Size(75, 62);
            btnCreatePaySlip.TabIndex = 7;
            btnCreatePaySlip.Text = "&Create Pay Slip";
            btnCreatePaySlip.UseVisualStyleBackColor = true;
            btnCreatePaySlip.Click += btnCreatePaySlip_Click;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = SystemColors.ButtonFace;
            lblInfo.BorderStyle = BorderStyle.Fixed3D;
            lblInfo.Location = new Point(121, 251);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(214, 95);
            lblInfo.TabIndex = 8;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDisplaySummary
            // 
            btnDisplaySummary.Location = new Point(258, 177);
            btnDisplaySummary.Name = "btnDisplaySummary";
            btnDisplaySummary.Size = new Size(77, 62);
            btnDisplaySummary.TabIndex = 9;
            btnDisplaySummary.Text = "&Display Summary";
            btnDisplaySummary.UseVisualStyleBackColor = true;
            btnDisplaySummary.Click += btnDisplaySummary_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(123, 177);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(123, 216);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(175, 363);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(160, 15);
            lblDeveloper.TabIndex = 12;
            lblDeveloper.Text = "Developed by Timothy Miller";
            // 
            // PaySlipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 396);
            Controls.Add(lblDeveloper);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnDisplaySummary);
            Controls.Add(lblInfo);
            Controls.Add(btnCreatePaySlip);
            Controls.Add(nudPayRate);
            Controls.Add(nudHoursWorked);
            Controls.Add(txtboxEmployeeName);
            Controls.Add(lblPayRate);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblTitle);
            Name = "PaySlipForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudHoursWorked).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPayRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblEmployeeName;
        private Label lblHoursWorked;
        private Label lblPayRate;
        private TextBox txtboxEmployeeName;
        private NumericUpDown nudHoursWorked;
        private NumericUpDown nudPayRate;
        private Button btnCreatePaySlip;
        private Label lblInfo;
        private Button btnDisplaySummary;
        private Button btnReset;
        private Button btnExit;
        private Label lblDeveloper;
    }
}
