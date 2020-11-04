using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFCoreProject.Models;
using WPFCoreProject.Views;
using WPFCoreProjectLibrary;


namespace WPFCoreProject.Views
{
    public partial class MainWindow : Window
    {
        internal static MainWindow mw;
        internal static AddNew anw;

        List<Item> auctionedItems = new List<Item>();
        List<Item> similarItemsList = new List<Item>();

        public MainWindow()
        {
            InitializeComponent();

            mw = this;

            DataGetter();

        }

        public void UpdateData()
        {
            mainMenuListBoxOne.ItemsSource = null;
            mainMenuListBoxOne.ItemsSource = auctionedItems;
            mainMenuListBoxOne.DisplayMemberPath = "ItemName";

        }

        public void UpdateSimilarData()
        {
            mainMenuListBoxTwo.ItemsSource = null;
            mainMenuListBoxTwo.ItemsSource = similarItemsList;
            mainMenuListBoxTwo.DisplayMemberPath = "ItemName";
        }


        private void mainMenuExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mainMenuAddNewButton_Click(object sender, RoutedEventArgs e)
        {
            anw = new AddNew();
            anw.Show();
        }

        public void AddNewItem(Item item)
        {
            auctionedItems.Add(item);

            UpdateData();

        }

        public void DataGetter()
        {
            DataAccess da = new DataAccess();

            auctionedItems = da.GetItems();

            UpdateData();
        }

        public void DataRemove(Item model)
        {
            DataAccess da = new DataAccess();

            da.RemoveItem(model);

        }

        private void mainMenuRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Item itemToBeRemoved = new Item();
            itemToBeRemoved = (Item)mainMenuListBoxOne.SelectedItem;

            auctionedItems.Remove(itemToBeRemoved);

            DataRemove((Item)mainMenuListBoxOne.SelectedItem);

            UpdateData();

        }

        private void mainMenuEnterCategoryHereTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            mainMenuEnterCategoryHereTextBox.Text = "";
        }

        private void mainMenuEnterNameHereTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            mainMenuEnterNameHereTextBox.Text = "";
        }

        private void mainMenuEnterNameHereTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mainMenuEnterNameHereTextBox.Text == "")
            {
                mainMenuEnterNameHereTextBox.Text = "Name";
            }
        }

        private void mainMenuEnterCategoryHereTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mainMenuEnterCategoryHereTextBox.Text == "")
            {
                mainMenuEnterCategoryHereTextBox.Text = "Category";
            }
        }

        private void mainMenuListBoxOne_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (mainMenuListBoxOne.SelectedItem != null)
            {
                Item selectedItem = new Item();
                selectedItem = (Item)mainMenuListBoxOne.SelectedItem;

                DataAccess da = new DataAccess();

                similarItemsList = da.GetByName(selectedItem);

                UpdateSimilarData();
            }
        }
    }
}
