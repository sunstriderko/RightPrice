using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFCoreProjectLibrary;
using WPFCoreProjectLibrary.Models;

namespace WPFCoreProjectUI.Views
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        User newUser = new User();

        public NewUser()
        {
            InitializeComponent();
        }

        private void newUserCreateButton_Click(object sender, RoutedEventArgs e)
        {

            bool validEmail = newUserEmailTextbox.Text.Contains('@');

            if (validEmail)
            {
                newUser.Username = newUserUsernameTextbox.Text;
                newUser.Password = newUserPasswordbox.Password;
                newUser.PhoneNumber = newUserPhoneNumberTextbox.Text;
                newUser.Email = newUserEmailTextbox.Text;

                DataAccess da = new DataAccess();

                da.CreateUser(newUser);

                this.Close();

            }

            else
            {
                MessageBox.Show("Invalid email format", "Invalid input!", MessageBoxButton.OK);

            }
        }

        private void newUserExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
