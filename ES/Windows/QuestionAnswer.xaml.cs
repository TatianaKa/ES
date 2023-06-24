using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ES.Windows
{
    /// <summary>
    /// Логика взаимодействия для QuestionAnswer.xaml
    /// </summary>
    public partial class QuestionAnswer : Window
    {
        public QuestionAnswer()
        {
            InitializeComponent();
            var question1 = ClassHelper.AppData.context.Answer.Where(i => i.QuestionId == 1).First();
            tvName.Text = ClassHelper.AppData.context.Question.Where(i => i.Id == 1).First().Essence;
            LvQuest.ItemsSource = ClassHelper.AppData.context.Answer.Where(i => i.QuestionId == question1.Id).ToList();
            var question2 = ClassHelper.AppData.context.Answer.Where(i => i.QuestionId == 2).First();
            tvQuestion2.Text = ClassHelper.AppData.context.Question.Where(i => i.Id == 2).First().Essence;
            LvQuest2.ItemsSource = ClassHelper.AppData.context.Answer.Where(i => i.QuestionId == 2).ToList();
            //me.Play();
        }
    }

}
