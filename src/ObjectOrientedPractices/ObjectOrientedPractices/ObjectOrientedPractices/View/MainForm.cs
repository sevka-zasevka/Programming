using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices.View
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Store _store = new Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.CustomersOrder = _store.Customers;
            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
        }
        
        public void SelectedTabChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 2)
            {
                CartsTab.UpdateDataItems(ItemsTab.Items);
                CartsTab.UpdateDataCustomers(CustomersTab.Customers);
            }
            if (MainTabControl.SelectedIndex == 3)
            {
                OrdersTab.UpdateOrdersTabData(CustomersTab.Customers);
            }
        }

        public void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            CartsTab.UpdateDataItems(ItemsTab.Items);
            CartsTab.UpdateDataCustomers(CustomersTab.Customers);
            OrdersTab.UpdateOrdersTabData(CustomersTab.Customers);
        }
    }
}