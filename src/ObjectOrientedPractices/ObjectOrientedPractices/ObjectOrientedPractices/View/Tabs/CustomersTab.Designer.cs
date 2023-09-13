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
            CancelButton = new Button();
            OkButton = new Button();
            AdressValidationLabel = new Label();
            FullNameValidationLabel = new Label();
            AdressTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            AdressLabel = new Label();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.13408F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.86592F));
            tableLayoutPanel1.Controls.Add(CustomersGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectCustomerGroupBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(814, 679);
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
            CustomersGroupBox.Size = new Size(353, 671);
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Controls.Add(ChangeButton, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 587);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(346, 80);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 4);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(103, 72);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(112, 4);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(104, 72);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Dock = DockStyle.Fill;
            ChangeButton.Location = new Point(222, 4);
            ChangeButton.Margin = new Padding(3, 4, 3, 4);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(121, 72);
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
            CustomersListBox.Size = new Size(346, 544);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectCustomerGroupBox
            // 
            SelectCustomerGroupBox.Controls.Add(CancelButton);
            SelectCustomerGroupBox.Controls.Add(OkButton);
            SelectCustomerGroupBox.Controls.Add(AdressValidationLabel);
            SelectCustomerGroupBox.Controls.Add(FullNameValidationLabel);
            SelectCustomerGroupBox.Controls.Add(AdressTextBox);
            SelectCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectCustomerGroupBox.Controls.Add(IdTextBox);
            SelectCustomerGroupBox.Controls.Add(AdressLabel);
            SelectCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectCustomerGroupBox.Controls.Add(IdLabel);
            SelectCustomerGroupBox.Dock = DockStyle.Fill;
            SelectCustomerGroupBox.Location = new Point(362, 4);
            SelectCustomerGroupBox.Margin = new Padding(3, 4, 3, 4);
            SelectCustomerGroupBox.Name = "SelectCustomerGroupBox";
            SelectCustomerGroupBox.Padding = new Padding(3, 4, 3, 4);
            SelectCustomerGroupBox.Size = new Size(449, 671);
            SelectCustomerGroupBox.TabIndex = 1;
            SelectCustomerGroupBox.TabStop = false;
            SelectCustomerGroupBox.Text = "Select Customer";
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.Location = new Point(135, 413);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(117, 76);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OkButton.Location = new Point(9, 413);
            OkButton.Margin = new Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(119, 76);
            OkButton.TabIndex = 9;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AdressValidationLabel
            // 
            AdressValidationLabel.AutoSize = true;
            AdressValidationLabel.Location = new Point(56, 136);
            AdressValidationLabel.Name = "AdressValidationLabel";
            AdressValidationLabel.Size = new Size(396, 20);
            AdressValidationLabel.TabIndex = 8;
            AdressValidationLabel.Text = "Adress must be greater than 0 and less than 500 characters";
            // 
            // FullNameValidationLabel
            // 
            FullNameValidationLabel.AutoSize = true;
            FullNameValidationLabel.Location = new Point(9, 100);
            FullNameValidationLabel.Name = "FullNameValidationLabel";
            FullNameValidationLabel.Size = new Size(416, 20);
            FullNameValidationLabel.TabIndex = 7;
            FullNameValidationLabel.Text = "Full name must be greater than 0 and less than 200 characters";
            // 
            // AdressTextBox
            // 
            AdressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdressTextBox.Location = new Point(9, 160);
            AdressTextBox.Margin = new Padding(3, 4, 3, 4);
            AdressTextBox.Multiline = true;
            AdressTextBox.Name = "AdressTextBox";
            AdressTextBox.Size = new Size(436, 244);
            AdressTextBox.TabIndex = 5;
            AdressTextBox.TextChanged += AdressTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(89, 65);
            FullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(356, 27);
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
            IdTextBox.Size = new Size(116, 27);
            IdTextBox.TabIndex = 3;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(9, 136);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(56, 20);
            AdressLabel.TabIndex = 2;
            AdressLabel.Text = "Adress:";
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
            Size = new Size(814, 679);
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
        private Label AdressValidationLabel;
        private Label FullNameValidationLabel;
        private TextBox AdressTextBox;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label AdressLabel;
        private Label FullNameLabel;
        private Label IdLabel;
        private Button CancelButton;
        private Button OkButton;
    }
}
