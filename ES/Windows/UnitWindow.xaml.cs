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
    /// Логика взаимодействия для UnitWindow.xaml
    /// </summary>
    public partial class UnitWindow : Window
    {
        public UnitWindow(EF.User user)
        {
            InitializeComponent();
            if(user.LanguageId==1 && user.LevelId == 1)
            {
                frame.Navigate(new Pages.EnglishUnit.FirstUnit());
            }
          
        }


      
    }
}
