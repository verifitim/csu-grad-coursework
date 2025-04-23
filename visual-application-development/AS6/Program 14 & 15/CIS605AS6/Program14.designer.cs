namespace CIS605AS6
{
    partial class Program14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpStockInfo = new GroupBox();
            txtPrices = new TextBox();
            txtSymbol = new TextBox();
            btnCreate = new Button();
            label2 = new Label();
            label1 = new Label();
            lblSmallest = new Label();
            grpTriggers = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            label5 = new Label();
            grpAnalysis = new GroupBox();
            lblLongest = new Label();
            btnLongest = new Button();
            lblNegative = new Label();
            lblLargest = new Label();
            btnNegative = new Button();
            btnLargest = new Button();
            btnSmallest = new Button();
            grpStockInfo.SuspendLayout();
            grpTriggers.SuspendLayout();
            grpAnalysis.SuspendLayout();
            SuspendLayout();
            // 
            // grpStockInfo
            // 
            grpStockInfo.Controls.Add(txtPrices);
            grpStockInfo.Controls.Add(txtSymbol);
            grpStockInfo.Controls.Add(btnCreate);
            grpStockInfo.Controls.Add(label2);
            grpStockInfo.Controls.Add(label1);
            grpStockInfo.FlatStyle = FlatStyle.Popup;
            grpStockInfo.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpStockInfo.Location = new Point(10, 55);
            grpStockInfo.Margin = new Padding(2);
            grpStockInfo.Name = "grpStockInfo";
            grpStockInfo.Padding = new Padding(2);
            grpStockInfo.Size = new Size(252, 548);
            grpStockInfo.TabIndex = 0;
            grpStockInfo.TabStop = false;
            grpStockInfo.Text = "Stock Info:";
            // 
            // txtPrices
            // 
            txtPrices.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtPrices.Location = new Point(133, 77);
            txtPrices.Margin = new Padding(2);
            txtPrices.Multiline = true;
            txtPrices.Name = "txtPrices";
            txtPrices.ScrollBars = ScrollBars.Vertical;
            txtPrices.Size = new Size(107, 452);
            txtPrices.TabIndex = 10;
            txtPrices.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSymbol
            // 
            txtSymbol.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtSymbol.Location = new Point(133, 35);
            txtSymbol.Margin = new Padding(2);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new Size(107, 22);
            txtSymbol.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCreate.Location = new Point(7, 467);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(122, 62);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "&Create StockAnalyzer";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(7, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 1;
            label2.Text = "Stock Prices:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(7, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 0;
            label1.Text = "Ticker Symbol:";
            // 
            // lblSmallest
            // 
            lblSmallest.BorderStyle = BorderStyle.Fixed3D;
            lblSmallest.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblSmallest.Location = new Point(244, 79);
            lblSmallest.Margin = new Padding(2, 0, 2, 0);
            lblSmallest.Name = "lblSmallest";
            lblSmallest.Size = new Size(115, 32);
            lblSmallest.TabIndex = 16;
            lblSmallest.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpTriggers
            // 
            grpTriggers.Controls.Add(btnExit);
            grpTriggers.Controls.Add(btnReset);
            grpTriggers.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpTriggers.Location = new Point(266, 301);
            grpTriggers.Margin = new Padding(2);
            grpTriggers.Name = "grpTriggers";
            grpTriggers.Padding = new Padding(2);
            grpTriggers.Size = new Size(228, 60);
            grpTriggers.TabIndex = 1;
            grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnExit.Location = new Point(135, 16);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 35);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.DialogResult = DialogResult.Cancel;
            btnReset.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnReset.Location = new Point(13, 16);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(76, 35);
            btnReset.TabIndex = 1;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(233, 17);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(239, 25);
            label5.TabIndex = 5;
            label5.Text = "Create and use StockAnalyzer";
            // 
            // grpAnalysis
            // 
            grpAnalysis.Controls.Add(lblLongest);
            grpAnalysis.Controls.Add(btnLongest);
            grpAnalysis.Controls.Add(lblNegative);
            grpAnalysis.Controls.Add(lblLargest);
            grpAnalysis.Controls.Add(lblSmallest);
            grpAnalysis.Controls.Add(btnNegative);
            grpAnalysis.Controls.Add(btnLargest);
            grpAnalysis.Controls.Add(btnSmallest);
            grpAnalysis.Enabled = false;
            grpAnalysis.Font = new Font("Microsoft Sans Serif", 9.75F);
            grpAnalysis.Location = new Point(266, 55);
            grpAnalysis.Margin = new Padding(2);
            grpAnalysis.Name = "grpAnalysis";
            grpAnalysis.Padding = new Padding(2);
            grpAnalysis.Size = new Size(375, 233);
            grpAnalysis.TabIndex = 17;
            grpAnalysis.TabStop = false;
            grpAnalysis.Text = "Display Stats:";
            // 
            // lblLongest
            // 
            lblLongest.BorderStyle = BorderStyle.Fixed3D;
            lblLongest.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLongest.Location = new Point(244, 182);
            lblLongest.Margin = new Padding(2, 0, 2, 0);
            lblLongest.Name = "lblLongest";
            lblLongest.Size = new Size(115, 32);
            lblLongest.TabIndex = 24;
            lblLongest.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLongest
            // 
            btnLongest.DialogResult = DialogResult.Cancel;
            btnLongest.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnLongest.Location = new Point(0, 180);
            btnLongest.Margin = new Padding(2);
            btnLongest.Name = "btnLongest";
            btnLongest.Size = new Size(228, 35);
            btnLongest.TabIndex = 23;
            btnLongest.Text = "Longest Price Gain Streak";
            btnLongest.UseVisualStyleBackColor = true;
            btnLongest.Click += btnLongest_Click;
            // 
            // lblNegative
            // 
            lblNegative.BorderStyle = BorderStyle.Fixed3D;
            lblNegative.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblNegative.Location = new Point(244, 128);
            lblNegative.Margin = new Padding(2, 0, 2, 0);
            lblNegative.Name = "lblNegative";
            lblNegative.Size = new Size(115, 32);
            lblNegative.TabIndex = 21;
            lblNegative.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLargest
            // 
            lblLargest.BorderStyle = BorderStyle.Fixed3D;
            lblLargest.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLargest.Location = new Point(244, 27);
            lblLargest.Margin = new Padding(2, 0, 2, 0);
            lblLargest.Name = "lblLargest";
            lblLargest.Size = new Size(115, 32);
            lblLargest.TabIndex = 20;
            lblLargest.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNegative
            // 
            btnNegative.DialogResult = DialogResult.Cancel;
            btnNegative.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnNegative.Location = new Point(0, 129);
            btnNegative.Margin = new Padding(2);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(228, 35);
            btnNegative.TabIndex = 18;
            btnNegative.Text = "Times Negative Change in Price";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnLargest
            // 
            btnLargest.DialogResult = DialogResult.Cancel;
            btnLargest.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnLargest.Location = new Point(0, 26);
            btnLargest.Margin = new Padding(2);
            btnLargest.Name = "btnLargest";
            btnLargest.Size = new Size(228, 35);
            btnLargest.TabIndex = 17;
            btnLargest.Text = "Largest Absolute Price Change";
            btnLargest.UseVisualStyleBackColor = true;
            btnLargest.Click += btnLargest_Click;
            // 
            // btnSmallest
            // 
            btnSmallest.DialogResult = DialogResult.Cancel;
            btnSmallest.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSmallest.Location = new Point(0, 77);
            btnSmallest.Margin = new Padding(2);
            btnSmallest.Name = "btnSmallest";
            btnSmallest.Size = new Size(228, 36);
            btnSmallest.TabIndex = 1;
            btnSmallest.Text = "Smallest Percentage Gain In Price";
            btnSmallest.UseVisualStyleBackColor = true;
            btnSmallest.Click += btnSmallest_Click;
            // 
            // Program14
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btnReset;
            ClientSize = new Size(648, 607);
            Controls.Add(grpAnalysis);
            Controls.Add(label5);
            Controls.Add(grpTriggers);
            Controls.Add(grpStockInfo);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Program14";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assignment Set 6 - Program 14";
            grpStockInfo.ResumeLayout(false);
            grpStockInfo.PerformLayout();
            grpTriggers.ResumeLayout(false);
            grpAnalysis.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpStockInfo;
        private Label label2;
        private Label label1;
        private GroupBox grpTriggers;
        private Button btnExit;
        private Button btnReset;
        private Button btnCreate;
        private Label label5;
        private Label lblSmallest;
        private TextBox txtPrices;
        private TextBox txtSymbol;
        private GroupBox grpAnalysis;
        private Button btnSmallest;
        private Label lblLongest;
        private Button btnLongest;
        private Label lblNegative;
        private Label lblLargest;
        private Button btnNegative;
        private Button btnLargest;
    }
}

