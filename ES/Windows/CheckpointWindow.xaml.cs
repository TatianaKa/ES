using ES.Pages;
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
using System.Windows.Shapes;

namespace ES.Windows
{
    /// <summary>
    /// Логика взаимодействия для CheckpointWindow.xaml
    /// </summary>
    public partial class CheckpointWindow : Window
    {
        public CheckpointWindow(int numCheckpoint)
        {
            InitializeComponent();
            if (numCheckpoint == 1) {
                frame.Navigate(new CheckpointFirstLesson());
            }
        }
    }
}
