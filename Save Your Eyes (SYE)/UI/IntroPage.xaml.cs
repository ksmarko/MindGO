using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для LessonPage.xaml
    /// </summary>
    public partial class IntroPage : Page
    {
        public static IntroPage instance;
        public IntroPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            txt1_1.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"1.1.txt", System.Text.Encoding.Default);
            txt1_2.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"1.2.txt", System.Text.Encoding.Default);
            txt1_3.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"1.3.txt", System.Text.Encoding.Default);

        }

        private void OpenTest(object sender, RoutedEventArgs e)
        {
            TestPage.instance.testLesson0.Visibility = Visibility.Visible;
            TestPage.instance.testLesson1.Visibility = Visibility.Hidden;

            MainPage.instance.OpenTest(null, null);
        }
    }
}
