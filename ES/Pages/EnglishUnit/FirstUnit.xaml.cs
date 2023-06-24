using ES.Windows;
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

namespace ES.Pages.EnglishUnit
{
    /// <summary>
    /// Логика взаимодействия для FirstUnit.xaml
    /// </summary>
    public partial class FirstUnit : Page
    {
        public FirstUnit()
        {
            InitializeComponent();
            var lesson1 = ClassHelper.AppData.context.Lesson.Where(i => i.UnitId == 1).ToList();
            LvUnit1.ItemsSource = lesson1;
            var unit1 = ClassHelper.AppData.context.Unit.Where(i => i.Id == 1).FirstOrDefault();
            txbName1.Text = unit1.Name;
            txbName1.Text = unit1.Description;

            var lesson2 = ClassHelper.AppData.context.Lesson.Where(i => i.UnitId == 2).ToList();
            LvUnit2.ItemsSource = lesson2;
            var unit2 = ClassHelper.AppData.context.Unit.Where(i => i.Id == 2).FirstOrDefault();
            txbName2.Text = unit2.Name;
            txbName2.Text = unit2.Description;
        }
        private void LvUnit1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var lesson = LvUnit1.SelectedItem as EF.Lesson;
            if (lesson != null)
            {
                if (lesson.Name == "Глагол to be")
                {
                    LessonWindow lessonWindow = new LessonWindow(1);
                    lessonWindow.ShowDialog();
                }

            }
        }

        private void checkpoint1_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void checkpoint2_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
