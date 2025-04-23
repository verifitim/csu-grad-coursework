namespace Program6
{
    partial class BMIForm
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
            grpUser = new GroupBox();
            btnCalculateBMI = new Button();
            nudHeight = new NumericUpDown();
            nudWeight = new NumericUpDown();
            txtName = new TextBox();
            lblHeight = new Label();
            lblWeight = new Label();
            lblName = new Label();
            lblDeveloper = new Label();
            btnExit = new Button();
            btnReset = new Button();
            lblOutput = new Label();
            grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(82, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BMI Calculator";
            // 
            // grpUser
            // 
            grpUser.Controls.Add(btnCalculateBMI);
            grpUser.Controls.Add(nudHeight);
            grpUser.Controls.Add(nudWeight);
            grpUser.Controls.Add(txtName);
            grpUser.Controls.Add(lblHeight);
            grpUser.Controls.Add(lblWeight);
            grpUser.Controls.Add(lblName);
            grpUser.Location = new Point(21, 52);
            grpUser.Name = "grpUser";
            grpUser.Size = new Size(313, 222);
            grpUser.TabIndex = 1;
            grpUser.TabStop = false;
            grpUser.Text = "Your Info:";
            // 
            // btnCalculateBMI
            // 
            btnCalculateBMI.Location = new Point(123, 169);
            btnCalculateBMI.Name = "btnCalculateBMI";
            btnCalculateBMI.Size = new Size(175, 30);
            btnCalculateBMI.TabIndex = 6;
            btnCalculateBMI.Text = "Calculate BMI";
            btnCalculateBMI.UseVisualStyleBackColor = true;
            btnCalculateBMI.Click += btnCalculateBMI_Click;
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(123, 123);
            nudHeight.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(175, 23);
            nudHeight.TabIndex = 5;
            nudHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(123, 77);
            nudWeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(175, 23);
            nudWeight.TabIndex = 4;
            nudWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 3;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(6, 126);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(101, 15);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height (in Inches)";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(6, 80);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(84, 15);
            lblWeight.TabIndex = 1;
            lblWeight.Text = "Weight (in lbs)";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(97, 378);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(160, 15);
            lblDeveloper.TabIndex = 2;
            lblDeveloper.Text = "Developed by Timothy Miller";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(21, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 30);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(21, 286);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 30);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(152, 286);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(182, 79);
            lblOutput.TabIndex = 4;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 412);
            Controls.Add(btnExit);
            Controls.Add(lblOutput);
            Controls.Add(btnReset);
            Controls.Add(lblDeveloper);
            Controls.Add(grpUser);
            Controls.Add(lblTitle);
            Name = "BMIForm";
            Text = "Form1";
            grpUser.ResumeLayout(false);
            grpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpUser;
        private TextBox txtName;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblName;
        private NumericUpDown nudHeight;
        private NumericUpDown nudWeight;
        private Label lblDeveloper;
        private Button btnCalculateBMI;
        private Button btnReset;
        private Label lblOutput;
        private Button btnExit;
    }
}
