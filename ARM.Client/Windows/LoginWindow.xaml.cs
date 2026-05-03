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

namespace ARM.Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }
        bool isDark = false;
        private void UserPasswordBox_PasswordChanged(object sender, RoutedEventArgs e) => CheckPlaceholder();
        private void UserPasswordBox_GotFocus(object sender, RoutedEventArgs e) => CheckPlaceholder(); 
        private void UserPasswordBox_LostFocus(object sender, RoutedEventArgs e) => CheckPlaceholder();
        private void CheckPlaceholder()
        {
            if (UserPasswordBox.IsFocused || UserPasswordBox.Password.Length > 0)
            {
                PasswordPlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordPlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
