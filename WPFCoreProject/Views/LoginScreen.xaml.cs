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
using WPFCoreProject.Views;
using WPFCoreProjectLibrary;
using WPFCoreProjectLibrary.Models;

namespace WPFCoreProjectUI.Views
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        internal static MainWindow mwls;

        User loggedUser = new User();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginScreenExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void loginScreenLoginButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess da = new DataAccess();

            User currentUser = new User();
            List<User> currentUsers = new List<User>();

            currentUser.Username = loginScreenUsernameTextbox.Text;
            currentUser.Password = loginScreenPasswordPasswordbox.Password;

            currentUsers = da.GetAvailibleUsers(currentUser);

            try
            {
                UserCreditabilityChecker(currentUsers);

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Username or Password is invalid!", "Invalid input.", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            finally
            {
                MessageBox.Show("Try again or create a new account.", "Options", MessageBoxButton.OK);

            }


        }

        private void loginScreenCreateNewButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess da = new DataAccess();

            User loggingUser = new User();
            loggingUser.Username = loginScreenUsernameTextbox.Text;
            loggingUser.Password = loginScreenPasswordPasswordbox.Password;

            da.CreateUser(loggingUser);

        }

        public void UserCreditabilityChecker(List<User> model)
        {
            if (model.Count == 0)
            {
                throw new ArgumentNullException();

            }

        }
    }
}
