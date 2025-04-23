namespace Program5
{
    partial class Program5
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
            grpPaintJobInfo = new GroupBox();
            updownCostPerGallon = new NumericUpDown();
            updownArea = new NumericUpDown();
            lblCost = new Label();
            lblArea = new Label();
            lblDeveloper = new Label();
            btnCreatePaint = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpPaintJobInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updownCostPerGallon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updownArea).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(133, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Paint Job - Cost Estimator";
            // 
            // grpPaintJobInfo
            // 
            grpPaintJobInfo.Controls.Add(updownCostPerGallon);
            grpPaintJobInfo.Controls.Add(updownArea);
            grpPaintJobInfo.Controls.Add(lblCost);
            grpPaintJobInfo.Controls.Add(lblArea);
            grpPaintJobInfo.Location = new Point(26, 53);
            grpPaintJobInfo.Name = "grpPaintJobInfo";
            grpPaintJobInfo.Size = new Size(348, 126);
            grpPaintJobInfo.TabIndex = 1;
            grpPaintJobInfo.TabStop = false;
            grpPaintJobInfo.Text = "Paint Job Info:";
            // 
            // updownCostPerGallon
            // 
            updownCostPerGallon.DecimalPlaces = 2;
            updownCostPerGallon.Location = new Point(222, 73);
            updownCostPerGallon.Name = "updownCostPerGallon";
            updownCostPerGallon.Size = new Size(120, 23);
            updownCostPerGallon.TabIndex = 3;
            updownCostPerGallon.TextAlign = HorizontalAlignment.Right;
            // 
            // updownArea
            // 
            updownArea.Location = new Point(222, 36);
            updownArea.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            updownArea.Name = "updownArea";
            updownArea.Size = new Size(120, 23);
            updownArea.TabIndex = 2;
            updownArea.TextAlign = HorizontalAlignment.Right;
            updownArea.ThousandsSeparator = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(6, 75);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(134, 15);
            lblCost.TabIndex = 1;
            lblCost.Text = "Cost per gallon of paint:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(6, 38);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(176, 15);
            lblArea.TabIndex = 0;
            lblArea.Text = "Area to be painted (square feet):";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(123, 260);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(163, 15);
            lblDeveloper.TabIndex = 2;
            lblDeveloper.Text = "Developed by: Timothy Miller";
            // 
            // btnCreatePaint
            // 
            btnCreatePaint.Location = new Point(26, 197);
            btnCreatePaint.Name = "btnCreatePaint";
            btnCreatePaint.Size = new Size(100, 29);
            btnCreatePaint.TabIndex = 3;
            btnCreatePaint.Text = "Create Paint";
            btnCreatePaint.UseVisualStyleBackColor = true;
            btnCreatePaint.Click += btnCreatePaint_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(150, 197);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(274, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Program5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 303);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCreatePaint);
            Controls.Add(lblDeveloper);
            Controls.Add(grpPaintJobInfo);
            Controls.Add(lblTitle);
            Name = "Program5";
            Text = "Form1";
            grpPaintJobInfo.ResumeLayout(false);
            grpPaintJobInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updownCostPerGallon).EndInit();
            ((System.ComponentModel.ISupportInitialize)updownArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpPaintJobInfo;
        private Label lblCost;
        private Label lblArea;
        private NumericUpDown updownCostPerGallon;
        private NumericUpDown updownArea;
        private Label lblDeveloper;
        private Button btnCreatePaint;
        private Button btnReset;
        private Button btnExit;
    }
}
