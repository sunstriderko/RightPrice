using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void UpdateMainData()
        {
            mainMenuListBoxOne.ItemsSource = null;
            mainMenuListBoxOne.ItemsSource = auctionedItems;
            mainMenuListBoxOne.DisplayMemberPath = "ItemName";

            mainMenuListBoxTwo.ItemsSource = null;

        }

        public void UpdateSimilarData()
        {
            mainMenuListBoxTwo.ItemsSource = null;
            mainMenuListBoxTwo.ItemsSource = similarItemsList;
            mainMenuListBoxTwo.DisplayMemberPath = "AuctionInfo";
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

            UpdateMainData();

        }

        public void DataGetter()
        {
            DataAccess da = new DataAccess();

            auctionedItems = da.GetItems();

            UpdateMainData();
        }

        public void DataRemove(Item model)
        {
            DataAccess da = new DataAccess();

            da.RemoveItem(model);

        }

        public void ValueFiller()
        {
            List<Item> itemsForValues = new List<Item>();
            Item currentElement = new Item();

            currentElement = (Item)mainMenuListBoxOne.SelectedItem;

            DataAccess da = new DataAccess();
            itemsForValues = da.GetByName(currentElement);
            int counter = itemsForValues.Count;

            mainMenuMaxValueTextbox.Text = $"{(itemsForValues.First().ItemValue).ToString()}$";

            mainMenuMinValueTextbox.Text = $"{itemsForValues[counter - 1].ItemValue.ToString()}$";

            mainMenuAvgValueTextbox.Text = $"{ItemsValueInListCounter(itemsForValues).ToString()}$";

        }

        public int ItemsValueInListCounter(List<Item> model)
        {
            int counter = 0;

            foreach (Item item in model)
            {
                counter += item.ItemValue;
            }

            counter = counter / model.Count;

            return counter;
        }

        private void mainMenuRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Item itemToBeRemoved = new Item();
            itemToBeRemoved = (Item)mainMenuListBoxOne.SelectedItem;

            auctionedItems.Remove(itemToBeRemoved);

            DataRemove((Item)mainMenuListBoxOne.SelectedItem);

            UpdateMainData();

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

                ValueFiller();
            }
        }

        private void mainMenuSearchButton_Click(object sender, RoutedEventArgs e)
        {

            if (!(mainMenuEnterCategoryHereTextBox.Text == "" || mainMenuEnterCategoryHereTextBox.Text == "Category") && (mainMenuEnterNameHereTextBox.Text == "" || mainMenuEnterNameHereTextBox.Text == "Name"))
            {
                Item sendedCategory = new Item();
                sendedCategory.ItemCategory = mainMenuEnterCategoryHereTextBox.Text;

                DataAccess da = new DataAccess();

                auctionedItems = da.GetByCategory(sendedCategory);

                UpdateMainData();

            }

            else if (!(mainMenuEnterNameHereTextBox.Text == "" || mainMenuEnterNameHereTextBox.Text == "Name") && (mainMenuEnterCategoryHereTextBox.Text == "" || mainMenuEnterCategoryHereTextBox.Text == "Category"))
            {
                Item sendedName = new Item();
                sendedName.ItemName = mainMenuEnterNameHereTextBox.Text;

                DataAccess da = new DataAccess();

                auctionedItems = da.SearchByName(sendedName);

                UpdateMainData();
            }

            else if (!(mainMenuEnterNameHereTextBox.Text == "" || mainMenuEnterNameHereTextBox.Text == "Name") && !(mainMenuEnterCategoryHereTextBox.Text == "" || mainMenuEnterCategoryHereTextBox.Text == "Category"))
            {
                Item sendedNameCategory = new Item();
                sendedNameCategory.ItemName = mainMenuEnterNameHereTextBox.Text;
                sendedNameCategory.ItemCategory = mainMenuEnterCategoryHereTextBox.Text;

                DataAccess da = new DataAccess();

                auctionedItems = da.GetByNameCategory(sendedNameCategory);

                UpdateMainData();

            }

            else
            {
                DataAccess da = new DataAccess();

                auctionedItems = da.GetItems();

                UpdateMainData();

            }
        }
    }
}
