namespace Program16
{
    partial class AllOrdersForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            orderManagerDataGridView = new DataGridView();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pizzaChoiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pizzaTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderManagerBindingSource = new BindingSource(components);
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)orderManagerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderManagerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // orderManagerDataGridView
            // 
            orderManagerDataGridView.AllowUserToAddRows = false;
            orderManagerDataGridView.AllowUserToDeleteRows = false;
            orderManagerDataGridView.AutoGenerateColumns = false;
            orderManagerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderManagerDataGridView.Columns.AddRange(new DataGridViewColumn[] { customerNameDataGridViewTextBoxColumn, orderTotalDataGridViewTextBoxColumn, pizzaChoiceDataGridViewTextBoxColumn, pizzaTypeDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            orderManagerDataGridView.DataSource = orderManagerBindingSource;
            orderManagerDataGridView.Location = new Point(12, 12);
            orderManagerDataGridView.Name = "orderManagerDataGridView";
            orderManagerDataGridView.ReadOnly = true;
            orderManagerDataGridView.RowHeadersWidth = 51;
            orderManagerDataGridView.Size = new Size(776, 416);
            orderManagerDataGridView.TabIndex = 0;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            orderTotalDataGridViewTextBoxColumn.DataPropertyName = "OrderTotal";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            orderTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            orderTotalDataGridViewTextBoxColumn.HeaderText = "Order Total";
            orderTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            orderTotalDataGridViewTextBoxColumn.ReadOnly = true;
            orderTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // pizzaChoiceDataGridViewTextBoxColumn
            // 
            pizzaChoiceDataGridViewTextBoxColumn.DataPropertyName = "PizzaChoice";
            pizzaChoiceDataGridViewTextBoxColumn.HeaderText = "Pizza Choice";
            pizzaChoiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            pizzaChoiceDataGridViewTextBoxColumn.Name = "pizzaChoiceDataGridViewTextBoxColumn";
            pizzaChoiceDataGridViewTextBoxColumn.ReadOnly = true;
            pizzaChoiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // pizzaTypeDataGridViewTextBoxColumn
            // 
            pizzaTypeDataGridViewTextBoxColumn.DataPropertyName = "PizzaType";
            pizzaTypeDataGridViewTextBoxColumn.HeaderText = "Pizza Type";
            pizzaTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            pizzaTypeDataGridViewTextBoxColumn.Name = "pizzaTypeDataGridViewTextBoxColumn";
            pizzaTypeDataGridViewTextBoxColumn.ReadOnly = true;
            pizzaTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderManagerBindingSource
            // 
            orderManagerBindingSource.DataMember = "OrderList";
            orderManagerBindingSource.DataSource = typeof(OrderManager);
            // 
            // btnClose
            // 
            btnClose.Location = new Point(694, 434);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AllOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 472);
            Controls.Add(btnClose);
            Controls.Add(orderManagerDataGridView);
            Name = "AllOrdersForm";
            Text = "Display All Order Items - TM";
            ((System.ComponentModel.ISupportInitialize)orderManagerDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderManagerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView orderManagerDataGridView;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pizzaChoiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pizzaTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private Button btnClose;
        internal BindingSource orderManagerBindingSource;
    }
}