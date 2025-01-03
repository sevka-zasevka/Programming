﻿namespace ObjectOrientedPractices.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemsTab = new Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            CustomersTab = new Tabs.CustomersTab();
            CartsTabPage = new TabPage();
            CartsTab = new Tabs.CartsTab();
            OrderTabPage = new TabPage();
            OrdersTab = new Tabs.OrdersTab();
            MainTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrderTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage);
            MainTabControl.Controls.Add(CustomersTabPage);
            MainTabControl.Controls.Add(CartsTabPage);
            MainTabControl.Controls.Add(OrderTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Margin = new Padding(3, 4, 3, 4);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1149, 804);
            MainTabControl.TabIndex = 0;
            MainTabControl.Tag = "";
            MainTabControl.SelectedIndexChanged += SelectedTabChanged;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Margin = new Padding(3, 4, 3, 4);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3, 4, 3, 4);
            ItemsTabPage.Size = new Size(1141, 771);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 4);
            ItemsTab.Margin = new Padding(3, 5, 3, 5);
            ItemsTab.MinimumSize = new Size(814, 679);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(1135, 763);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab);
            CustomersTabPage.Location = new Point(4, 29);
            CustomersTabPage.Margin = new Padding(3, 4, 3, 4);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3, 4, 3, 4);
            CustomersTabPage.Size = new Size(1141, 771);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 4);
            CustomersTab.Margin = new Padding(3, 5, 3, 5);
            CustomersTab.MinimumSize = new Size(814, 679);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1135, 763);
            CustomersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(CartsTab);
            CartsTabPage.Location = new Point(4, 29);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(1141, 771);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Items = null;
            CartsTab.Location = new Point(3, 3);
            CartsTab.MinimumSize = new Size(814, 679);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1135, 765);
            CartsTab.TabIndex = 0;
            // 
            // OrderTabPage
            // 
            OrderTabPage.Controls.Add(OrdersTab);
            OrderTabPage.Location = new Point(4, 29);
            OrderTabPage.Name = "OrderTabPage";
            OrderTabPage.Padding = new Padding(3);
            OrderTabPage.Size = new Size(1141, 771);
            OrderTabPage.TabIndex = 3;
            OrderTabPage.Text = "Orders";
            OrderTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.CustomersOrder = null;
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.MinimumSize = new Size(814, 679);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1135, 765);
            OrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 804);
            Controls.Add(MainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1149, 804);
            Name = "MainForm";
            Text = "Object Oriented Practices";
            MainTabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrderTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsTabPage;
        private Tabs.ItemsTab ItemsTab;
        private TabPage CustomersTabPage;
        private Tabs.CustomersTab CustomersTab;
        private TabPage CartsTabPage;
        private Tabs.CartsTab CartsTab;
        private TabPage OrderTabPage;
        private Tabs.OrdersTab OrdersTab;
    }
}