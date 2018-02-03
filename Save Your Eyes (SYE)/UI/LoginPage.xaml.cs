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

namespace LAP.UI
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        bool hasAccount = false;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            if (hasAccount)
            {
                if (txtLogin.Text == "Admin" && txtPass.Password == "Password")
                {
                    MainWindow.instance.ShowMainPageUI(sender, e);
                    MainPage.instance.txtUserName.Text = "Ксю";

                    txtLogin.Text = "";
                    txtPass.Password = "";
                    txtUserName.Text = "";
                    MainWindow.instance.grdMain.Background = Brushes.WhiteSmoke;
                }
                else MessageBox.Show("Невірний логін або пароль", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (txtLogin.Text != "" && txtPass.Password != "" && txtUserName.Text != "")
                {
                    MessageBox.Show("Реєстрація пройшла успішно!");
                    MainWindow.instance.ShowMainPageUI(sender, e);
                    MainPage.instance.txtUserName.Text = this.txtUserName.Text;

                    txtLogin.Text = "";
                    txtPass.Password = "";
                    txtUserName.Text = "";
                    MainWindow.instance.grdMain.Background = Brushes.WhiteSmoke;
                }
                else MessageBox.Show("Введіть дані", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (hasAccount)
            {
                lblSignLog.Content = "Реєстрація";
                lblUserName.Visibility = Visibility.Visible;
                txtUserName.Visibility = Visibility.Visible;
                btnSignLog.Content = "Зареєструватись";
                lblNavigation.Content = "Уже аккаунт? Увійти";
                txtLogin.Text = "";
                txtPass.Password = "";
                txtUserName.Text = "";
                hasAccount = false;
            }
            else
            {
                lblSignLog.Content = "Вхід";
                lblUserName.Visibility = Visibility.Collapsed;
                txtUserName.Visibility = Visibility.Collapsed;
                btnSignLog.Content = "Увійти";
                lblNavigation.Content = "Нема аккаунту? Зареєструватись";
                txtLogin.Text = "";
                txtPass.Password = "";
                txtUserName.Text = "";
                hasAccount = true;

            }
        }
    }
}
