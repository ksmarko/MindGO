using MaterialDesignThemes.Wpf;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static MainPage instance;

        public MainPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            txtIntroContent.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"introContent.txt", System.Text.Encoding.Default);
            ico0.Kind = PackIconKind.CheckboxBlankCircleOutline;
            ico1.Kind = PackIconKind.CheckboxBlankCircle;
            ico2.Kind = PackIconKind.CheckboxBlankCircle;
            txtScore.Text = "0/21";
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedItem = (sender as ListBox).SelectedIndex;

            switch ((sender as ListBox).Name)
            {
                case "lst1": //основні елементи комп'ютера
                    switch (selectedItem)
                    {
                        case 0: //материнка
                            OpenLesson("Материнська плата", "1.0");
                            break;
                        case 1: //біос
                            OpenLesson("БІОС", "1.1");
                            break;
                        case 2: //процесор
                            OpenLesson("Процесор" , "");
                            break;
                        case 3: //ОЗП
                            OpenLesson("ОЗП", "");
                            break;
                        case 4: //жорсткий диск
                            OpenLesson("Жорсткий диск", "");
                            break;
                        case 5: //відеокарта
                            OpenLesson("Відеокарта", "");
                            break;
                        case 6: //блок живлення
                            OpenLesson("Блок живлення", "");
                            break;
                        case 7: //test
                            Console.WriteLine(TestPage.instance.score0 + "    " + TestPage.instance.maxSc0);
                            if (TestPage.instance.score0 >= TestPage.instance.maxSc0 - 1)
                            {
                                TestPage.instance.testLesson1.Visibility = Visibility.Visible;
                                TestPage.instance.testLesson0.Visibility = Visibility.Hidden;
                                OpenTest(null, null);
                            }
                            else
                                MessageBox.Show("Для проходження тесту необхідно пройти тест попередніх рівнів", "Обережно", MessageBoxButton.OK, MessageBoxImage.Error);

                            break;
                    }
                    lst2.SelectedIndex = -1;
                    break;
            }
        } 

        //при нажатии на экспандер
        private void ExpanderClick(object sender, RoutedEventArgs e)
        {
            lst1.SelectedIndex = -1;
            lst2.SelectedIndex = -1;

            switch ((sender as Expander).Name)
            {
                case "exp0": 
                    OpenIntro(0);
                    break;
                case "exp1":
                    OpenIntro(1);
                    break;
                case "exp2":
                    OpenIntro(2); //page is not available
                    break;
                case "exp3": 
                    OpenIntro(3); //page is not available
                    break;
                case "exp4":
                    OpenIntro(4); //page is not available 
                    break;
                case "exp5":
                    OpenIntro(5); //page is not available
                    break;
                case "exp6":
                    OpenIntro(6); //page is not available
                    break;
            }
        }

        public void OpenIntro(int page_id)
        {
            ShowIntroUI();

            switch (page_id)
            {
                case 0:
                    IntroPage.instance.fieldWhatIsComputer.Visibility = Visibility.Visible;
                    IntroPage.instance.fieldError.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldBaseElements.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldNoContent.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    IntroPage.instance.fieldBaseElements.Visibility = Visibility.Visible;
                    IntroPage.instance.fieldError.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldWhatIsComputer.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldNoContent.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    if (TestPage.instance.score0 + TestPage.instance.score1 >= TestPage.instance.maxSc0 + TestPage.instance.maxSc1 - 4)
                    {
                        IntroPage.instance.fieldNoContent.Visibility = Visibility.Visible;
                        IntroPage.instance.fieldError.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        IntroPage.instance.fieldError.Visibility = Visibility.Visible;
                        IntroPage.instance.fieldNoContent.Visibility = Visibility.Hidden;
                    }
                    IntroPage.instance.fieldWhatIsComputer.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldBaseElements.Visibility = Visibility.Hidden;
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    IntroPage.instance.fieldError.Visibility = Visibility.Visible;
                    IntroPage.instance.fieldWhatIsComputer.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldBaseElements.Visibility = Visibility.Hidden;
                    IntroPage.instance.fieldNoContent.Visibility = Visibility.Hidden;
                    break;

            }
        }

        private void OpenLesson(string context, string page_id)
        {
            LessonClick(null, null);

            switch(page_id)
            {
                case "1.0": //Материнська плата
                    LessonContentPage.instance.fieldMotherPlate.Visibility = Visibility.Visible;
                    LessonContentPage.instance.fieldError.Visibility = Visibility.Hidden;
                    LessonContentPage.instance.fieldBIOS.Visibility = Visibility.Hidden;
                    break;
                case "1.1": //БІОС
                    LessonContentPage.instance.fieldBIOS.Visibility = Visibility.Visible;
                    LessonContentPage.instance.fieldMotherPlate.Visibility = Visibility.Hidden;
                    LessonContentPage.instance.fieldError.Visibility = Visibility.Hidden;
                    break;
                case "": //not available
                    LessonContentPage.instance.fieldError.Visibility = Visibility.Visible;
                    LessonContentPage.instance.fieldMotherPlate.Visibility = Visibility.Hidden;
                    LessonContentPage.instance.fieldBIOS.Visibility = Visibility.Hidden;
                    break;
            }
        }


        #region pages 
        private void ShowIntroUI()
        { 
            IntroUI.Visibility = Visibility.Visible;
            IntroUI.IsEnabled = true;

            LessonContentUI.Visibility = Visibility.Hidden;
            LessonContentUI.IsEnabled = false;

            TestContentUI.Visibility = Visibility.Hidden;
            TestContentUI.IsEnabled = false;
        }

        public void OpenTest(object sender, RoutedEventArgs e)
        {
            TestContentUI.Visibility = Visibility.Visible;
            TestContentUI.IsEnabled = true;

            LessonContentUI.Visibility = Visibility.Hidden;
            LessonContentUI.IsEnabled = false;

            IntroUI.Visibility = Visibility.Hidden;
            IntroUI.IsEnabled = false;
        }

        private void LessonClick(object sender, RoutedEventArgs e)
        {
            LessonContentUI.Visibility = Visibility.Visible;
            LessonContentUI.IsEnabled = true;

            TestContentUI.Visibility = Visibility.Hidden;
            TestContentUI.IsEnabled = false;

            IntroUI.Visibility = Visibility.Hidden;
            IntroUI.IsEnabled = false;
        }

        //когда курсор уходит с экспандера
        private void lstItemUnselected(object sender, MouseEventArgs e)
        {
            (sender as Expander).Background = Brushes.Transparent;
        }

        //при наведении на экспандер
        private void lstItemSelected(object sender, MouseEventArgs e)
        {
            (sender as Expander).Background = new SolidColorBrush(Color.FromArgb(40, 3, 9, 3));
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow.instance.LogOutMethod(null, null);
        }

        private void OpenMainPage(object sender, MouseButtonEventArgs e)
        {
            IntroUI.Visibility = Visibility.Hidden;
            IntroUI.IsEnabled = false;

            LessonContentUI.Visibility = Visibility.Hidden;
            LessonContentUI.IsEnabled = false;

            TestContentUI.Visibility = Visibility.Hidden;
            TestContentUI.IsEnabled = false;
        }

        #endregion
    }
}
