namespace Program11
{
    partial class WaterTankForm
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
            grpWaterData = new GroupBox();
            lblMax = new Label();
            lblCurrent = new Label();
            btnMax = new Button();
            btnCurrent = new Button();
            grpFillDrain = new GroupBox();
            txtFillDrainResult = new TextBox();
            btnFillDrain = new Button();
            lblFillDrain = new Label();
            radDrain = new RadioButton();
            radFill = new RadioButton();
            nudFillDrain = new NumericUpDown();
            grpIncreaseReduce = new GroupBox();
            lblResult = new Label();
            btnAddWithdraw = new Button();
            lblIncreaseReduce = new Label();
            radWithdraw = new RadioButton();
            radAdd = new RadioButton();
            nudAddWithdraw = new NumericUpDown();
            lblTitle = new Label();
            grpTriggers = new GroupBox();
            btnReset = new Button();
            btnExit = new Button();
            grpWaterTankData = new GroupBox();
            nudDepth = new NumericUpDown();
            lblTankDepth = new Label();
            nudRadius = new NumericUpDown();
            btnCreate = new Button();
            lblTankRadius = new Label();
            lblDeveloper = new Label();
            grpWaterData.SuspendLayout();
            grpFillDrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFillDrain).BeginInit();
            grpIncreaseReduce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddWithdraw).BeginInit();
            grpTriggers.SuspendLayout();
            grpWaterTankData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRadius).BeginInit();
            SuspendLayout();
            // 
            // grpWaterData
            // 
            grpWaterData.Controls.Add(lblMax);
            grpWaterData.Controls.Add(lblCurrent);
            grpWaterData.Controls.Add(btnMax);
            grpWaterData.Controls.Add(btnCurrent);
            grpWaterData.Enabled = false;
            grpWaterData.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpWaterData.Location = new Point(16, 314);
            grpWaterData.Margin = new Padding(3, 2, 3, 2);
            grpWaterData.Name = "grpWaterData";
            grpWaterData.Padding = new Padding(3, 2, 3, 2);
            grpWaterData.Size = new Size(380, 101);
            grpWaterData.TabIndex = 20;
            grpWaterData.TabStop = false;
            grpWaterData.Text = "Water Data:";
            // 
            // lblMax
            // 
            lblMax.BorderStyle = BorderStyle.Fixed3D;
            lblMax.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblMax.Location = new Point(171, 62);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(190, 28);
            lblMax.TabIndex = 3;
            // 
            // lblCurrent
            // 
            lblCurrent.BorderStyle = BorderStyle.Fixed3D;
            lblCurrent.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblCurrent.Location = new Point(171, 30);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(190, 28);
            lblCurrent.TabIndex = 2;
            // 
            // btnMax
            // 
            btnMax.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnMax.Location = new Point(8, 62);
            btnMax.Margin = new Padding(3, 2, 3, 2);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(155, 28);
            btnMax.TabIndex = 1;
            btnMax.Text = "Maximum Water Level";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnCurrent
            // 
            btnCurrent.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCurrent.Location = new Point(8, 30);
            btnCurrent.Margin = new Padding(3, 2, 3, 2);
            btnCurrent.Name = "btnCurrent";
            btnCurrent.Size = new Size(155, 28);
            btnCurrent.TabIndex = 0;
            btnCurrent.Text = "Current Water Level";
            btnCurrent.UseVisualStyleBackColor = true;
            btnCurrent.Click += btnCurrent_Click;
            // 
            // grpFillDrain
            // 
            grpFillDrain.Controls.Add(txtFillDrainResult);
            grpFillDrain.Controls.Add(btnFillDrain);
            grpFillDrain.Controls.Add(lblFillDrain);
            grpFillDrain.Controls.Add(radDrain);
            grpFillDrain.Controls.Add(radFill);
            grpFillDrain.Controls.Add(nudFillDrain);
            grpFillDrain.Enabled = false;
            grpFillDrain.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpFillDrain.Location = new Point(402, 40);
            grpFillDrain.Margin = new Padding(3, 2, 3, 2);
            grpFillDrain.Name = "grpFillDrain";
            grpFillDrain.Padding = new Padding(3, 2, 3, 2);
            grpFillDrain.Size = new Size(364, 443);
            grpFillDrain.TabIndex = 19;
            grpFillDrain.TabStop = false;
            grpFillDrain.Text = "Fill/Drain Water:";
            // 
            // txtFillDrainResult
            // 
            txtFillDrainResult.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtFillDrainResult.Location = new Point(11, 85);
            txtFillDrainResult.Margin = new Padding(3, 2, 3, 2);
            txtFillDrainResult.Multiline = true;
            txtFillDrainResult.Name = "txtFillDrainResult";
            txtFillDrainResult.ScrollBars = ScrollBars.Vertical;
            txtFillDrainResult.Size = new Size(347, 347);
            txtFillDrainResult.TabIndex = 16;
            // 
            // btnFillDrain
            // 
            btnFillDrain.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnFillDrain.Location = new Point(221, 49);
            btnFillDrain.Margin = new Padding(3, 2, 3, 2);
            btnFillDrain.Name = "btnFillDrain";
            btnFillDrain.Size = new Size(137, 28);
            btnFillDrain.TabIndex = 15;
            btnFillDrain.Text = "Fill/Drain";
            btnFillDrain.UseVisualStyleBackColor = true;
            btnFillDrain.Click += btnFillDrain_Click;
            // 
            // lblFillDrain
            // 
            lblFillDrain.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblFillDrain.Location = new Point(110, 24);
            lblFillDrain.Name = "lblFillDrain";
            lblFillDrain.Size = new Size(109, 17);
            lblFillDrain.TabIndex = 14;
            lblFillDrain.Text = "Litres/Second:";
            // 
            // radDrain
            // 
            radDrain.AutoSize = true;
            radDrain.Font = new Font("Microsoft Sans Serif", 9.75F);
            radDrain.Location = new Point(11, 53);
            radDrain.Margin = new Padding(3, 2, 3, 2);
            radDrain.Name = "radDrain";
            radDrain.Size = new Size(57, 20);
            radDrain.TabIndex = 1;
            radDrain.Text = "Drain";
            radDrain.UseVisualStyleBackColor = true;
            // 
            // radFill
            // 
            radFill.AutoSize = true;
            radFill.Checked = true;
            radFill.Font = new Font("Microsoft Sans Serif", 9.75F);
            radFill.Location = new Point(11, 22);
            radFill.Margin = new Padding(3, 2, 3, 2);
            radFill.Name = "radFill";
            radFill.Size = new Size(42, 20);
            radFill.TabIndex = 0;
            radFill.TabStop = true;
            radFill.Text = "Fill";
            radFill.UseVisualStyleBackColor = true;
            // 
            // nudFillDrain
            // 
            nudFillDrain.Font = new Font("Microsoft Sans Serif", 9.75F);
            nudFillDrain.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFillDrain.Location = new Point(221, 22);
            nudFillDrain.Margin = new Padding(3, 2, 3, 2);
            nudFillDrain.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudFillDrain.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFillDrain.Name = "nudFillDrain";
            nudFillDrain.Size = new Size(137, 22);
            nudFillDrain.TabIndex = 13;
            nudFillDrain.TextAlign = HorizontalAlignment.Right;
            nudFillDrain.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // grpIncreaseReduce
            // 
            grpIncreaseReduce.Controls.Add(lblResult);
            grpIncreaseReduce.Controls.Add(btnAddWithdraw);
            grpIncreaseReduce.Controls.Add(lblIncreaseReduce);
            grpIncreaseReduce.Controls.Add(radWithdraw);
            grpIncreaseReduce.Controls.Add(radAdd);
            grpIncreaseReduce.Controls.Add(nudAddWithdraw);
            grpIncreaseReduce.Enabled = false;
            grpIncreaseReduce.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpIncreaseReduce.Location = new Point(16, 144);
            grpIncreaseReduce.Margin = new Padding(3, 2, 3, 2);
            grpIncreaseReduce.Name = "grpIncreaseReduce";
            grpIncreaseReduce.Padding = new Padding(3, 2, 3, 2);
            grpIncreaseReduce.Size = new Size(380, 166);
            grpIncreaseReduce.TabIndex = 18;
            grpIncreaseReduce.TabStop = false;
            grpIncreaseReduce.Text = "Increase/Reduce Water";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblResult.Location = new Point(5, 89);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(369, 66);
            lblResult.TabIndex = 13;
            // 
            // btnAddWithdraw
            // 
            btnAddWithdraw.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAddWithdraw.Location = new Point(171, 54);
            btnAddWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnAddWithdraw.Name = "btnAddWithdraw";
            btnAddWithdraw.Size = new Size(190, 24);
            btnAddWithdraw.TabIndex = 15;
            btnAddWithdraw.Text = "Add/Withdraw Water";
            btnAddWithdraw.UseVisualStyleBackColor = true;
            btnAddWithdraw.Click += btnAddWithdraw_Click;
            // 
            // lblIncreaseReduce
            // 
            lblIncreaseReduce.AutoSize = true;
            lblIncreaseReduce.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblIncreaseReduce.Location = new Point(122, 30);
            lblIncreaseReduce.Name = "lblIncreaseReduce";
            lblIncreaseReduce.Size = new Size(42, 16);
            lblIncreaseReduce.TabIndex = 14;
            lblIncreaseReduce.Text = "Litres:";
            // 
            // radWithdraw
            // 
            radWithdraw.AutoSize = true;
            radWithdraw.Font = new Font("Microsoft Sans Serif", 9.75F);
            radWithdraw.Location = new Point(8, 54);
            radWithdraw.Margin = new Padding(3, 2, 3, 2);
            radWithdraw.Name = "radWithdraw";
            radWithdraw.Size = new Size(80, 20);
            radWithdraw.TabIndex = 1;
            radWithdraw.Text = "Withdraw";
            radWithdraw.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            radAdd.AutoSize = true;
            radAdd.Checked = true;
            radAdd.Font = new Font("Microsoft Sans Serif", 9.75F);
            radAdd.Location = new Point(8, 28);
            radAdd.Margin = new Padding(3, 2, 3, 2);
            radAdd.Name = "radAdd";
            radAdd.Size = new Size(50, 20);
            radAdd.TabIndex = 0;
            radAdd.TabStop = true;
            radAdd.Text = "Add";
            radAdd.UseVisualStyleBackColor = true;
            // 
            // nudAddWithdraw
            // 
            nudAddWithdraw.Font = new Font("Microsoft Sans Serif", 9.75F);
            nudAddWithdraw.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudAddWithdraw.Location = new Point(172, 26);
            nudAddWithdraw.Margin = new Padding(3, 2, 3, 2);
            nudAddWithdraw.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudAddWithdraw.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAddWithdraw.Name = "nudAddWithdraw";
            nudAddWithdraw.Size = new Size(190, 22);
            nudAddWithdraw.TabIndex = 13;
            nudAddWithdraw.TextAlign = HorizontalAlignment.Right;
            nudAddWithdraw.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblTitle.Location = new Point(299, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 19);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Water Tank Manager";
            // 
            // grpTriggers
            // 
            grpTriggers.Controls.Add(btnReset);
            grpTriggers.Controls.Add(btnExit);
            grpTriggers.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpTriggers.Location = new Point(16, 422);
            grpTriggers.Margin = new Padding(3, 2, 3, 2);
            grpTriggers.Name = "grpTriggers";
            grpTriggers.Padding = new Padding(3, 2, 3, 2);
            grpTriggers.Size = new Size(380, 50);
            grpTriggers.TabIndex = 16;
            grpTriggers.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.DialogResult = DialogResult.Cancel;
            btnReset.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnReset.Location = new Point(5, 12);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(158, 26);
            btnReset.TabIndex = 1;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnExit.Location = new Point(171, 12);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 26);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // grpWaterTankData
            // 
            grpWaterTankData.Controls.Add(nudDepth);
            grpWaterTankData.Controls.Add(lblTankDepth);
            grpWaterTankData.Controls.Add(nudRadius);
            grpWaterTankData.Controls.Add(btnCreate);
            grpWaterTankData.Controls.Add(lblTankRadius);
            grpWaterTankData.FlatStyle = FlatStyle.Popup;
            grpWaterTankData.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpWaterTankData.Location = new Point(10, 40);
            grpWaterTankData.Margin = new Padding(3, 2, 3, 2);
            grpWaterTankData.Name = "grpWaterTankData";
            grpWaterTankData.Padding = new Padding(3, 2, 3, 2);
            grpWaterTankData.Size = new Size(386, 100);
            grpWaterTankData.TabIndex = 15;
            grpWaterTankData.TabStop = false;
            grpWaterTankData.Text = "Water Tank Data:";
            // 
            // nudDepth
            // 
            nudDepth.Font = new Font("Microsoft Sans Serif", 9.75F);
            nudDepth.Location = new Point(177, 45);
            nudDepth.Margin = new Padding(3, 2, 3, 2);
            nudDepth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDepth.Name = "nudDepth";
            nudDepth.Size = new Size(190, 22);
            nudDepth.TabIndex = 16;
            nudDepth.TextAlign = HorizontalAlignment.Right;
            nudDepth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblTankDepth
            // 
            lblTankDepth.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblTankDepth.Location = new Point(14, 44);
            lblTankDepth.Name = "lblTankDepth";
            lblTankDepth.Size = new Size(135, 19);
            lblTankDepth.TabIndex = 15;
            lblTankDepth.Text = "Tank Depth (meters):";
            // 
            // nudRadius
            // 
            nudRadius.Font = new Font("Microsoft Sans Serif", 9.75F);
            nudRadius.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudRadius.Location = new Point(177, 20);
            nudRadius.Margin = new Padding(3, 2, 3, 2);
            nudRadius.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRadius.Name = "nudRadius";
            nudRadius.Size = new Size(190, 22);
            nudRadius.TabIndex = 14;
            nudRadius.TextAlign = HorizontalAlignment.Right;
            nudRadius.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCreate.Location = new Point(177, 70);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(190, 24);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Water Tank";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblTankRadius
            // 
            lblTankRadius.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblTankRadius.Location = new Point(14, 22);
            lblTankRadius.Name = "lblTankRadius";
            lblTankRadius.Size = new Size(144, 19);
            lblTankRadius.TabIndex = 0;
            lblTankRadius.Text = "Tank Radius (meters):";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(402, 486);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(160, 15);
            lblDeveloper.TabIndex = 21;
            lblDeveloper.Text = "Developed by Timothy Miller";
            // 
            // WaterTankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 508);
            Controls.Add(lblDeveloper);
            Controls.Add(grpWaterData);
            Controls.Add(grpFillDrain);
            Controls.Add(grpIncreaseReduce);
            Controls.Add(lblTitle);
            Controls.Add(grpTriggers);
            Controls.Add(grpWaterTankData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WaterTankForm";
            Text = "Form1";
            grpWaterData.ResumeLayout(false);
            grpFillDrain.ResumeLayout(false);
            grpFillDrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFillDrain).EndInit();
            grpIncreaseReduce.ResumeLayout(false);
            grpIncreaseReduce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddWithdraw).EndInit();
            grpTriggers.ResumeLayout(false);
            grpWaterTankData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRadius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpWaterData;
        private Label lblMax;
        private Label lblCurrent;
        private Button btnMax;
        private Button btnCurrent;
        private GroupBox grpFillDrain;
        private TextBox txtFillDrainResult;
        private Button btnFillDrain;
        private Label lblFillDrain;
        private RadioButton radDrain;
        private RadioButton radFill;
        private NumericUpDown nudFillDrain;
        private GroupBox grpIncreaseReduce;
        private Label lblResult;
        private Button btnAddWithdraw;
        private Label lblIncreaseReduce;
        private RadioButton radWithdraw;
        private RadioButton radAdd;
        private NumericUpDown nudAddWithdraw;
        private Label lblTitle;
        private GroupBox grpTriggers;
        private Button btnReset;
        private Button btnExit;
        private GroupBox grpWaterTankData;
        private NumericUpDown nudRadius;
        private Button btnCreate;
        private Label lblTankRadius;
        private Label lblTankDepth;
        private NumericUpDown nudDepth;
        private Label lblDeveloper;
    }
}
