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
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.13408F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.86592F));
            tableLayoutPanel1.Controls.Add(CustomersGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectCustomerGroupBox, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(709, 506);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(tableLayoutPanel2);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Fill;
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(306, 500);
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Controls.Add(ChangeButton, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 437);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(300, 60);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(88, 54);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(97, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(90, 54);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            ChangeButton.Dock = DockStyle.Fill;
            ChangeButton.Location = new Point(193, 3);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(104, 54);
            ChangeButton.TabIndex = 2;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(0, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(306, 409);
            CustomersListBox.TabIndex = 0;
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
            SelectCustomerGroupBox.Location = new Point(315, 3);
            SelectCustomerGroupBox.Name = "SelectCustomerGroupBox";
            SelectCustomerGroupBox.Size = new Size(391, 500);
            SelectCustomerGroupBox.TabIndex = 1;
            SelectCustomerGroupBox.TabStop = false;
            SelectCustomerGroupBox.Text = "Select Customer";
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelButton.Location = new Point(118, 307);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 57);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OkButton.Location = new Point(8, 307);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(104, 57);
            OkButton.TabIndex = 9;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AdressValidationLabel
            // 
            AdressValidationLabel.AutoSize = true;
            AdressValidationLabel.Location = new Point(50, 102);
            AdressValidationLabel.Name = "AdressValidationLabel";
            AdressValidationLabel.Size = new Size(314, 15);
            AdressValidationLabel.TabIndex = 8;
            AdressValidationLabel.Text = "Adress must be greater than 0 and less than 500 characters";
            // 
            // FullNameValidationLabel
            // 
            FullNameValidationLabel.AutoSize = true;
            FullNameValidationLabel.Location = new Point(8, 75);
            FullNameValidationLabel.Name = "FullNameValidationLabel";
            FullNameValidationLabel.Size = new Size(331, 15);
            FullNameValidationLabel.TabIndex = 7;
            FullNameValidationLabel.Text = "Full name must be greater than 0 and less than 200 characters";
            // 
            // AdressTextBox
            // 
            AdressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdressTextBox.Location = new Point(8, 120);
            AdressTextBox.Multiline = true;
            AdressTextBox.Name = "AdressTextBox";
            AdressTextBox.Size = new Size(380, 181);
            AdressTextBox.TabIndex = 5;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(78, 49);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(310, 23);
            FullNameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(78, 20);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 3;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(8, 102);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(45, 15);
            AdressLabel.TabIndex = 2;
            AdressLabel.Text = "Adress:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(8, 52);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(62, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(8, 23);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(712, 509);
            Name = "CustomersTab";
            Size = new Size(712, 509);
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
