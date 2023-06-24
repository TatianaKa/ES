using ES.EF;
using ES.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ES.Windows
{
    /// <summary>
    /// Логика взаимодействия для LessonWindow.xaml
    /// </summary>
    public partial class LessonWindow : Window
    {
        public LessonWindow(int numLesson)
        {
            InitializeComponent();
            if (numLesson == 1)
            {
                frame.Navigate(new Pages.EnglishLesson.FirstLesson());
            }
           
        }
    }
}
