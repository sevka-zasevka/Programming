namespace ObjectOrientedPractices.View.Tabs
{
    partial class CustomersTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            CustomersGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            ChangeButton = new Button();
            CustomersListBox = new ListBox();
            SelectCustomerGroupBox = new GroupBox();
            AddDiscountButton = new Button();
            RemoveDiscountButton = new Button();
            DiscountListBox = new ListBox();
            IsPriorityCheckBox = new CheckBox();
            AddressControl = new Controls.AddressControl();
            CancelButton = new Button();
            OkButton = new Button();
            FullNameValidationLabel = new Label();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullNameLabel = new Label();
            IdLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            CustomersGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SelectCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.2921333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.7078667F));
            tableLayoutPanel1.Controls.Add(CustomersGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectCustomerGroupBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(989, 679);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(tableLayoutPanel2);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Fill;
            CustomersGroupBox.Location = new Point(3, 4);
            CustomersGroupBox.Margin = new Padding(3, 4, 3, 4);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Padding = new Padding(3, 4, 3, 4);
            CustomersGroupBox.Size = new Size(402, 671);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5652161F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4347839F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Controls.Add(ChangeButton, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 587);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(395, 80);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 4);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(125, 72);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(134, 4);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(127, 72);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Dock = DockStyle.Fill;
            ChangeButton.Location = new Point(267, 4);
            ChangeButton.Margin = new Padding(3, 4, 3, 4);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(125, 72);
            ChangeButton.TabIndex = 2;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(0, 29);
            CustomersListBox.Margin = new Padding(3, 4, 3, 4);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(395, 544);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectCustomerGroupBox
            // 
            SelectCustomerGroupBox.Controls.Add(AddDiscountButton);
            SelectCustomerGroupBox.Controls.Add(RemoveDiscountButton);
            SelectCustomerGroupBox.Controls.Add(DiscountListBox);
            SelectCustomerGroupBox.Controls.Add(IsPriorityCheckBox);
            SelectCustomerGroupBox.Controls.Add(AddressControl);
            SelectCustomerGroupBox.Controls.Add(CancelButton);
            SelectCustomerGroupBox.Controls.Add(OkButton);
            SelectCustomerGroupBox.Controls.Add(FullNameValidationLabel);
            SelectCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectCustomerGroupBox.Controls.Add(IdTextBox);
            SelectCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectCustomerGroupBox.Controls.Add(IdLabel);
            SelectCustomerGroupBox.Dock = DockStyle.Fill;
            SelectCustomerGroupBox.Location = new Point(411, 4);
            SelectCustomerGroupBox.Margin = new Padding(3, 4, 3, 4);
            SelectCustomerGroupBox.Name = "SelectCustomerGroupBox";
            SelectCustomerGroupBox.Padding = new Padding(3, 4, 3, 4);
            SelectCustomerGroupBox.Size = new Size(575, 671);
            SelectCustomerGroupBox.TabIndex = 1;
            SelectCustomerGroupBox.TabStop = false;
            SelectCustomerGroupBox.Text = "Select Customer";
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddDiscountButton.Location = new Point(6, 587);
            AddDiscountButton.Margin = new Padding(3, 4, 3, 4);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(119, 76);
            AddDiscountButton.TabIndex = 15;
            AddDiscountButton.Text = "Add Discount";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveDiscountButton.Location = new Point(141, 587);
            RemoveDiscountButton.Margin = new Padding(3, 4, 3, 4);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(119, 76);
            RemoveDiscountButton.TabIndex = 14;
            RemoveDiscountButton.Text = "Remove Discount";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // DiscountListBox
            // 
            DiscountListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountListBox.FormattingEnabled = true;
            DiscountListBox.ItemHeight = 20;
            DiscountListBox.Location = new Point(6, 409);
            DiscountListBox.Margin = new Padding(3, 4, 3, 4);
            DiscountListBox.Name = "DiscountListBox";
            DiscountListBox.Size = new Size(310, 164);
            DiscountListBox.TabIndex = 13;
            DiscountListBox.SelectedIndexChanged += DiscountListBox_SelectedIndexChanged;
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Enabled = false;
            IsPriorityCheckBox.Location = new Point(89, 123);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(92, 24);
            IsPriorityCheckBox.TabIndex = 12;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // AddressControl
            // 
            AddressControl.ChangedAddress = null;
            AddressControl.Flag = "null";
            AddressControl.Location = new Point(0, 156);
            AddressControl.Margin = new Padding(3, 5, 3, 5);
            AddressControl.MinimumSize = new Size(563, 251);
            AddressControl.Name = "AddressControl";
            AddressControl.SelectedAddress = null;
            AddressControl.Size = new Size(563, 251);
            AddressControl.TabIndex = 11;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.Location = new Point(454, 409);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(117, 76);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Visible = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OkButton.Location = new Point(325, 409);
            OkButton.Margin = new Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(119, 76);
            OkButton.TabIndex = 9;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Visible = false;
            OkButton.Click += OkButton_Click;
            // 
            // FullNameValidationLabel
            // 
            FullNameValidationLabel.AutoSize = true;
            FullNameValidationLabel.Location = new Point(9, 100);
            FullNameValidationLabel.Name = "FullNameValidationLabel";
            FullNameValidationLabel.Size = new Size(416, 20);
            FullNameValidationLabel.TabIndex = 7;
            FullNameValidationLabel.Text = "Full name must be greater than 0 and less than 200 characters";
            FullNameValidationLabel.Visible = false;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Enabled = false;
            FullNameTextBox.Location = new Point(89, 65);
            FullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(482, 27);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(89, 27);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(242, 27);
            IdTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(9, 69);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(76, 20);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(9, 31);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(814, 679);
            Name = "CustomersTab";
            Size = new Size(989, 679);
            tableLayoutPanel1.ResumeLayout(false);
            CustomersGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            SelectCustomerGroupBox.ResumeLayout(false);
            SelectCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox CustomersGroupBox;
        private GroupBox SelectCustomerGroupBox;
        private ListBox CustomersListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddButton;
        private Button RemoveButton;
        private Button ChangeButton;
        private Label FullNameValidationLabel;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label FullNameLabel;
        private Label IdLabel;
        private Button CancelButton;
        private Button OkButton;
        private Controls.AddressControl AddressControl;
        private CheckBox IsPriorityCheckBox;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
        private ListBox DiscountListBox;
    }
}
