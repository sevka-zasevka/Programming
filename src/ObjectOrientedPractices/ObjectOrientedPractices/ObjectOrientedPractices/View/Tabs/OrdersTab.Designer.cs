namespace ObjectOrientedPractices.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            OrdersLabel = new Label();
            SelectedOrderLabel = new Label();
            IDLabel = new Label();
            IDTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            CreatedLabel = new Label();
            StatusLabel = new Label();
            OrderAddressControl = new Controls.AddressControl();
            OrderItemsLabel = new Label();
            OrderItemsListBox = new ListBox();
            AmountTextLlabel = new Label();
            AmountLabel = new Label();
            OrderDataGridView = new DataGridView();
            IdColomn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            UstomerFullNameColumn = new DataGridViewTextBoxColumn();
            OrderAddressColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            PriorityOptionsLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLable = new Label();
            PriorityOptionsPanel = new Panel();
            Total = new DataGridViewTextBoxColumn();
            TotalTextLabel = new Label();
            TotalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            PriorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrdersLabel.Location = new Point(3, 9);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(56, 20);
            OrdersLabel.TabIndex = 0;
            OrdersLabel.Text = "Orders";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedOrderLabel.Location = new Point(592, 9);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(111, 20);
            SelectedOrderLabel.TabIndex = 1;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(592, 43);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "ID:";
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(699, 40);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(151, 27);
            IDTextBox.TabIndex = 3;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Enabled = false;
            CreatedTextBox.Location = new Point(699, 73);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(151, 27);
            CreatedTextBox.TabIndex = 4;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(699, 106);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(592, 76);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 6;
            CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(592, 109);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Status:";
            // 
            // OrderAddressControl
            // 
            OrderAddressControl.ChangedAddress = null;
            OrderAddressControl.Flag = "null";
            OrderAddressControl.Location = new Point(592, 147);
            OrderAddressControl.Margin = new Padding(3, 4, 3, 4);
            OrderAddressControl.MinimumSize = new Size(563, 251);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.SelectedAddress = null;
            OrderAddressControl.Size = new Size(563, 251);
            OrderAddressControl.TabIndex = 8;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Location = new Point(592, 378);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(87, 20);
            OrderItemsLabel.TabIndex = 9;
            OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Enabled = false;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(592, 405);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(525, 204);
            OrderItemsListBox.TabIndex = 10;
            // 
            // AmountTextLlabel
            // 
            AmountTextLlabel.AutoSize = true;
            AmountTextLlabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTextLlabel.Location = new Point(1051, 612);
            AmountTextLlabel.Name = "AmountTextLlabel";
            AmountTextLlabel.Size = new Size(65, 20);
            AmountTextLlabel.TabIndex = 11;
            AmountTextLlabel.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLabel.Location = new Point(1070, 632);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(46, 35);
            AmountLabel.TabIndex = 12;
            AmountLabel.Text = "0,0";
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AllowUserToAddRows = false;
            OrderDataGridView.AllowUserToDeleteRows = false;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColomn, CreatedColumn, OrderStatusColumn, UstomerFullNameColumn, OrderAddressColumn, AmountColumn, Total });
            OrderDataGridView.Location = new Point(3, 32);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.ReadOnly = true;
            OrderDataGridView.RowHeadersWidth = 51;
            OrderDataGridView.RowTemplate.Height = 29;
            OrderDataGridView.Size = new Size(574, 722);
            OrderDataGridView.TabIndex = 13;
            OrderDataGridView.SelectionChanged += OrderDataGridView_SelectionChanged;
            // 
            // IdColomn
            // 
            IdColomn.HeaderText = "Id";
            IdColomn.MinimumWidth = 6;
            IdColomn.Name = "IdColomn";
            IdColomn.ReadOnly = true;
            IdColomn.Width = 125;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 6;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.ReadOnly = true;
            CreatedColumn.Width = 125;
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.HeaderText = "Order Status";
            OrderStatusColumn.MinimumWidth = 6;
            OrderStatusColumn.Name = "OrderStatusColumn";
            OrderStatusColumn.ReadOnly = true;
            OrderStatusColumn.Width = 125;
            // 
            // UstomerFullNameColumn
            // 
            UstomerFullNameColumn.HeaderText = "Customer Full Name";
            UstomerFullNameColumn.MinimumWidth = 6;
            UstomerFullNameColumn.Name = "UstomerFullNameColumn";
            UstomerFullNameColumn.ReadOnly = true;
            UstomerFullNameColumn.Width = 125;
            // 
            // OrderAddressColumn
            // 
            OrderAddressColumn.HeaderText = "Order Address";
            OrderAddressColumn.MinimumWidth = 6;
            OrderAddressColumn.Name = "OrderAddressColumn";
            OrderAddressColumn.ReadOnly = true;
            OrderAddressColumn.Width = 125;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.MinimumWidth = 6;
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            AmountColumn.Width = 125;
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriorityOptionsLabel.Location = new Point(3, 4);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(120, 20);
            PriorityOptionsLabel.TabIndex = 14;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(112, 31);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 15;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLable
            // 
            DeliveryTimeLable.AutoSize = true;
            DeliveryTimeLable.Location = new Point(3, 33);
            DeliveryTimeLable.Name = "DeliveryTimeLable";
            DeliveryTimeLable.Size = new Size(103, 20);
            DeliveryTimeLable.TabIndex = 16;
            DeliveryTimeLable.Text = "Delivery Time:";
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Controls.Add(PriorityOptionsLabel);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLable);
            PriorityOptionsPanel.Location = new Point(856, 9);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(273, 125);
            PriorityOptionsPanel.TabIndex = 17;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTextLabel.Location = new Point(1040, 672);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(77, 28);
            TotalTextLabel.TabIndex = 18;
            TotalTextLabel.Text = "TOTAL:";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(1048, 700);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(69, 46);
            TotalLabel.TabIndex = 19;
            TotalLabel.Text = "0,0";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TotalLabel);
            Controls.Add(TotalTextLabel);
            Controls.Add(PriorityOptionsPanel);
            Controls.Add(OrderDataGridView);
            Controls.Add(AmountLabel);
            Controls.Add(AmountTextLlabel);
            Controls.Add(OrderItemsListBox);
            Controls.Add(OrderItemsLabel);
            Controls.Add(OrderAddressControl);
            Controls.Add(StatusLabel);
            Controls.Add(CreatedLabel);
            Controls.Add(StatusComboBox);
            Controls.Add(CreatedTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(IDLabel);
            Controls.Add(SelectedOrderLabel);
            Controls.Add(OrdersLabel);
            MinimumSize = new Size(814, 679);
            Name = "OrdersTab";
            Size = new Size(1132, 757);
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrdersLabel;
        private Label SelectedOrderLabel;
        private Label IDLabel;
        private TextBox IDTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private Label CreatedLabel;
        private Label StatusLabel;
        private Controls.AddressControl OrderAddressControl;
        private Label OrderItemsLabel;
        private ListBox OrderItemsListBox;
        private Label AmountTextLlabel;
        private Label AmountLabel;
        private DataGridView OrderDataGridView;
        private DataGridViewTextBoxColumn IdColomn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn UstomerFullNameColumn;
        private DataGridViewTextBoxColumn OrderAddressColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private Label PriorityOptionsLabel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLable;
        private Panel PriorityOptionsPanel;
        private DataGridViewTextBoxColumn Total;
        private Label TotalTextLabel;
        private Label TotalLabel;
    }
}
