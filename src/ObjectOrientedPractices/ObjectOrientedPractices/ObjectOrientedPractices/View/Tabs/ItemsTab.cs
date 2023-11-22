using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Tabs
{
    internal partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие изменения Списка товаров.
        /// </summary>
        public event EventHandler ItemsChanged;
        /// <summary>
        /// Список объектов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Список объектов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> sortItems = new List<Item>();
        /// <summary>
        /// Объект класса <see cref="Item"/> со значениями полей: 
        /// название - "Name", информация - "info" и цена - 0.1.
        /// </summary>
        private Item SelectedItem = new Item("Name", "info", 0.1, 0);
        /// <summary>
        /// Целочисленная пелеменная для запоминания индекса.
        /// </summary>
        private int Index;
        /// <summary>
        /// Целочисленная переменная - счётчик.
        /// </summary>
        private int Count = 1;
        /// <summary>
        /// Булевая переменная - флаг для добавления товаров..
        /// </summary>
        private bool AddCheck;
        /// <summary>
        /// булевая переменная - флаг для текстбоксов.
        /// </summary>
        private bool PrintCheck;

        /// <summary>
        /// Возвращает и задает список товаров класса <see cref="Item"/>.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public ItemsTab()
        {
            InitializeComponent();
            foreach (string category in Enum.GetNames(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category.ToString());
            }
            string[] sortTypes = new string[3]{"Cost (Ascending)", "Cost (Descending)", "Name"};
            SortComboBox.Items.AddRange(sortTypes);
            SortComboBox.SelectedIndex = 2;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCheck = true;
            VisibleItems(false);
            Item item = new Item("Name " + Count.ToString(), "Info", 0.1, 0);
            Count++;
            Items.Add(item);
            ItemsListBox.Items.Add(StringToListBox(item));
            ItemsListBox.SelectedIndex = (ItemsListBox.Items.Count) - 1;
            FindSelectionItemInSortList();
            SelectedItem.Name = Items[Index].Name;
            SelectedItem.Info = Items[Index].Info;
            SelectedItem.Cost = Items[Index].Cost;
            SelectedItem.Category = Items[Index].Category;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrintCheck)
            {
                try
                {
                    double newCost = Convert.ToDouble(CostTextBox.Text);
                    SelectedItem.Cost = newCost;
                    CostTextBox.BackColor = Color.White;
                    OkButton.Visible = true;
                    CostValidationLabel.Visible = false;
                    int currentSelection = CostTextBox.SelectionStart;
                    CostTextBox.Focus();
                    CostTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    CostTextBox.BackColor = Color.LightPink;
                    CostValidationLabel.Visible = true;
                    OkButton.Visible = false;
                }
            }

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrintCheck)
            {
                try
                {
                    string newName = NameTextBox.Text.ToString();
                    SelectedItem.Name = newName;
                    NameTextBox.BackColor = Color.White;
                    NameValidationLabel.Visible = false;
                    OkButton.Visible = true;
                    int currentSelection = NameTextBox.SelectionStart;
                    NameTextBox.Focus();
                    NameTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    NameTextBox.BackColor = Color.LightPink;
                    NameValidationLabel.Visible = true;
                    OkButton.Visible = false;
                }
            }
        }

        private void DescrirtionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrintCheck)
            {
                try
                {
                    string newDescription = DescrirtionTextBox.Text.ToString();
                    SelectedItem.Info = newDescription;
                    DescrirtionTextBox.BackColor = Color.White;
                    DescriptionValidationLabel.Visible = false;
                    OkButton.Visible = true;
                    int currentSelection = DescrirtionTextBox.SelectionStart;
                    DescrirtionTextBox.Focus();
                    DescrirtionTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    DescrirtionTextBox.BackColor = Color.LightPink;
                    DescriptionValidationLabel.Visible = true;
                    OkButton.Visible = false;
                }
            }
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                int selectCategory = CategoryComboBox.SelectedIndex;
                if (selectCategory != -1)
                {
                    SelectedItem.Category = (Category)selectCategory;
                }
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = ItemsListBox.SelectedIndex;
            if (Index != -1)
            {
                FindSelectionItemInSortList();
                PrintCheck = false;
                PrintToTextBox(Items[Index]);
                PrintCheck = true;
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
                FindSelectionItemInSortList();
                Items.RemoveAt(Index);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
                ItemsListBox.Items.RemoveAt(Index);
                ItemsListBox.SelectedIndex = -1;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (AddCheck)
            {
                AddCheck = false;
                Items.RemoveAt(Index);
                ItemsListBox.Items.RemoveAt(Index);
                ItemsListBox.SelectedIndex = -1;
                VisibleItems(true);
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
            ItemsChanged?.Invoke(this, EventArgs.Empty);
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

        /// <summary>
        /// Метод для появления кнопок "ok" и "cancel"
        /// И исчезновения "Add", "Remove" и "Change".
        /// Также блокиет доступ к "ItemsListBox",
        /// "CostTextBox", "NameTextBox", "DescrirtionTextBox" и "CategoryComboBox". 
        /// И наоборот.
        /// </summary>
        /// <param name="visible">Булевая переменная для определения нужного состояния окна.</param>
        private void VisibleItems(bool visible)
        {
            AddButton.Visible = visible;
            RemoveButton.Visible = visible;
            ChangeButton.Visible = visible;
            OkButton.Visible = !visible;
            CancelButton.Visible = !visible;
            ItemsListBox.Enabled = visible; 
            SortComboBox.Enabled = visible;
            FindTextBox.Enabled = visible;
            CostTextBox.Enabled = !visible;
            NameTextBox.Enabled = !visible;
            DescrirtionTextBox.Enabled = !visible;
            CategoryComboBox.Enabled = !visible;
        }

        /// <summary>
        /// Метод для создания строки для вывод в Listbox.
        /// </summary>
        /// <param name="item">Объект класса <see cref="Item"/>.</param>
        /// <returns></returns>
        private string StringToListBox(Item item)
        {
            return item.Id + ":" + item.Name;
        }

        /// <summary>
        /// Метод для вывода значения полей выбранного покупателя
        /// в текстовые поля и в выпадающий список.
        /// </summary>
        /// <param name="item">Объект класса <see cref="Item"/>.</param>
        private void PrintToTextBox(Item item)
        {
            if (AddCheck)
            {
                IDTextBox.Text = item.Id.ToString();
                CostTextBox.Text = item.Cost.ToString();
                NameTextBox.Text = item.Name.ToString();
                DescrirtionTextBox.Text = item.Info.ToString();
                CategoryComboBox.Text = item.Category.ToString();
            }
            else
            {
                IDTextBox.Text = Items[Index].Id.ToString();
                CostTextBox.Text = item.Cost.ToString();
                NameTextBox.Text = item.Name.ToString();
                DescrirtionTextBox.Text = item.Info.ToString();
                CategoryComboBox.Text = item.Category.ToString();
            }
        }

        /// <summary>
        /// Метод для очистки всех текстовых полей и выпадающего списка.
        /// </summary>
        private void CleanTextBox()
        {
            IDTextBox.Clear();
            IDTextBox.BackColor = Color.White;
            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;
            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;
            DescrirtionTextBox.Clear();
            DescrirtionTextBox.BackColor = Color.White;
            CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод для изменения строки в CustomersListBox.
        /// </summary>
        /// <param name="items">Cписок объектов класса <see cref="Item"/>.</param>
        private void ListBoxLineChange(List<Item> items)
        {
            ItemsListBox.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                ItemsListBox.Items.Add(StringToListBox(items[i]));
            }
        }

        /// <summary>
        /// Проверяет содердит ли имя товара подстроку. 
        /// </summary>
        /// <param name="item">Товар. </param>
        /// <param name="str">Подстрока. </param>
        /// <returns>Булевое значение. </returns>
        public bool AssertString(Item item, object str)
        {
            if (item.Name.Contains((string)str))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Фильтрует товары относительно того, есть ли введенная строка в названии товара. 
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text != null && Items != null)
            {
                Item selectedItem = SelectedItem;
                foreach (Item item in Items)
                {
                    if (item.Name == (string)ItemsListBox.SelectedItem)
                    {
                        selectedItem = item;
                    }
                }
                sortItems.Clear();
                sortItems = DataTools.Filtration(Items, AssertString, FindTextBox.Text);
                ItemsListBox.Items.Clear();
                foreach (Item item in sortItems)
                {
                    ItemsListBox.Items.Add(StringToListBox(item));
                }
                if (sortItems.Contains(selectedItem))
                {
                    ItemsListBox.SelectedIndex = sortItems.IndexOf(selectedItem);
                    CleanTextBox();
                    AddCheck = true;
                    PrintToTextBox(selectedItem);
                    AddCheck = false;
                }
                else
                {
                    ItemsListBox.SelectedIndex = -1;
                    CleanTextBox();
                }

            }
        }

        /// <summary>
        /// Метод для нахождения индекса нужного товара в основном списке из отсортированного.
        /// </summary>
        public void FindSelectionItemInSortList()
        {
            if (Items.Count > 0)
            {
                if (sortItems.Count > 0)
                {
                    if (!AddCheck)
                    {
                        for (int i = 0; i < Items.Count; i++)
                        {
                            if (sortItems[Index] == Items[i])
                            {
                                Index = i;
                                return;
                            }
                        }
                    }
                }
            }

        }


        /// <summary>
        /// Сортирует листбокс с товарами в зависимости от выбранного значения в 
        /// комбобоксе. 
        /// </summary>
        public void SortItemsInListBox()
        {
            if (Items == null) return;
            Item selectedItem = SelectedItem;
            foreach (Item item in Items)
            {
                if (item.Name == (string)ItemsListBox.SelectedItem)
                {
                    selectedItem = item;
                }
            }
            List<Item> sortedItems = new List<Item>();
            if (SortComboBox.SelectedIndex == 0)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortCostAscending);
            }
            if (SortComboBox.SelectedIndex == 1)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortCostDescending);
            }
            if (SortComboBox.SelectedIndex == 2)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortName);
            }
            ItemsListBox.Items.Clear();
            foreach (Model.Item item in sortedItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }
            ItemsListBox.SelectedIndex = sortedItems.IndexOf(selectedItem);
        }

        /// <summary>
        /// Сортирует листбокс после изменения вида сортировки. 
        /// </summary>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortComboBox.SelectedIndex != -1 && Items != null)
            {
                SortItemsInListBox();
            }
        }
    }
}
