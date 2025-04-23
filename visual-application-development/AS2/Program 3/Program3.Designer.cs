namespace Program3
{
    partial class Program3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program3));
            grpColors = new GroupBox();
            radioRed = new RadioButton();
            radioOrange = new RadioButton();
            radioGreen = new RadioButton();
            radioBlue = new RadioButton();
            grpVisibility = new GroupBox();
            chkboxDeveloper = new CheckBox();
            chkboxLogo = new CheckBox();
            chkboxTagline = new CheckBox();
            chkboxTitle = new CheckBox();
            lblTitle = new Label();
            lblTagline = new Label();
            lblDeveloper = new Label();
            btnExit = new Button();
            logo = new PictureBox();
            toolTip1 = new ToolTip(components);
            grpColors.SuspendLayout();
            grpVisibility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // grpColors
            // 
            grpColors.Controls.Add(radioRed);
            grpColors.Controls.Add(radioOrange);
            grpColors.Controls.Add(radioGreen);
            grpColors.Controls.Add(radioBlue);
            grpColors.Location = new Point(12, 67);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(119, 131);
            grpColors.TabIndex = 0;
            grpColors.TabStop = false;
            grpColors.Text = "Pick Color:";
            // 
            // radioRed
            // 
            radioRed.AutoSize = true;
            radioRed.Location = new Point(6, 97);
            radioRed.Name = "radioRed";
            radioRed.Size = new Size(45, 19);
            radioRed.TabIndex = 3;
            radioRed.Text = "&Red";
            radioRed.UseVisualStyleBackColor = true;
            radioRed.CheckedChanged += radioRed_CheckedChanged;
            // 
            // radioOrange
            // 
            radioOrange.AutoSize = true;
            radioOrange.Location = new Point(6, 72);
            radioOrange.Name = "radioOrange";
            radioOrange.Size = new Size(64, 19);
            radioOrange.TabIndex = 2;
            radioOrange.Text = "&Orange";
            radioOrange.UseVisualStyleBackColor = true;
            radioOrange.CheckedChanged += radioOrange_CheckedChanged;
            // 
            // radioGreen
            // 
            radioGreen.AutoSize = true;
            radioGreen.Location = new Point(6, 47);
            radioGreen.Name = "radioGreen";
            radioGreen.Size = new Size(56, 19);
            radioGreen.TabIndex = 1;
            radioGreen.Text = "&Green";
            radioGreen.UseVisualStyleBackColor = true;
            radioGreen.CheckedChanged += radioGreen_CheckedChanged;
            // 
            // radioBlue
            // 
            radioBlue.AutoSize = true;
            radioBlue.Checked = true;
            radioBlue.Location = new Point(6, 22);
            radioBlue.Name = "radioBlue";
            radioBlue.Size = new Size(48, 19);
            radioBlue.TabIndex = 0;
            radioBlue.TabStop = true;
            radioBlue.Text = "&Blue";
            radioBlue.UseVisualStyleBackColor = true;
            radioBlue.CheckedChanged += radioBlue_CheckedChanged;
            // 
            // grpVisibility
            // 
            grpVisibility.Controls.Add(chkboxDeveloper);
            grpVisibility.Controls.Add(chkboxLogo);
            grpVisibility.Controls.Add(chkboxTagline);
            grpVisibility.Controls.Add(chkboxTitle);
            grpVisibility.Location = new Point(426, 67);
            grpVisibility.Name = "grpVisibility";
            grpVisibility.Size = new Size(127, 131);
            grpVisibility.TabIndex = 1;
            grpVisibility.TabStop = false;
            grpVisibility.Text = "Show/Hide:";
            // 
            // chkboxDeveloper
            // 
            chkboxDeveloper.AutoSize = true;
            chkboxDeveloper.Checked = true;
            chkboxDeveloper.CheckState = CheckState.Checked;
            chkboxDeveloper.Location = new Point(6, 98);
            chkboxDeveloper.Name = "chkboxDeveloper";
            chkboxDeveloper.Size = new Size(79, 19);
            chkboxDeveloper.TabIndex = 3;
            chkboxDeveloper.Text = "&Developer";
            chkboxDeveloper.UseVisualStyleBackColor = true;
            chkboxDeveloper.CheckedChanged += chkboxDeveloper_CheckedChanged;
            // 
            // chkboxLogo
            // 
            chkboxLogo.AutoSize = true;
            chkboxLogo.Checked = true;
            chkboxLogo.CheckState = CheckState.Checked;
            chkboxLogo.Location = new Point(6, 73);
            chkboxLogo.Name = "chkboxLogo";
            chkboxLogo.Size = new Size(53, 19);
            chkboxLogo.TabIndex = 2;
            chkboxLogo.Text = "&Logo";
            chkboxLogo.UseVisualStyleBackColor = true;
            chkboxLogo.CheckedChanged += chkboxLogo_CheckedChanged;
            // 
            // chkboxTagline
            // 
            chkboxTagline.AutoSize = true;
            chkboxTagline.Checked = true;
            chkboxTagline.CheckState = CheckState.Checked;
            chkboxTagline.Location = new Point(6, 48);
            chkboxTagline.Name = "chkboxTagline";
            chkboxTagline.Size = new Size(64, 19);
            chkboxTagline.TabIndex = 1;
            chkboxTagline.Text = "&Tagline";
            chkboxTagline.UseVisualStyleBackColor = true;
            chkboxTagline.CheckedChanged += chkboxTagline_CheckedChanged;
            // 
            // chkboxTitle
            // 
            chkboxTitle.AutoSize = true;
            chkboxTitle.Checked = true;
            chkboxTitle.CheckState = CheckState.Checked;
            chkboxTitle.Location = new Point(6, 23);
            chkboxTitle.Name = "chkboxTitle";
            chkboxTitle.Size = new Size(58, 19);
            chkboxTitle.TabIndex = 0;
            chkboxTitle.Text = "&Name";
            chkboxTitle.UseVisualStyleBackColor = true;
            chkboxTitle.CheckedChanged += chkboxTitle_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Heading", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 39);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Miller Math Tutoring";
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Sitka Subheading", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.Blue;
            lblTagline.Location = new Point(323, 17);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(230, 29);
            lblTagline.TabIndex = 4;
            lblTagline.Text = "Where learning adds up!";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(12, 232);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(163, 15);
            lblDeveloper.TabIndex = 5;
            lblDeveloper.Text = "Developed by: Timothy Miller";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(478, 224);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(137, 67);
            logo.Name = "logo";
            logo.Size = new Size(283, 150);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 7;
            logo.TabStop = false;
            toolTip1.SetToolTip(logo, "Our Logo");
            // 
            // Program3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 261);
            Controls.Add(logo);
            Controls.Add(btnExit);
            Controls.Add(lblDeveloper);
            Controls.Add(lblTagline);
            Controls.Add(lblTitle);
            Controls.Add(grpVisibility);
            Controls.Add(grpColors);
            Name = "Program3";
            Text = "Assignment Set 2 Program 3";
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            grpVisibility.ResumeLayout(false);
            grpVisibility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpColors;
        private RadioButton radioRed;
        private RadioButton radioOrange;
        private RadioButton radioGreen;
        private RadioButton radioBlue;
        private GroupBox grpVisibility;
        private CheckBox chkboxDeveloper;
        private CheckBox chkboxLogo;
        private CheckBox chkboxTagline;
        private CheckBox chkboxTitle;
        private Label lblTitle;
        private Label lblTagline;
        private Label lblDeveloper;
        private Button btnExit;
        private PictureBox logo;
        private ToolTip toolTip1;
    }
}
