﻿namespace ObjectOrientedPractices.View.Tabs
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
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearCartButton.Location = new Point(693, 495);
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
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(582, 495);
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
            CreateOrderButton.Location = new Point(358, 495);
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
            AmountLabel.Location = new Point(744, 441);
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
            AmountTextLabel.Location = new Point(734, 421);
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
            CartListBox.Location = new Point(358, 127);
            CartListBox.Margin = new Padding(3, 4, 3, 4);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(438, 284);
            CartListBox.TabIndex = 17;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(358, 103);
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
            CustomerLabel.Location = new Point(358, 43);
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
    }
}