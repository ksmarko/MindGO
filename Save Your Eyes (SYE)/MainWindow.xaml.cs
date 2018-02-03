using MahApps.Metro.Controls;
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

namespace LAP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            instance = this;
        }

        public void ShowLoginPageUI(object sender, RoutedEventArgs e)
        {
            LoginPageUI.IsEnabled = true;
            LoginPageUI.Visibility = Visibility.Visible;

            MainPageUI.IsEnabled = false;
            MainPageUI.Visibility = Visibility.Hidden;
        }

        public void ShowMainPageUI(object sender, RoutedEventArgs e)
        {
            MainPageUI.IsEnabled = true;
            MainPageUI.Visibility = Visibility.Visible;

            LoginPageUI.IsEnabled = false;
            LoginPageUI.Visibility = Visibility.Hidden;
        }

        public void LogOutMethod(object sender, RoutedEventArgs e)
        {
            ShowLoginPageUI(sender, e);
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("pack://application:,,,/LAP;component/Media/3.png"));
            myBrush.ImageSource = image.Source;
            grdMain.Background = myBrush;
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            txtHello.Text = "Бажаєш отримати знання про будову комп'ютера? \nХочеш розуміти процеси, що відбуваються всередині твого \"залізного звіра\"? \nЗначить тобі до нас!";
        }

        private void grdMain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
