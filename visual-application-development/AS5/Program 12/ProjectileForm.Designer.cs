namespace Program12
{
    partial class ProjectileForm
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
            grpProjectileData = new GroupBox();
            btnCreateProjectile = new Button();
            nudInitialVelocity = new NumericUpDown();
            nudInitialHeight = new NumericUpDown();
            lblVelocity = new Label();
            lblHeight = new Label();
            grpProjectileMotionInfo = new GroupBox();
            lblLandingTime = new Label();
            lblMaximumHeight = new Label();
            btnLandingTime = new Button();
            btnMaximumHeight = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpResetExit = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            lblDeveloper = new Label();
            grpProjectileData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInitialVelocity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInitialHeight).BeginInit();
            grpProjectileMotionInfo.SuspendLayout();
            grpResetExit.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(73, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Projectile Calculations";
            // 
            // grpProjectileData
            // 
            grpProjectileData.Controls.Add(btnCreateProjectile);
            grpProjectileData.Controls.Add(nudInitialVelocity);
            grpProjectileData.Controls.Add(nudInitialHeight);
            grpProjectileData.Controls.Add(lblVelocity);
            grpProjectileData.Controls.Add(lblHeight);
            grpProjectileData.Location = new Point(12, 29);
            grpProjectileData.Name = "grpProjectileData";
            grpProjectileData.Size = new Size(253, 154);
            grpProjectileData.TabIndex = 1;
            grpProjectileData.TabStop = false;
            grpProjectileData.Text = "Projectile Data:";
            // 
            // btnCreateProjectile
            // 
            btnCreateProjectile.BackColor = SystemColors.MenuHighlight;
            btnCreateProjectile.Location = new Point(138, 103);
            btnCreateProjectile.Name = "btnCreateProjectile";
            btnCreateProjectile.Size = new Size(97, 45);
            btnCreateProjectile.TabIndex = 4;
            btnCreateProjectile.Text = "Create Projectile";
            btnCreateProjectile.UseVisualStyleBackColor = false;
            btnCreateProjectile.Click += btnCreateProjectile_Click;
            // 
            // nudInitialVelocity
            // 
            nudInitialVelocity.Location = new Point(138, 66);
            nudInitialVelocity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudInitialVelocity.Name = "nudInitialVelocity";
            nudInitialVelocity.Size = new Size(97, 23);
            nudInitialVelocity.TabIndex = 3;
            // 
            // nudInitialHeight
            // 
            nudInitialHeight.Location = new Point(138, 30);
            nudInitialHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudInitialHeight.Name = "nudInitialHeight";
            nudInitialHeight.Size = new Size(97, 23);
            nudInitialHeight.TabIndex = 2;
            // 
            // lblVelocity
            // 
            lblVelocity.AutoSize = true;
            lblVelocity.Location = new Point(9, 68);
            lblVelocity.Name = "lblVelocity";
            lblVelocity.Size = new Size(109, 15);
            lblVelocity.TabIndex = 1;
            lblVelocity.Text = "Initial Velocity (ft/s)";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(9, 32);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(100, 15);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "Initial Height (ft): ";
            // 
            // grpProjectileMotionInfo
            // 
            grpProjectileMotionInfo.Controls.Add(lblLandingTime);
            grpProjectileMotionInfo.Controls.Add(lblMaximumHeight);
            grpProjectileMotionInfo.Controls.Add(btnLandingTime);
            grpProjectileMotionInfo.Controls.Add(btnMaximumHeight);
            grpProjectileMotionInfo.Enabled = false;
            grpProjectileMotionInfo.Location = new Point(12, 189);
            grpProjectileMotionInfo.Name = "grpProjectileMotionInfo";
            grpProjectileMotionInfo.Size = new Size(253, 123);
            grpProjectileMotionInfo.TabIndex = 5;
            grpProjectileMotionInfo.TabStop = false;
            grpProjectileMotionInfo.Text = "Projectile Motion Info:";
            // 
            // lblLandingTime
            // 
            lblLandingTime.BorderStyle = BorderStyle.Fixed3D;
            lblLandingTime.Location = new Point(138, 77);
            lblLandingTime.Name = "lblLandingTime";
            lblLandingTime.Size = new Size(97, 40);
            lblLandingTime.TabIndex = 9;
            lblLandingTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaximumHeight
            // 
            lblMaximumHeight.BorderStyle = BorderStyle.Fixed3D;
            lblMaximumHeight.Location = new Point(138, 22);
            lblMaximumHeight.Name = "lblMaximumHeight";
            lblMaximumHeight.Size = new Size(97, 40);
            lblMaximumHeight.TabIndex = 8;
            lblMaximumHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLandingTime
            // 
            btnLandingTime.BackColor = SystemColors.HotTrack;
            btnLandingTime.Location = new Point(6, 77);
            btnLandingTime.Name = "btnLandingTime";
            btnLandingTime.Size = new Size(109, 40);
            btnLandingTime.TabIndex = 7;
            btnLandingTime.Text = "Landing Time";
            btnLandingTime.UseVisualStyleBackColor = false;
            btnLandingTime.Click += btnLandingTime_Click;
            // 
            // btnMaximumHeight
            // 
            btnMaximumHeight.BackColor = SystemColors.MenuHighlight;
            btnMaximumHeight.Location = new Point(6, 22);
            btnMaximumHeight.Name = "btnMaximumHeight";
            btnMaximumHeight.Size = new Size(109, 40);
            btnMaximumHeight.TabIndex = 6;
            btnMaximumHeight.Text = "Maximum Height";
            btnMaximumHeight.UseVisualStyleBackColor = false;
            btnMaximumHeight.Click += btnMaximumHeight_Click;
            // 
            // grpResetExit
            // 
            grpResetExit.Controls.Add(btnExit);
            grpResetExit.Controls.Add(btnReset);
            grpResetExit.Enabled = false;
            grpResetExit.Location = new Point(12, 318);
            grpResetExit.Name = "grpResetExit";
            grpResetExit.Size = new Size(253, 59);
            grpResetExit.TabIndex = 6;
            grpResetExit.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.AppWorkspace;
            btnExit.Location = new Point(124, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.AppWorkspace;
            btnReset.Location = new Point(6, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 23);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(55, 381);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(160, 15);
            lblDeveloper.TabIndex = 7;
            lblDeveloper.Text = "Developed by Timothy Miller";
            // 
            // ProjectileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 405);
            Controls.Add(lblDeveloper);
            Controls.Add(grpResetExit);
            Controls.Add(grpProjectileMotionInfo);
            Controls.Add(grpProjectileData);
            Controls.Add(lblTitle);
            Name = "ProjectileForm";
            Text = "Projectile Form";
            grpProjectileData.ResumeLayout(false);
            grpProjectileData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInitialVelocity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInitialHeight).EndInit();
            grpProjectileMotionInfo.ResumeLayout(false);
            grpResetExit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpProjectileData;
        private Button btnCreateProjectile;
        private NumericUpDown nudInitialVelocity;
        private NumericUpDown nudInitialHeight;
        private Label lblVelocity;
        private Label lblHeight;
        private GroupBox grpProjectileMotionInfo;
        private Label lblLandingTime;
        private Label lblMaximumHeight;
        private Button btnLandingTime;
        private Button btnMaximumHeight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpResetExit;
        private Button btnExit;
        private Button btnReset;
        private Label lblDeveloper;
    }
}
