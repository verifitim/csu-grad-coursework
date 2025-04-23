namespace Program16
{
    partial class OrdersSummaryForm
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
            grpOrderSummary = new GroupBox();
            lblAverageOrderTotal = new Label();
            lblLowestOrderTotal = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            btnClose = new Button();
            grpOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // grpOrderSummary
            // 
            grpOrderSummary.Controls.Add(lblAverageOrderTotal);
            grpOrderSummary.Controls.Add(lblLowestOrderTotal);
            grpOrderSummary.Controls.Add(lbl2);
            grpOrderSummary.Controls.Add(lbl1);
            grpOrderSummary.Location = new Point(12, 12);
            grpOrderSummary.Name = "grpOrderSummary";
            grpOrderSummary.Size = new Size(349, 212);
            grpOrderSummary.TabIndex = 0;
            grpOrderSummary.TabStop = false;
            grpOrderSummary.Text = "Order Summary";
            // 
            // lblAverageOrderTotal
            // 
            lblAverageOrderTotal.BorderStyle = BorderStyle.Fixed3D;
            lblAverageOrderTotal.ImageAlign = ContentAlignment.MiddleRight;
            lblAverageOrderTotal.Location = new Point(174, 134);
            lblAverageOrderTotal.Name = "lblAverageOrderTotal";
            lblAverageOrderTotal.Size = new Size(146, 35);
            lblAverageOrderTotal.TabIndex = 3;
            // 
            // lblLowestOrderTotal
            // 
            lblLowestOrderTotal.BorderStyle = BorderStyle.Fixed3D;
            lblLowestOrderTotal.ImageAlign = ContentAlignment.MiddleRight;
            lblLowestOrderTotal.Location = new Point(174, 65);
            lblLowestOrderTotal.Name = "lblLowestOrderTotal";
            lblLowestOrderTotal.Size = new Size(146, 35);
            lblLowestOrderTotal.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(22, 135);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(146, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "Average Order Total:";
            lbl2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(31, 66);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(137, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Lowest Order Total:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(267, 239);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // OrdersSummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 294);
            Controls.Add(btnClose);
            Controls.Add(grpOrderSummary);
            Name = "OrdersSummaryForm";
            Text = "Orders Summary - TM";
            grpOrderSummary.ResumeLayout(false);
            grpOrderSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl2;
        private Label lbl1;
        private Button btnClose;
        internal GroupBox grpOrderSummary;
        internal Label lblLowestOrderTotal;
        internal Label lblAverageOrderTotal;
    }
}