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
    /// Логика взаимодействия для LessonContentPage.xaml
    /// </summary>
    public partial class LessonContentPage : Page
    {
        public static LessonContentPage instance;
        public LessonContentPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            txt2_1_1.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"2.1.1.txt", System.Text.Encoding.Default);
            txt2_1_2.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"2.1.2.txt", System.Text.Encoding.Default);
            txt2_1_3.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"2.1.3.txt", System.Text.Encoding.Default);
            txt2_1_4.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"2.1.4.txt", System.Text.Encoding.Default);

            txt2_2_1.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"2.2.1.txt", System.Text.Encoding.Default);
            txt2_2_2.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"2.2.2.txt", System.Text.Encoding.Default);
        }
    }
}
