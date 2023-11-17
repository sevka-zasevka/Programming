namespace ObjectOrientedPractices.View.Tabs
{
    partial class CartsTab
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
            CastGroupBox = new GroupBox();
            TotalLabel = new Label();
            DiscountAmountLabel = new Label();
            TotalTextLabel = new Label();
            DiscountAmountTextLabel = new Label();
            DiscountCheckedListBox = new CheckedListBox();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            AddToCartButton = new Button();
            AmountLabel = new Label();
            AmountTextLabel = new Label();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomersComboBox = new ComboBox();
            CustomerLabel = new Label();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            CastGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CastGroupBox
            // 
            CastGroupBox.Controls.Add(TotalLabel);
            CastGroupBox.Controls.Add(DiscountAmountLabel);
            CastGroupBox.Controls.Add(TotalTextLabel);
            CastGroupBox.Controls.Add(DiscountAmountTextLabel);
            CastGroupBox.Controls.Add(DiscountCheckedListBox);
            CastGroupBox.Controls.Add(ClearCartButton);
            CastGroupBox.Controls.Add(RemoveItemButton);
            CastGroupBox.Controls.Add(CreateOrderButton);
            CastGroupBox.Controls.Add(AddToCartButton);
            CastGroupBox.Controls.Add(AmountLabel);
            CastGroupBox.Controls.Add(AmountTextLabel);
            CastGroupBox.Controls.Add(CartListBox);
            CastGroupBox.Controls.Add(CartLabel);
            CastGroupBox.Controls.Add(CustomersComboBox);
            CastGroupBox.Controls.Add(CustomerLabel);
            CastGroupBox.Controls.Add(ItemsListBox);
            CastGroupBox.Controls.Add(ItemsLabel);
            CastGroupBox.Dock = DockStyle.Fill;
            CastGroupBox.Location = new Point(0, 0);
            CastGroupBox.Name = "CastGroupBox";
            CastGroupBox.Size = new Size(814, 679);
            CastGroupBox.TabIndex = 12;
            CastGroupBox.TabStop = false;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(738, 623);
            TotalLabel.MaximumSize = new Size(0, 200);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(59, 40);
            TotalLabel.TabIndex = 28;
            TotalLabel.Text = "0,0";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(738, 499);
            DiscountAmountLabel.MaximumSize = new Size(0, 200);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(59, 40);
            DiscountAmountLabel.TabIndex = 27;
            DiscountAmountLabel.Text = "0,0";
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTextLabel.Location = new Point(739, 603);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(58, 20);
            TotalTextLabel.TabIndex = 26;
            TotalTextLabel.Text = "TOTAL:";
            // 
            // DiscountAmountTextLabel
            // 
            DiscountAmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountAmountTextLabel.AutoSize = true;
            DiscountAmountTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountTextLabel.Location = new Point(660, 479);
            DiscountAmountTextLabel.Name = "DiscountAmountTextLabel";
            DiscountAmountTextLabel.Size = new Size(137, 20);
            DiscountAmountTextLabel.TabIndex = 25;
            DiscountAmountTextLabel.Text = "Discount Amount:";
            // 
            // DiscountCheckedListBox
            // 
            DiscountCheckedListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountCheckedListBox.FormattingEnabled = true;
            DiscountCheckedListBox.Location = new Point(358, 443);
            DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            DiscountCheckedListBox.Size = new Size(213, 176);
            DiscountCheckedListBox.TabIndex = 24;
            DiscountCheckedListBox.SelectedIndexChanged += DiscountCheckedListBox_SelectedIndexChanged;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom;
            ClearCartButton.Location = new Point(469, 405);
            ClearCartButton.Margin = new Padding(3, 4, 3, 4);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(104, 31);
            ClearCartButton.TabIndex = 23;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom;
            RemoveItemButton.Location = new Point(359, 405);
            RemoveItemButton.Margin = new Padding(3, 4, 3, 4);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(104, 31);
            RemoveItemButton.TabIndex = 22;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Location = new Point(119, 633);
            CreateOrderButton.Margin = new Padding(3, 4, 3, 4);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(104, 31);
            CreateOrderButton.TabIndex = 21;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(9, 633);
            AddToCartButton.Margin = new Padding(3, 4, 3, 4);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(104, 31);
            AddToCartButton.TabIndex = 20;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(738, 421);
            AmountLabel.MaximumSize = new Size(0, 200);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(59, 40);
            AmountLabel.TabIndex = 19;
            AmountLabel.Text = "0,0";
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountTextLabel.Location = new Point(726, 401);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(71, 20);
            AmountTextLabel.TabIndex = 18;
            AmountTextLabel.Text = "Amount:";
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 20;
            CartListBox.Location = new Point(359, 113);
            CartListBox.Margin = new Padding(3, 4, 3, 4);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(438, 284);
            CartListBox.TabIndex = 17;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(359, 89);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(39, 20);
            CartLabel.TabIndex = 16;
            CartLabel.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(436, 39);
            CustomersComboBox.Margin = new Padding(3, 4, 3, 4);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(361, 28);
            CustomersComboBox.TabIndex = 15;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerLabel.Location = new Point(359, 42);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(82, 20);
            CustomerLabel.TabIndex = 14;
            CustomerLabel.Text = "Customer:";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(9, 39);
            ItemsListBox.Margin = new Padding(3, 4, 3, 4);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(341, 584);
            ItemsListBox.TabIndex = 13;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(9, 15);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(49, 20);
            ItemsLabel.TabIndex = 12;
            ItemsLabel.Text = "Items";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CastGroupBox);
            MinimumSize = new Size(814, 679);
            Name = "CartsTab";
            Size = new Size(814, 679);
            CastGroupBox.ResumeLayout(false);
            CastGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CastGroupBox;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Button CreateOrderButton;
        private Button AddToCartButton;
        private Label AmountLabel;
        private Label AmountTextLabel;
        private ListBox CartListBox;
        private Label CartLabel;
        private ComboBox CustomersComboBox;
        private Label CustomerLabel;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private CheckedListBox DiscountCheckedListBox;
        private Label TotalLabel;
        private Label DiscountAmountLabel;
        private Label TotalTextLabel;
        private Label DiscountAmountTextLabel;
    }
}
