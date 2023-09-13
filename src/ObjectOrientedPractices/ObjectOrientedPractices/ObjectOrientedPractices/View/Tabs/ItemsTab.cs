﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model;
using System.Net.Sockets;
using Microsoft.VisualBasic.Devices;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> Items = new List<Item>();
        private Item SelectedItem = new Item("Name", "info", 0.1);
        private int Index;
        private int Count = 1;
        private bool AddCheck;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            VisibleItems(false);
            Item item = new Item("Name " + Count.ToString(), "Info", 0.1);
            Count++;
            Items.Add(item);
            ItemsListBox.Items.Add(StringToListBox(item));
            ItemsListBox.SelectedIndex = (ItemsListBox.Items.Count) - 1;
            Index = ItemsListBox.SelectedIndex;
            SelectedItem.Name = Items[Index].Name;
            SelectedItem.Info = Items[Index].Info;
            SelectedItem.Cost = Items[Index].Cost;
            AddCheck = true;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                try
                {
                    double newCost = Convert.ToDouble(CostTextBox.Text);
                    SelectedItem.Cost = newCost;
                    CostTextBox.BackColor = Color.White;
                    CostValidationLabel.Visible = false;
                    int currentSelection = CostTextBox.SelectionStart;
                    CostTextBox.Focus();
                    CostTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    CostTextBox.BackColor = Color.LightPink;
                    CostValidationLabel.Visible = true;
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                try
                {
                    string newName = NameTextBox.Text.ToString();
                    SelectedItem.Name = newName;
                    NameTextBox.BackColor = Color.White;
                    NameValidationLabel.Visible = false;
                    int currentSelection = NameTextBox.SelectionStart;
                    NameTextBox.Focus();
                    NameTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    NameTextBox.BackColor = Color.LightPink;
                    NameValidationLabel.Visible = true;
                }
            }
        }

        private void DescrirtionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                try
                {
                    string newDescription = DescrirtionTextBox.Text.ToString();
                    SelectedItem.Name = newDescription;
                    DescrirtionTextBox.BackColor = Color.White;
                    DescriptionValidationLabel.Visible = false;
                    int currentSelection = DescrirtionTextBox.SelectionStart;
                    DescrirtionTextBox.Focus();
                    DescrirtionTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    DescrirtionTextBox.BackColor = Color.LightPink;
                    DescriptionValidationLabel.Visible = true;
                }
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = ItemsListBox.SelectedIndex;
            if (Index != -1)
            {
                PrintToTextBox(Items[Index]);
            }
            else
            {
                CleanTextBox();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Index = ItemsListBox.SelectedIndex;
            if (Index != -1)
            {
                Items.RemoveAt(Index);
                ItemsListBox.Items.RemoveAt(Index);
                ItemsListBox.SelectedIndex = -1;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (AddCheck)
            {
                ItemsListBox.SelectedIndex = -1;
                Items.RemoveAt(Index);
                ItemsListBox.Items.RemoveAt(Index);
                VisibleItems(true);
                AddCheck = false;
            }
            else
            {
                PrintToTextBox(Items[Index]);
                VisibleItems(true);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Items[Index].Name = SelectedItem.Name;
            Items[Index].Info = SelectedItem.Info;
            Items[Index].Cost = SelectedItem.Cost;
            VisibleItems(true);
            ListBoxLineChange(Items);
            AddCheck = false;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                VisibleItems(false);
                SelectedItem.Name = Items[Index].Name;
                SelectedItem.Info = Items[Index].Info;
                SelectedItem.Cost = Items[Index].Cost;
                PrintToTextBox(SelectedItem);
            }
        }

        private void VisibleItems(bool visible)
        {
            AddButton.Visible = visible;
            RemoveButton.Visible = visible;
            ChangeButton.Visible = visible;
            OkButton.Visible = !visible;
            CancelButton.Visible = !visible;
            ItemsListBox.Enabled = visible;
            CostTextBox.Enabled = !visible;
            NameTextBox.Enabled = !visible;
            DescrirtionTextBox.Enabled = !visible;
        }

        private string StringToListBox(Item item)
        {
            return item.Id + ":" + item.Name;
        }

        private void PrintToTextBox(Item item)
        {
            if (AddCheck)
            {
                IDTextBox.Text = item.Id.ToString();
                CostTextBox.Text = item.Cost.ToString();
                NameTextBox.Text = item.Name.ToString();
                DescrirtionTextBox.Text = item.Info.ToString();
            }
            else
            {
                IDTextBox.Text = Items[Index].Id.ToString();
                CostTextBox.Text = item.Cost.ToString();
                NameTextBox.Text = item.Name.ToString();
                DescrirtionTextBox.Text = item.Info.ToString();
            }
        }

        private void CleanTextBox()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescrirtionTextBox.Clear();
        }

        private void ListBoxLineChange(List<Item> items)
        {
            ItemsListBox.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ItemsListBox.Items.Add(StringToListBox(items[i]));
            }
        }

    }
}