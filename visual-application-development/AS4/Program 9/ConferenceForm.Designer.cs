namespace Program9
{
    partial class ConferenceForm
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
            lblConferenceName = new Label();
            lblNumAttendees = new Label();
            lblNumNights = new Label();
            txtConferenceName = new TextBox();
            nudNumberOfAttendees = new NumericUpDown();
            nudNumberOfNights = new NumericUpDown();
            radioSingle = new RadioButton();
            radioDouble = new RadioButton();
            radioSuite = new RadioButton();
            chkboxInternetAccess = new CheckBox();
            chkboxRecCenterAccess = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpAccommodationChoice = new GroupBox();
            grpOptionalServices = new GroupBox();
            btnCreateConference = new Button();
            btnModifyConference = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblDisplay = new Label();
            lblDeveloper = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfAttendees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfNights).BeginInit();
            grpAccommodationChoice.SuspendLayout();
            grpOptionalServices.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(108, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CSU Conference Reservation";
            // 
            // lblConferenceName
            // 
            lblConferenceName.AutoSize = true;
            lblConferenceName.Location = new Point(20, 59);
            lblConferenceName.Name = "lblConferenceName";
            lblConferenceName.Size = new Size(109, 15);
            lblConferenceName.TabIndex = 1;
            lblConferenceName.Text = "Conference Name: ";
            // 
            // lblNumAttendees
            // 
            lblNumAttendees.AutoSize = true;
            lblNumAttendees.Location = new Point(20, 103);
            lblNumAttendees.Name = "lblNumAttendees";
            lblNumAttendees.Size = new Size(124, 15);
            lblNumAttendees.TabIndex = 2;
            lblNumAttendees.Text = "Number of Attendees:";
            // 
            // lblNumNights
            // 
            lblNumNights.AutoSize = true;
            lblNumNights.Location = new Point(20, 147);
            lblNumNights.Name = "lblNumNights";
            lblNumNights.Size = new Size(106, 15);
            lblNumNights.TabIndex = 3;
            lblNumNights.Text = "Number of Nights:";
            // 
            // txtConferenceName
            // 
            txtConferenceName.Location = new Point(150, 56);
            txtConferenceName.Name = "txtConferenceName";
            txtConferenceName.Size = new Size(323, 23);
            txtConferenceName.TabIndex = 6;
            txtConferenceName.TextChanged += txtConferenceName_TextChanged;
            // 
            // nudNumberOfAttendees
            // 
            nudNumberOfAttendees.Location = new Point(150, 101);
            nudNumberOfAttendees.Maximum = new decimal(new int[] { 850, 0, 0, 0 });
            nudNumberOfAttendees.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            nudNumberOfAttendees.Name = "nudNumberOfAttendees";
            nudNumberOfAttendees.Size = new Size(120, 23);
            nudNumberOfAttendees.TabIndex = 7;
            nudNumberOfAttendees.TextAlign = HorizontalAlignment.Center;
            nudNumberOfAttendees.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // nudNumberOfNights
            // 
            nudNumberOfNights.Location = new Point(150, 145);
            nudNumberOfNights.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudNumberOfNights.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudNumberOfNights.Name = "nudNumberOfNights";
            nudNumberOfNights.Size = new Size(120, 23);
            nudNumberOfNights.TabIndex = 8;
            nudNumberOfNights.TextAlign = HorizontalAlignment.Center;
            nudNumberOfNights.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // radioSingle
            // 
            radioSingle.AutoSize = true;
            radioSingle.Checked = true;
            radioSingle.Location = new Point(7, 20);
            radioSingle.Name = "radioSingle";
            radioSingle.Size = new Size(57, 19);
            radioSingle.TabIndex = 9;
            radioSingle.TabStop = true;
            radioSingle.Text = "Single";
            radioSingle.UseVisualStyleBackColor = true;
            // 
            // radioDouble
            // 
            radioDouble.AutoSize = true;
            radioDouble.Location = new Point(70, 20);
            radioDouble.Name = "radioDouble";
            radioDouble.Size = new Size(63, 19);
            radioDouble.TabIndex = 10;
            radioDouble.Text = "Double";
            radioDouble.UseVisualStyleBackColor = true;
            // 
            // radioSuite
            // 
            radioSuite.AutoSize = true;
            radioSuite.Location = new Point(139, 20);
            radioSuite.Name = "radioSuite";
            radioSuite.Size = new Size(51, 19);
            radioSuite.TabIndex = 11;
            radioSuite.Text = "Suite";
            radioSuite.UseVisualStyleBackColor = true;
            // 
            // chkboxInternetAccess
            // 
            chkboxInternetAccess.AutoSize = true;
            chkboxInternetAccess.Location = new Point(13, 22);
            chkboxInternetAccess.Name = "chkboxInternetAccess";
            chkboxInternetAccess.Size = new Size(106, 19);
            chkboxInternetAccess.TabIndex = 12;
            chkboxInternetAccess.Text = "Internet Access";
            chkboxInternetAccess.UseVisualStyleBackColor = true;
            // 
            // chkboxRecCenterAccess
            // 
            chkboxRecCenterAccess.AutoSize = true;
            chkboxRecCenterAccess.Location = new Point(13, 47);
            chkboxRecCenterAccess.Name = "chkboxRecCenterAccess";
            chkboxRecCenterAccess.Size = new Size(159, 19);
            chkboxRecCenterAccess.TabIndex = 13;
            chkboxRecCenterAccess.Text = "Recreation Center Access";
            chkboxRecCenterAccess.UseVisualStyleBackColor = true;
            // 
            // grpAccommodationChoice
            // 
            grpAccommodationChoice.Controls.Add(radioDouble);
            grpAccommodationChoice.Controls.Add(radioSingle);
            grpAccommodationChoice.Controls.Add(radioSuite);
            grpAccommodationChoice.Location = new Point(20, 184);
            grpAccommodationChoice.Name = "grpAccommodationChoice";
            grpAccommodationChoice.Size = new Size(199, 58);
            grpAccommodationChoice.TabIndex = 14;
            grpAccommodationChoice.TabStop = false;
            grpAccommodationChoice.Text = "Accommodation Choice:";
            // 
            // grpOptionalServices
            // 
            grpOptionalServices.Controls.Add(chkboxInternetAccess);
            grpOptionalServices.Controls.Add(chkboxRecCenterAccess);
            grpOptionalServices.Location = new Point(20, 248);
            grpOptionalServices.Name = "grpOptionalServices";
            grpOptionalServices.Size = new Size(199, 83);
            grpOptionalServices.TabIndex = 15;
            grpOptionalServices.TabStop = false;
            grpOptionalServices.Text = "Optional Services:";
            // 
            // btnCreateConference
            // 
            btnCreateConference.Location = new Point(341, 93);
            btnCreateConference.Name = "btnCreateConference";
            btnCreateConference.Size = new Size(132, 35);
            btnCreateConference.TabIndex = 16;
            btnCreateConference.Text = "Create Conference";
            btnCreateConference.UseVisualStyleBackColor = true;
            btnCreateConference.Click += btnCreateConference_Click;
            // 
            // btnModifyConference
            // 
            btnModifyConference.Enabled = false;
            btnModifyConference.Location = new Point(341, 145);
            btnModifyConference.Name = "btnModifyConference";
            btnModifyConference.Size = new Size(132, 37);
            btnModifyConference.TabIndex = 17;
            btnModifyConference.Text = "Modify Conference";
            btnModifyConference.UseVisualStyleBackColor = true;
            btnModifyConference.Click += btnModifyConference_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(479, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 37);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(479, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 37);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblDisplay.Location = new Point(237, 195);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(236, 136);
            lblDisplay.TabIndex = 20;
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(412, 343);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(163, 15);
            lblDeveloper.TabIndex = 21;
            lblDeveloper.Text = "Developed by: Timothy Miller";
            // 
            // ConferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 383);
            Controls.Add(lblDeveloper);
            Controls.Add(lblDisplay);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnModifyConference);
            Controls.Add(btnCreateConference);
            Controls.Add(grpOptionalServices);
            Controls.Add(grpAccommodationChoice);
            Controls.Add(nudNumberOfNights);
            Controls.Add(nudNumberOfAttendees);
            Controls.Add(txtConferenceName);
            Controls.Add(lblNumNights);
            Controls.Add(lblNumAttendees);
            Controls.Add(lblConferenceName);
            Controls.Add(lblTitle);
            Name = "ConferenceForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNumberOfAttendees).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfNights).EndInit();
            grpAccommodationChoice.ResumeLayout(false);
            grpAccommodationChoice.PerformLayout();
            grpOptionalServices.ResumeLayout(false);
            grpOptionalServices.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblConferenceName;
        private Label lblNumAttendees;
        private Label lblNumNights;
        private TextBox txtConferenceName;
        private NumericUpDown nudNumberOfAttendees;
        private NumericUpDown nudNumberOfNights;
        private RadioButton radioSingle;
        private RadioButton radioDouble;
        private RadioButton radioSuite;
        private CheckBox chkboxInternetAccess;
        private CheckBox chkboxRecCenterAccess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpAccommodationChoice;
        private GroupBox grpOptionalServices;
        private Button btnCreateConference;
        private Button btnModifyConference;
        private Button btnClear;
        private Button btnExit;
        private Label lblDisplay;
        private Label lblDeveloper;
    }
}
