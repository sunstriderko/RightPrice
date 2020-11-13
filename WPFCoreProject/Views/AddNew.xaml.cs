    using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFCoreProject.Models;
using WPFCoreProject.Views;
using System.Linq;
using WPFCoreProjectLibrary;
using WPFCoreProjectLibrary.Models;

namespace WPFCoreProject.Views
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        public Item newItem = new Item();


        public AddNew(User model)
        {
            InitializeComponent();

            newItem.CreatorId = model.Id;
        }

        private void addNewExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void addNewAddButton_Click(object sender, RoutedEventArgs e)
        {            
            newItem.ItemName = addNewNameTextBox.Text;
            newItem.ItemValue = Int32.Parse(addNewPriceTextBox.Text);
            newItem.ItemCategory = addNewCategoryTextBox.Text;

            DataAccess da = new DataAccess();
            da.InsertAuction(newItem);

            MainWindow.mw.AddNewItem(newItem);

            this.Close();
        }

        private void addNewNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            addNewNameTextBox.Text = "";
        }

        private void addNewPriceTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            addNewPriceTextBox.Text = "";
        }

        private void addNewCategoryTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            addNewCategoryTextBox.Text = "";
        }
    }
}
