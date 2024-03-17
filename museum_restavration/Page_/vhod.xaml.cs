using museum_restavration.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace museum_restavration.Page_
{
    /// <summary>
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Page
    {
        public vhod()
        {
            InitializeComponent();
        }

        private void bvhod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (tblogin.Text.Length == 0)
                    sb.Append("Введите логин\n");
                if (tbpasswrd.Password.Length == 0)
                    sb.Append("Введите пароль\n");
                if (sb.Length > 0)
                    goto concheck;
                using(var context = new restovratc_museumEntities())
                {
                    var user = context.Реставратор.Where(l => l.Логин.Equals(tblogin.Text)).Where(p => p.Пароль.Equals(tbpasswrd.Password)).ToList().FirstOrDefault();
                    if (user != null)
                        this.NavigationService.Content = new eksponavti(user);
                    else
                        sb.Append("Пользователь не найден\n");
                }
                concheck:
                if (sb.Length > 0)
                    MessageBox.Show(sb.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
