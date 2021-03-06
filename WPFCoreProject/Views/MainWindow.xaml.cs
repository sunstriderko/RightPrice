﻿using System;
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
using WPFCoreProjectLibrary.Models;
using WPFCoreProjectUI.Views;

namespace WPFCoreProject.Views
{
    public partial class MainWindow : Window
    {
        internal static MainWindow mw;
        internal static AddNew anw;
        internal static ContactInfo cimw;

        List<Item> auctionedItems = new List<Item>();
        List<Item> similarItemsList = new List<Item>();

        User loggedUser = new User();

        public MainWindow(User model)
        {
            InitializeComponent();

            mw = this;

            DataGetter();

            loggedUser = model;

            mainMenuLoggedUserTextbox.Text = loggedUser.Username.ToString();

        }

        public void UpdateMainData()
        {
            mainMenuListBoxOne.ItemsSource = null;
            mainMenuListBoxOne.ItemsSource = auctionedItems;
            //mainMenuListBoxOne.DisplayMemberPath = "ItemName";

            mainMenuListBoxTwo.ItemsSource = null;

        }

        public void UpdateSimilarData()
        {
            mainMenuListBoxTwo.ItemsSource = null;
            mainMenuListBoxTwo.ItemsSource = similarItemsList;
            //mainMenuListBoxTwo.DisplayMemberPath = "AuctionInfo";
        }

        private void mainMenuExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void mainMenuAddNewButton_Click(object sender, RoutedEventArgs e)
        {
            anw = new AddNew(loggedUser);
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
           
            itemToBeRemoved = (Item)mainMenuListBoxTwo.SelectedItem;

            if (mainMenuListBoxTwo.SelectedItem != null)
            {
                if (itemToBeRemoved.CreatorId == loggedUser.Id)
                {                  
                    auctionedItems.Remove((Item)mainMenuListBoxOne.SelectedItem);

                    DataRemove((Item)mainMenuListBoxTwo.SelectedItem);

                    UpdateMainData();

                }

                else
                {
                    MessageBox.Show("You are not the creator of this item!", "Invalid user!", MessageBoxButton.OK);

                }
            }

            else
            {
                MessageBox.Show("You have to select an item!", "Invalid input", MessageBoxButton.OK);

            }
           
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

        private void mainWindowContactButton_Click(object sender, RoutedEventArgs e)
        {
            Item selectedItemToContact = new Item();

            if (mainMenuListBoxTwo.SelectedItem != null)
            {
                selectedItemToContact = (Item)mainMenuListBoxTwo.SelectedItem;

                cimw = new ContactInfo(selectedItemToContact);
                cimw.Show();
            }

            else
            {
                MessageBox.Show("Nothing is selected!", "Invalid input", MessageBoxButton.OK);

            }
        }
    }
}
