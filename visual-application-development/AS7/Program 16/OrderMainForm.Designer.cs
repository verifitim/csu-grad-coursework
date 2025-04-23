namespace Program16
{
    partial class OrderMainForm
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
            grpOrderInfo = new GroupBox();
            btnAddOrder = new Button();
            cboPizzaType = new ComboBox();
            cboPizzaChoice = new ComboBox();
            nudOrderQuantity = new NumericUpDown();
            txtCustomerName = new TextBox();
            lblPizzaType = new Label();
            lblPizzaChoice = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addPizzaChoiceToolStripMenuItem1 = new ToolStripMenuItem();
            removePizzaChoiceToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            displayToolStripMenuItem = new ToolStripMenuItem();
            allOrdersToolStripMenuItem = new ToolStripMenuItem();
            totalOrderAmountForAPizzaChoiceToolStripMenuItem = new ToolStripMenuItem();
            numberOfOrdersForAPizzaTypeToolStripMenuItem = new ToolStripMenuItem();
            ordersSummaryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            resetForNextOrderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            addPizzaChoiceToolStripMenuItem = new ToolStripMenuItem();
            removePizzaChoiceToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudOrderQuantity).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpOrderInfo
            // 
            grpOrderInfo.Controls.Add(btnAddOrder);
            grpOrderInfo.Controls.Add(cboPizzaType);
            grpOrderInfo.Controls.Add(cboPizzaChoice);
            grpOrderInfo.Controls.Add(nudOrderQuantity);
            grpOrderInfo.Controls.Add(txtCustomerName);
            grpOrderInfo.Controls.Add(lblPizzaType);
            grpOrderInfo.Controls.Add(lblPizzaChoice);
            grpOrderInfo.Controls.Add(lblQuantity);
            grpOrderInfo.Controls.Add(lblName);
            grpOrderInfo.Location = new Point(12, 42);
            grpOrderInfo.Name = "grpOrderInfo";
            grpOrderInfo.Size = new Size(475, 294);
            grpOrderInfo.TabIndex = 0;
            grpOrderInfo.TabStop = false;
            grpOrderInfo.Text = "Order Info:";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(344, 234);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(94, 29);
            btnAddOrder.TabIndex = 8;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // cboPizzaType
            // 
            cboPizzaType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPizzaType.FormattingEnabled = true;
            cboPizzaType.Location = new Point(143, 188);
            cboPizzaType.Name = "cboPizzaType";
            cboPizzaType.Size = new Size(151, 28);
            cboPizzaType.TabIndex = 7;
            // 
            // cboPizzaChoice
            // 
            cboPizzaChoice.FormattingEnabled = true;
            cboPizzaChoice.Items.AddRange(new object[] { "Jalapeno Popper", "Sweet n Spicy", "Krazy Hawaiian", "Buffalo Chicken", "Double Pepperoni", "Mile High", "South of Border" });
            cboPizzaChoice.Location = new Point(142, 136);
            cboPizzaChoice.Name = "cboPizzaChoice";
            cboPizzaChoice.Size = new Size(151, 28);
            cboPizzaChoice.TabIndex = 6;
            // 
            // nudOrderQuantity
            // 
            nudOrderQuantity.Location = new Point(143, 88);
            nudOrderQuantity.Name = "nudOrderQuantity";
            nudOrderQuantity.Size = new Size(150, 27);
            nudOrderQuantity.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(143, 41);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(295, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // lblPizzaType
            // 
            lblPizzaType.AutoSize = true;
            lblPizzaType.Location = new Point(36, 191);
            lblPizzaType.Name = "lblPizzaType";
            lblPizzaType.Size = new Size(81, 20);
            lblPizzaType.TabIndex = 3;
            lblPizzaType.Text = "Pizza Type:";
            // 
            // lblPizzaChoice
            // 
            lblPizzaChoice.AutoSize = true;
            lblPizzaChoice.Location = new Point(35, 139);
            lblPizzaChoice.Name = "lblPizzaChoice";
            lblPizzaChoice.Size = new Size(95, 20);
            lblPizzaChoice.TabIndex = 2;
            lblPizzaChoice.Text = "Pizza Choice:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(35, 90);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addPizzaChoiceToolStripMenuItem1, removePizzaChoiceToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(220, 52);
            // 
            // addPizzaChoiceToolStripMenuItem1
            // 
            addPizzaChoiceToolStripMenuItem1.Name = "addPizzaChoiceToolStripMenuItem1";
            addPizzaChoiceToolStripMenuItem1.Size = new Size(219, 24);
            addPizzaChoiceToolStripMenuItem1.Text = "Add Pizza Choice";
            addPizzaChoiceToolStripMenuItem1.Click += addPizzaChoiceToolStripMenuItem_Click;
            // 
            // removePizzaChoiceToolStripMenuItem1
            // 
            removePizzaChoiceToolStripMenuItem1.Name = "removePizzaChoiceToolStripMenuItem1";
            removePizzaChoiceToolStripMenuItem1.Size = new Size(219, 24);
            removePizzaChoiceToolStripMenuItem1.Text = "Remove Pizza Choice";
            removePizzaChoiceToolStripMenuItem1.Click += removePizzaChoiceToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ContextMenuStrip = contextMenuStrip1;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { displayToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(501, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            displayToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allOrdersToolStripMenuItem, totalOrderAmountForAPizzaChoiceToolStripMenuItem, numberOfOrdersForAPizzaTypeToolStripMenuItem, ordersSummaryToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            displayToolStripMenuItem.Size = new Size(76, 24);
            displayToolStripMenuItem.Text = " Display";
            // 
            // allOrdersToolStripMenuItem
            // 
            allOrdersToolStripMenuItem.Enabled = false;
            allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            allOrdersToolStripMenuItem.Size = new Size(346, 26);
            allOrdersToolStripMenuItem.Text = "All Orders";
            allOrdersToolStripMenuItem.Click += allOrdersToolStripMenuItem_Click;
            // 
            // totalOrderAmountForAPizzaChoiceToolStripMenuItem
            // 
            totalOrderAmountForAPizzaChoiceToolStripMenuItem.Enabled = false;
            totalOrderAmountForAPizzaChoiceToolStripMenuItem.Name = "totalOrderAmountForAPizzaChoiceToolStripMenuItem";
            totalOrderAmountForAPizzaChoiceToolStripMenuItem.Size = new Size(346, 26);
            totalOrderAmountForAPizzaChoiceToolStripMenuItem.Text = "Total Order Amount for a Pizza Choice";
            totalOrderAmountForAPizzaChoiceToolStripMenuItem.Click += totalOrderAmountForAPizzaChoiceToolStripMenuItem_Click;
            // 
            // numberOfOrdersForAPizzaTypeToolStripMenuItem
            // 
            numberOfOrdersForAPizzaTypeToolStripMenuItem.Enabled = false;
            numberOfOrdersForAPizzaTypeToolStripMenuItem.Name = "numberOfOrdersForAPizzaTypeToolStripMenuItem";
            numberOfOrdersForAPizzaTypeToolStripMenuItem.Size = new Size(346, 26);
            numberOfOrdersForAPizzaTypeToolStripMenuItem.Text = "Number of Orders for a Pizza Type";
            numberOfOrdersForAPizzaTypeToolStripMenuItem.Click += numberOfOrdersForAPizzaTypeToolStripMenuItem_Click;
            // 
            // ordersSummaryToolStripMenuItem
            // 
            ordersSummaryToolStripMenuItem.Enabled = false;
            ordersSummaryToolStripMenuItem.Name = "ordersSummaryToolStripMenuItem";
            ordersSummaryToolStripMenuItem.Size = new Size(346, 26);
            ordersSummaryToolStripMenuItem.Text = "Orders Summary";
            ordersSummaryToolStripMenuItem.Click += ordersSummaryToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(343, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(346, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetForNextOrderToolStripMenuItem, toolStripSeparator2, addPizzaChoiceToolStripMenuItem, removePizzaChoiceToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // resetForNextOrderToolStripMenuItem
            // 
            resetForNextOrderToolStripMenuItem.Name = "resetForNextOrderToolStripMenuItem";
            resetForNextOrderToolStripMenuItem.Size = new Size(233, 26);
            resetForNextOrderToolStripMenuItem.Text = "Reset for Next Order";
            resetForNextOrderToolStripMenuItem.Click += resetForNextOrderToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(230, 6);
            // 
            // addPizzaChoiceToolStripMenuItem
            // 
            addPizzaChoiceToolStripMenuItem.Name = "addPizzaChoiceToolStripMenuItem";
            addPizzaChoiceToolStripMenuItem.Size = new Size(233, 26);
            addPizzaChoiceToolStripMenuItem.Text = "Add Pizza Choice";
            addPizzaChoiceToolStripMenuItem.Click += addPizzaChoiceToolStripMenuItem_Click;
            // 
            // removePizzaChoiceToolStripMenuItem
            // 
            removePizzaChoiceToolStripMenuItem.Name = "removePizzaChoiceToolStripMenuItem";
            removePizzaChoiceToolStripMenuItem.Size = new Size(233, 26);
            removePizzaChoiceToolStripMenuItem.Text = "Remove Pizza Choice";
            removePizzaChoiceToolStripMenuItem.Click += removePizzaChoiceToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 339);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Developed by TM";
            // 
            // OrderMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 368);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(grpOrderInfo);
            MainMenuStrip = menuStrip1;
            Name = "OrderMainForm";
            Text = "Order Main Form - TM";
            Load += OrderMainForm_Load;
            grpOrderInfo.ResumeLayout(false);
            grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudOrderQuantity).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpOrderInfo;
        private ComboBox cboPizzaChoice;
        private NumericUpDown nudOrderQuantity;
        private TextBox txtCustomerName;
        private Label lblPizzaType;
        private Label lblPizzaChoice;
        private Label lblQuantity;
        private Label lblName;
        private ComboBox cboPizzaType;
        private Button btnAddOrder;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem allOrdersToolStripMenuItem;
        private ToolStripMenuItem totalOrderAmountForAPizzaChoiceToolStripMenuItem;
        private ToolStripMenuItem numberOfOrdersForAPizzaTypeToolStripMenuItem;
        private ToolStripMenuItem ordersSummaryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem resetForNextOrderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem addPizzaChoiceToolStripMenuItem;
        private ToolStripMenuItem removePizzaChoiceToolStripMenuItem;
        private ToolStripMenuItem addPizzaChoiceToolStripMenuItem1;
        private ToolStripMenuItem removePizzaChoiceToolStripMenuItem1;
        private Label label1;
    }
}
