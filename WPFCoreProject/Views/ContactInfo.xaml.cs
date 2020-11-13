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
using WPFCoreProjectLibrary;
using WPFCoreProjectLibrary.Models;

namespace WPFCoreProjectUI.Views
{
    /// <summary>
    /// Interaction logic for ContactInfo.xaml
    /// </summary>
    public partial class ContactInfo : Window
    {
        public ContactInfo(Item model)
        {
            InitializeComponent();

            GetUserInfo(model);

        }

        public void GetUserInfo(Item item)
        {
            User userInfo = new User();

            DataAccess da = new DataAccess();
            userInfo = da.GetContactInfo(item);

            contactInfoUsernameTextbox.Text = userInfo.Username;
            contactInfoEmailTextbox.Text = userInfo.Email;
            contactInfoPhoneTextbox.Text = userInfo.PhoneNumber;

        }

        private void contactInfoExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }        
    }
}
