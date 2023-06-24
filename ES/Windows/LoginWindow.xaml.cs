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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = ClassHelper.AppData.context.User.Where(i => i.Email == txbLogin.Text && i.Password == txbPass.Text && i.IsActive == true).FirstOrDefault();
            if (user != null)
            {
                UnitWindow unit = new UnitWindow(user);
                unit.ShowDialog();
            }
        }
    }
}
