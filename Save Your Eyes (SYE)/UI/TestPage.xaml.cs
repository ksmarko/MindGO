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
using System.Text.RegularExpressions;
using System.Windows.Shapes;

namespace LAP.UI
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public static TestPage instance;
        public int score0 = 0; //what is a comp
        public int score1 = 0; //base el

        public int maxSc0 = 6; //max score per level - 6 questions == 6 marks
        public int maxSc1 = 15;
        
        public TestPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void ConfirmTest(object sender, RoutedEventArgs e)
        {
            if (testLesson0.Visibility == Visibility.Visible && testLesson1.Visibility == Visibility.Hidden)
            {
                string[] text = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"test0.txt", System.Text.Encoding.Default);

                List<string> ans = new List<string>();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains("+"))
                    {
                        ans.Add(Regex.Replace(text[i], "[+]?", "").Trim());
                    }
                    else continue;
                }

                foreach (var el in stQ.Children)
                    if (el is StackPanel)
                        foreach (RadioButton rb in (el as StackPanel).Children)
                            if (rb.IsChecked == true && ans.Contains(rb.Content))
                                score0++;

                if (score0 >= maxSc0 - 1)
                {
                    MessageBox.Show("Тест пройдено! \nВаш результат: " + score0 + "/" + maxSc0, "Результат тесту", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainPage.instance.txtScore.Text = (score0 + score1) + "/" + (maxSc0 + maxSc1);
                    MainPage.instance.OpenIntro(1);
                    MainPage.instance.exp1.IsExpanded = true;

                    MainPage.instance.ico0.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckboxBlankCircle;
                    MainPage.instance.ico1.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckboxBlankCircleOutline;

                    foreach (var el in stQ.Children)
                        if (el is StackPanel)
                            foreach (RadioButton rb in (el as StackPanel).Children)
                                rb.IsChecked = false;

                }
                else
                {
                    MessageBox.Show("Тест  не пройдено! \nВаш результат: " + score0 + "/" + maxSc0, "Результат тесту", MessageBoxButton.OK, MessageBoxImage.Error);

                    foreach (var el in stQ.Children)
                        if (el is StackPanel)
                            foreach (RadioButton rb in (el as StackPanel).Children)
                                rb.IsChecked = false;

                    score0 = 0;
                }
            }

            else if (testLesson1.Visibility == Visibility.Visible && testLesson0.Visibility == Visibility.Hidden)
            {
                string[] text = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"test1.txt", System.Text.Encoding.Default);

                List<string> ans = new List<string>();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].Contains("+"))
                    {
                        ans.Add(Regex.Replace(text[i], "[+]?", "").Trim());
                    }
                    else continue;
                }

                foreach (var el in stQ1.Children)
                    if (el is StackPanel)
                        foreach (RadioButton rb in (el as StackPanel).Children)
                            if (rb.IsChecked == true && ans.Contains(rb.Content))
                                score1++;

                if (score1 >= maxSc1 - 3)
                {
                    MessageBox.Show("Тест пройдено! \nВаш результат: " + score1 + "/" + maxSc1, "Результат тесту", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainPage.instance.txtScore.Text = (score0 + score1) + "/" + (maxSc0 + maxSc1);

                    MainPage.instance.OpenIntro(2);

                    MainPage.instance.exp2.IsExpanded = true;

                    MainPage.instance.ico0.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckboxBlankCircle;
                    MainPage.instance.ico1.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckboxBlankCircle;
                    MainPage.instance.ico2.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckboxBlankCircleOutline;

                    MainPage.instance.ico2.Foreground = Brushes.Teal;

                    foreach (var el in stQ1.Children)
                        if (el is StackPanel)
                            foreach (RadioButton rb in (el as StackPanel).Children)
                                rb.IsChecked = false;
                }
                else
                {
                    MessageBox.Show("Тест  не пройдено! \nВаш результат: " + score1 + "/" + maxSc1, "Результат тесту", MessageBoxButton.OK, MessageBoxImage.Error);

                    foreach (var el in stQ1.Children)
                        if (el is StackPanel)
                            foreach (RadioButton rb in (el as StackPanel).Children)
                                rb.IsChecked = false;

                    score1 = 0;
                }
            }

        }

        private void LoadData(object sender, RoutedEventArgs e)
        {

        }
    }
}
