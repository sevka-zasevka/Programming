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
            DescrirtionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IDTextBox = new TextBox();
            IDLabel = new Label();
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
            BasicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 392F));
            BasicTableLayoutPanel.Controls.Add(ItemGroupBox, 0, 0);
            BasicTableLayoutPanel.Controls.Add(SelectedIntemGroupBox, 1, 0);
            BasicTableLayoutPanel.Location = new Point(3, 3);
            BasicTableLayoutPanel.Name = "BasicTableLayoutPanel";
            BasicTableLayoutPanel.RowCount = 1;
            BasicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BasicTableLayoutPanel.Size = new Size(706, 503);
            BasicTableLayoutPanel.TabIndex = 0;
            // 
            // ItemGroupBox
            // 
            ItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemGroupBox.Controls.Add(ButtonTableLayoutPanel);
            ItemGroupBox.Controls.Add(ItemsListBox);
            ItemGroupBox.Location = new Point(3, 3);
            ItemGroupBox.Name = "ItemGroupBox";
            ItemGroupBox.Size = new Size(308, 497);
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
            ButtonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            ButtonTableLayoutPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonTableLayoutPanel.Controls.Add(AddButton, 0, 0);
            ButtonTableLayoutPanel.Location = new Point(6, 439);
            ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            ButtonTableLayoutPanel.RowCount = 1;
            ButtonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonTableLayoutPanel.Size = new Size(297, 52);
            ButtonTableLayoutPanel.TabIndex = 1;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(99, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(91, 46);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(90, 46);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(296, 409);
            ItemsListBox.TabIndex = 0;
            // 
            // SelectedIntemGroupBox
            // 
            SelectedIntemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedIntemGroupBox.Controls.Add(DescrirtionTextBox);
            SelectedIntemGroupBox.Controls.Add(NameTextBox);
            SelectedIntemGroupBox.Controls.Add(CostTextBox);
            SelectedIntemGroupBox.Controls.Add(DescriptionLabel);
            SelectedIntemGroupBox.Controls.Add(NameLabel);
            SelectedIntemGroupBox.Controls.Add(CostLabel);
            SelectedIntemGroupBox.Controls.Add(IDTextBox);
            SelectedIntemGroupBox.Controls.Add(IDLabel);
            SelectedIntemGroupBox.Location = new Point(317, 3);
            SelectedIntemGroupBox.Name = "SelectedIntemGroupBox";
            SelectedIntemGroupBox.Size = new Size(386, 497);
            SelectedIntemGroupBox.TabIndex = 1;
            SelectedIntemGroupBox.TabStop = false;
            SelectedIntemGroupBox.Text = "Selected Item";
            // 
            // DescrirtionTextBox
            // 
            DescrirtionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DescrirtionTextBox.Location = new Point(6, 273);
            DescrirtionTextBox.Multiline = true;
            DescrirtionTextBox.Name = "DescrirtionTextBox";
            DescrirtionTextBox.Size = new Size(374, 157);
            DescrirtionTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 129);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(374, 121);
            NameTextBox.TabIndex = 6;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CostTextBox.Location = new Point(52, 53);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(100, 23);
            CostTextBox.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 255);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 111);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 56);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IDTextBox.Location = new Point(52, 24);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(6, 27);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(21, 15);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BasicTableLayoutPanel);
            MinimumSize = new Size(712, 509);
            Name = "ItemsTab";
            Size = new Size(712, 509);
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
        private Button RemoveButton;
        private Button AddButton;
        private Label IDLabel;
        private TextBox DescrirtionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private TextBox IDTextBox;
    }
}
