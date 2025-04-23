namespace Program10
{
    partial class PropertyTaxForm
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
            lblPropertyOwnerName = new Label();
            lblBuildingSquareFootage = new Label();
            lblLandSquareFootage = new Label();
            lblYearBuilt = new Label();
            grpLocation = new GroupBox();
            radioRural = new RadioButton();
            radioSuburb = new RadioButton();
            radioCity = new RadioButton();
            txtPropertyOwnerName = new TextBox();
            nudBuildingSquareFootage = new NumericUpDown();
            nudLandSquareFootage = new NumericUpDown();
            nudYearBuilt = new NumericUpDown();
            lblDisplay = new Label();
            btnCreatePropertyTax = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblDeveloper = new Label();
            grpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuildingSquareFootage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLandSquareFootage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYearBuilt).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(227, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Property Tax Calculator";
            // 
            // lblPropertyOwnerName
            // 
            lblPropertyOwnerName.AutoSize = true;
            lblPropertyOwnerName.Location = new Point(19, 76);
            lblPropertyOwnerName.Name = "lblPropertyOwnerName";
            lblPropertyOwnerName.Size = new Size(128, 15);
            lblPropertyOwnerName.TabIndex = 1;
            lblPropertyOwnerName.Text = "Property Owner Name:";
            // 
            // lblBuildingSquareFootage
            // 
            lblBuildingSquareFootage.AutoSize = true;
            lblBuildingSquareFootage.Location = new Point(8, 117);
            lblBuildingSquareFootage.Name = "lblBuildingSquareFootage";
            lblBuildingSquareFootage.Size = new Size(139, 15);
            lblBuildingSquareFootage.TabIndex = 2;
            lblBuildingSquareFootage.Text = "Building Square Footage:";
            // 
            // lblLandSquareFootage
            // 
            lblLandSquareFootage.AutoSize = true;
            lblLandSquareFootage.Location = new Point(26, 158);
            lblLandSquareFootage.Name = "lblLandSquareFootage";
            lblLandSquareFootage.Size = new Size(121, 15);
            lblLandSquareFootage.TabIndex = 3;
            lblLandSquareFootage.Text = "Land Square Footage:";
            // 
            // lblYearBuilt
            // 
            lblYearBuilt.AutoSize = true;
            lblYearBuilt.Location = new Point(88, 199);
            lblYearBuilt.Name = "lblYearBuilt";
            lblYearBuilt.Size = new Size(59, 15);
            lblYearBuilt.TabIndex = 4;
            lblYearBuilt.Text = "Year Built:";
            // 
            // grpLocation
            // 
            grpLocation.Controls.Add(radioRural);
            grpLocation.Controls.Add(radioSuburb);
            grpLocation.Controls.Add(radioCity);
            grpLocation.Location = new Point(153, 236);
            grpLocation.Name = "grpLocation";
            grpLocation.Size = new Size(200, 100);
            grpLocation.TabIndex = 5;
            grpLocation.TabStop = false;
            grpLocation.Text = "Location:";
            // 
            // radioRural
            // 
            radioRural.AutoSize = true;
            radioRural.Location = new Point(11, 71);
            radioRural.Name = "radioRural";
            radioRural.Size = new Size(52, 19);
            radioRural.TabIndex = 2;
            radioRural.Text = "Rural";
            radioRural.UseVisualStyleBackColor = true;
            // 
            // radioSuburb
            // 
            radioSuburb.AutoSize = true;
            radioSuburb.Location = new Point(11, 46);
            radioSuburb.Name = "radioSuburb";
            radioSuburb.Size = new Size(63, 19);
            radioSuburb.TabIndex = 1;
            radioSuburb.Text = "Suburb";
            radioSuburb.UseVisualStyleBackColor = true;
            // 
            // radioCity
            // 
            radioCity.AutoSize = true;
            radioCity.Checked = true;
            radioCity.Location = new Point(12, 23);
            radioCity.Name = "radioCity";
            radioCity.Size = new Size(46, 19);
            radioCity.TabIndex = 0;
            radioCity.TabStop = true;
            radioCity.Text = "City";
            radioCity.UseVisualStyleBackColor = true;
            // 
            // txtPropertyOwnerName
            // 
            txtPropertyOwnerName.Location = new Point(153, 73);
            txtPropertyOwnerName.MaxLength = 30;
            txtPropertyOwnerName.Name = "txtPropertyOwnerName";
            txtPropertyOwnerName.Size = new Size(181, 23);
            txtPropertyOwnerName.TabIndex = 6;
            // 
            // nudBuildingSquareFootage
            // 
            nudBuildingSquareFootage.Location = new Point(153, 115);
            nudBuildingSquareFootage.Maximum = new decimal(new int[] { 40000, 0, 0, 0 });
            nudBuildingSquareFootage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBuildingSquareFootage.Name = "nudBuildingSquareFootage";
            nudBuildingSquareFootage.Size = new Size(120, 23);
            nudBuildingSquareFootage.TabIndex = 7;
            nudBuildingSquareFootage.ThousandsSeparator = true;
            nudBuildingSquareFootage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudLandSquareFootage
            // 
            nudLandSquareFootage.Location = new Point(153, 156);
            nudLandSquareFootage.Maximum = new decimal(new int[] { 400000, 0, 0, 0 });
            nudLandSquareFootage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLandSquareFootage.Name = "nudLandSquareFootage";
            nudLandSquareFootage.Size = new Size(120, 23);
            nudLandSquareFootage.TabIndex = 8;
            nudLandSquareFootage.ThousandsSeparator = true;
            nudLandSquareFootage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudYearBuilt
            // 
            nudYearBuilt.Location = new Point(153, 197);
            nudYearBuilt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudYearBuilt.Name = "nudYearBuilt";
            nudYearBuilt.Size = new Size(120, 23);
            nudYearBuilt.TabIndex = 9;
            nudYearBuilt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDisplay
            // 
            lblDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblDisplay.Location = new Point(380, 73);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(285, 167);
            lblDisplay.TabIndex = 10;
            lblDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCreatePropertyTax
            // 
            btnCreatePropertyTax.Location = new Point(380, 259);
            btnCreatePropertyTax.Name = "btnCreatePropertyTax";
            btnCreatePropertyTax.Size = new Size(125, 70);
            btnCreatePropertyTax.TabIndex = 11;
            btnCreatePropertyTax.Text = "Create Property Tax";
            btnCreatePropertyTax.UseVisualStyleBackColor = true;
            btnCreatePropertyTax.Click += btnCreatePropertyTax_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(532, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 32);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(532, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 32);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(247, 365);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(160, 15);
            lblDeveloper.TabIndex = 14;
            lblDeveloper.Text = "Developed by Timothy Miller";
            // 
            // PropertyTaxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 389);
            Controls.Add(lblDeveloper);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCreatePropertyTax);
            Controls.Add(lblDisplay);
            Controls.Add(nudYearBuilt);
            Controls.Add(nudLandSquareFootage);
            Controls.Add(nudBuildingSquareFootage);
            Controls.Add(txtPropertyOwnerName);
            Controls.Add(grpLocation);
            Controls.Add(lblYearBuilt);
            Controls.Add(lblLandSquareFootage);
            Controls.Add(lblBuildingSquareFootage);
            Controls.Add(lblPropertyOwnerName);
            Controls.Add(lblTitle);
            Name = "PropertyTaxForm";
            Text = "Form1";
            Load += PropertyTaxForm_Load;
            grpLocation.ResumeLayout(false);
            grpLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuildingSquareFootage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLandSquareFootage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYearBuilt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPropertyOwnerName;
        private Label lblBuildingSquareFootage;
        private Label lblLandSquareFootage;
        private Label lblYearBuilt;
        private GroupBox grpLocation;
        private RadioButton radioRural;
        private RadioButton radioSuburb;
        private RadioButton radioCity;
        private TextBox txtPropertyOwnerName;
        private NumericUpDown nudBuildingSquareFootage;
        private NumericUpDown nudLandSquareFootage;
        private NumericUpDown nudYearBuilt;
        private Label lblDisplay;
        private Button btnCreatePropertyTax;
        private Button btnClear;
        private Button btnExit;
        private Label lblDeveloper;
    }
}
