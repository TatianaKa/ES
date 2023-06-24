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

namespace ES.Pages.EnglishLesson
{
    /// <summary>
    /// Логика взаимодействия для FirstLesson.xaml
    /// </summary>
    public partial class FirstLesson : Page
    {
        public FirstLesson()
        {
            InitializeComponent();
            List<string> lines = new List<string>();
            var lesson = ClassHelper.AppData.context.Lesson.Where(i => i.Id == 1).First();
            // lines.Add(File.ReadAllText("C:\\Users\\Tatyana\\source\\repos\\ES\\ES\\Res\\Глагол to be 1_1.txt", Encoding.UTF8));
            lines.Add(File.ReadAllText(lesson.ContentFile, Encoding.UTF8));

            LvLessons.ItemsSource = lines;
            var question = ClassHelper.AppData.context.Question.Where(i => i.LessonId == 1).ToList();
            var quest1Id= question[0].Id;
            var quest2Id= question[1].Id;
            txbQuest1.Text = question[0].Essence;
            txbQuest2.Text = question[1].Essence;
            LvAnswers1.ItemsSource =ClassHelper.AppData.context.Answer.Where(i=>i.QuestionId==quest1Id).ToList();
        }
    }
}
