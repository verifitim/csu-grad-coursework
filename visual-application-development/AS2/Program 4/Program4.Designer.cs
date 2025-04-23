namespace Program4
{
    partial class Program4
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
            grpLoanInfo = new GroupBox();
            updownRate = new NumericUpDown();
            updownDuration = new NumericUpDown();
            updownAmount = new NumericUpDown();
            lblRate = new Label();
            lblDuration = new Label();
            lblAmount = new Label();
            btnPayment = new Button();
            lblPayment = new Label();
            btnReset = new Button();
            btnExit = new Button();
            grpLoanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updownRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updownAmount).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(97, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Monthly Payment Calculator";
            // 
            // grpLoanInfo
            // 
            grpLoanInfo.Controls.Add(updownRate);
            grpLoanInfo.Controls.Add(updownDuration);
            grpLoanInfo.Controls.Add(updownAmount);
            grpLoanInfo.Controls.Add(lblRate);
            grpLoanInfo.Controls.Add(lblDuration);
            grpLoanInfo.Controls.Add(lblAmount);
            grpLoanInfo.Location = new Point(27, 59);
            grpLoanInfo.Name = "grpLoanInfo";
            grpLoanInfo.Size = new Size(300, 178);
            grpLoanInfo.TabIndex = 1;
            grpLoanInfo.TabStop = false;
            grpLoanInfo.Text = "Loan Info:";
            // 
            // updownRate
            // 
            updownRate.DecimalPlaces = 2;
            updownRate.Location = new Point(165, 139);
            updownRate.Name = "updownRate";
            updownRate.Size = new Size(120, 23);
            updownRate.TabIndex = 5;
            updownRate.TextAlign = HorizontalAlignment.Right;
            // 
            // updownDuration
            // 
            updownDuration.Location = new Point(165, 87);
            updownDuration.Name = "updownDuration";
            updownDuration.Size = new Size(120, 23);
            updownDuration.TabIndex = 4;
            updownDuration.TextAlign = HorizontalAlignment.Right;
            // 
            // updownAmount
            // 
            updownAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            updownAmount.Location = new Point(165, 40);
            updownAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            updownAmount.Name = "updownAmount";
            updownAmount.Size = new Size(120, 23);
            updownAmount.TabIndex = 3;
            updownAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(6, 141);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(116, 15);
            lblRate.TabIndex = 2;
            lblRate.Text = "Annual Interest Rate:";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(6, 89);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(137, 15);
            lblDuration.TabIndex = 1;
            lblDuration.Text = "Loan Duration (months):";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(6, 42);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Loan Amount:";
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(27, 265);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(115, 29);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Monthly Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblPayment
            // 
            lblPayment.BorderStyle = BorderStyle.Fixed3D;
            lblPayment.Location = new Point(192, 265);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(135, 29);
            lblPayment.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(27, 317);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(192, 317);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Program4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 374);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(lblPayment);
            Controls.Add(btnPayment);
            Controls.Add(grpLoanInfo);
            Controls.Add(lblTitle);
            Name = "Program4";
            Text = "Assignment Set 2 - Program 4";
            grpLoanInfo.ResumeLayout(false);
            grpLoanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updownRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)updownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)updownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpLoanInfo;
        private Label lblRate;
        private Label lblDuration;
        private Label lblAmount;
        private NumericUpDown updownRate;
        private NumericUpDown updownDuration;
        private NumericUpDown updownAmount;
        private Button btnPayment;
        private Label lblPayment;
        private Button btnReset;
        private Button btnExit;
    }
}
