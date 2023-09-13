namespace ObjectOrientedPractices.View.Tabs
{
    partial class ItemsTab
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
            BasicTableLayoutPanel = new TableLayoutPanel();
            ItemGroupBox = new GroupBox();
            ButtonTableLayoutPanel = new TableLayoutPanel();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            SelectedIntemGroupBox = new GroupBox();
            DescriptionValidationLabel = new Label();
            NameValidationLabel = new Label();
            CostValidationLabel = new Label();
            CancelButton = new Button();
            DescrirtionTextBox = new TextBox();
            OkButton = new Button();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IDTextBox = new TextBox();
            IDLabel = new Label();
            ChangeButton = new Button();
            BasicTableLayoutPanel.SuspendLayout();
            ItemGroupBox.SuspendLayout();
            ButtonTableLayoutPanel.SuspendLayout();
            SelectedIntemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BasicTableLayoutPanel
            // 
            BasicTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BasicTableLayoutPanel.ColumnCount = 2;
            BasicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BasicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 448F));
            BasicTableLayoutPanel.Controls.Add(ItemGroupBox, 0, 0);
            BasicTableLayoutPanel.Controls.Add(SelectedIntemGroupBox, 1, 0);
            BasicTableLayoutPanel.Location = new Point(3, 4);
            BasicTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            BasicTableLayoutPanel.Name = "BasicTableLayoutPanel";
            BasicTableLayoutPanel.RowCount = 1;
            BasicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BasicTableLayoutPanel.Size = new Size(807, 671);
            BasicTableLayoutPanel.TabIndex = 0;
            // 
            // ItemGroupBox
            // 
            ItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemGroupBox.Controls.Add(ButtonTableLayoutPanel);
            ItemGroupBox.Controls.Add(ItemsListBox);
            ItemGroupBox.Location = new Point(3, 4);
            ItemGroupBox.Margin = new Padding(3, 4, 3, 4);
            ItemGroupBox.Name = "ItemGroupBox";
            ItemGroupBox.Padding = new Padding(3, 4, 3, 4);
            ItemGroupBox.Size = new Size(353, 663);
            ItemGroupBox.TabIndex = 0;
            ItemGroupBox.TabStop = false;
            ItemGroupBox.Text = "Items";
            // 
            // ButtonTableLayoutPanel
            // 
            ButtonTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonTableLayoutPanel.ColumnCount = 3;
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5833321F));
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4166679F));
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            ButtonTableLayoutPanel.Controls.Add(ChangeButton, 0, 0);
            ButtonTableLayoutPanel.Controls.Add(RemoveButton, 0, 0);
            ButtonTableLayoutPanel.Controls.Add(AddButton, 0, 0);
            ButtonTableLayoutPanel.Location = new Point(7, 585);
            ButtonTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            ButtonTableLayoutPanel.RowCount = 1;
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.Size = new Size(340, 69);
            ButtonTableLayoutPanel.TabIndex = 1;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(112, 4);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(105, 61);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 4);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(103, 61);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(7, 29);
            ItemsListBox.Margin = new Padding(3, 4, 3, 4);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(339, 544);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedIntemGroupBox
            // 
            SelectedIntemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedIntemGroupBox.Controls.Add(DescriptionValidationLabel);
            SelectedIntemGroupBox.Controls.Add(NameValidationLabel);
            SelectedIntemGroupBox.Controls.Add(CostValidationLabel);
            SelectedIntemGroupBox.Controls.Add(CancelButton);
            SelectedIntemGroupBox.Controls.Add(DescrirtionTextBox);
            SelectedIntemGroupBox.Controls.Add(OkButton);
            SelectedIntemGroupBox.Controls.Add(NameTextBox);
            SelectedIntemGroupBox.Controls.Add(CostTextBox);
            SelectedIntemGroupBox.Controls.Add(DescriptionLabel);
            SelectedIntemGroupBox.Controls.Add(NameLabel);
            SelectedIntemGroupBox.Controls.Add(CostLabel);
            SelectedIntemGroupBox.Controls.Add(IDTextBox);
            SelectedIntemGroupBox.Controls.Add(IDLabel);
            SelectedIntemGroupBox.Location = new Point(362, 4);
            SelectedIntemGroupBox.Margin = new Padding(3, 4, 3, 4);
            SelectedIntemGroupBox.Name = "SelectedIntemGroupBox";
            SelectedIntemGroupBox.Padding = new Padding(3, 4, 3, 4);
            SelectedIntemGroupBox.Size = new Size(442, 663);
            SelectedIntemGroupBox.TabIndex = 1;
            SelectedIntemGroupBox.TabStop = false;
            SelectedIntemGroupBox.Text = "Selected Item";
            // 
            // DescriptionValidationLabel
            // 
            DescriptionValidationLabel.AutoSize = true;
            DescriptionValidationLabel.Location = new Point(90, 340);
            DescriptionValidationLabel.Name = "DescriptionValidationLabel";
            DescriptionValidationLabel.Size = new Size(333, 20);
            DescriptionValidationLabel.TabIndex = 11;
            DescriptionValidationLabel.Text = "The name must be less than 1000 characters long";
            DescriptionValidationLabel.Visible = false;
            // 
            // NameValidationLabel
            // 
            NameValidationLabel.AutoSize = true;
            NameValidationLabel.Location = new Point(54, 148);
            NameValidationLabel.Name = "NameValidationLabel";
            NameValidationLabel.Size = new Size(325, 20);
            NameValidationLabel.TabIndex = 10;
            NameValidationLabel.Text = "The name must be less than 200 characters long";
            NameValidationLabel.Visible = false;
            // 
            // CostValidationLabel
            // 
            CostValidationLabel.AutoSize = true;
            CostValidationLabel.Location = new Point(8, 106);
            CostValidationLabel.Name = "CostValidationLabel";
            CostValidationLabel.Size = new Size(363, 20);
            CostValidationLabel.TabIndex = 9;
            CostValidationLabel.Text = "The cost must be greater than 0 and less than 100,000";
            CostValidationLabel.Visible = false;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.Location = new Point(119, 589);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(104, 61);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Visible = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // DescrirtionTextBox
            // 
            DescrirtionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DescrirtionTextBox.Enabled = false;
            DescrirtionTextBox.Location = new Point(8, 364);
            DescrirtionTextBox.Margin = new Padding(3, 4, 3, 4);
            DescrirtionTextBox.Multiline = true;
            DescrirtionTextBox.Name = "DescrirtionTextBox";
            DescrirtionTextBox.Size = new Size(427, 208);
            DescrirtionTextBox.TabIndex = 7;
            DescrirtionTextBox.TextChanged += DescrirtionTextBox_TextChanged;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OkButton.Location = new Point(7, 589);
            OkButton.Margin = new Padding(3, 4, 3, 4);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(104, 61);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Visible = false;
            OkButton.Click += OkButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Enabled = false;
            NameTextBox.Location = new Point(7, 172);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(428, 160);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CostTextBox.Enabled = false;
            CostTextBox.Location = new Point(59, 71);
            CostTextBox.Margin = new Padding(3, 4, 3, 4);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(114, 27);
            CostTextBox.TabIndex = 5;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(7, 340);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(7, 148);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(7, 75);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(59, 32);
            IDTextBox.Margin = new Padding(3, 4, 3, 4);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(114, 27);
            IDTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(8, 35);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // ChangeButton
            // 
            ChangeButton.Dock = DockStyle.Fill;
            ChangeButton.Location = new Point(223, 4);
            ChangeButton.Margin = new Padding(3, 4, 3, 4);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(114, 61);
            ChangeButton.TabIndex = 3;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BasicTableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(814, 679);
            Name = "ItemsTab";
            Size = new Size(814, 679);
            BasicTableLayoutPanel.ResumeLayout(false);
            ItemGroupBox.ResumeLayout(false);
            ButtonTableLayoutPanel.ResumeLayout(false);
            SelectedIntemGroupBox.ResumeLayout(false);
            SelectedIntemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BasicTableLayoutPanel;
        private GroupBox ItemGroupBox;
        private TableLayoutPanel ButtonTableLayoutPanel;
        private ListBox ItemsListBox;
        private GroupBox SelectedIntemGroupBox;
        private Button OkButton;
        private Button AddButton;
        private Label IDLabel;
        private TextBox DescrirtionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private TextBox IDTextBox;
        private Button RemoveButton;
        private Button CancelButton;
        private Label CostValidationLabel;
        private Label DescriptionValidationLabel;
        private Label NameValidationLabel;
        private Button ChangeButton;
    }
}
