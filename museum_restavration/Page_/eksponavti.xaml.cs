using museum_restavration.DB;
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

namespace museum_restavration.Page_
{
    /// <summary>
    /// Логика взаимодействия для eksponavti.xaml
    /// </summary>
    public partial class eksponavti : Page
    {
        Реставратор рестг = new Реставратор();
        public eksponavti(Реставратор реставратор)
        {
            рестг = реставратор;
            InitializeComponent();
            using (var context = new restovratc_museumEntities())
            {
                dgexpo.ItemsSource = context.Экспонат.ToList();
                var tipexponat = context.Тип_экспоната.ToList();
            }
        }

        private void brestr_Click(object sender, RoutedEventArgs e)
        {
            if (dgexpo.SelectedItems.Count >= 1)
                using (var context = new restovratc_museumEntities())
                {
                    var exp = dgexpo.SelectedItems.Cast<Экспонат>().ToList()[0];
                    this.NavigationService.Content = new dobrestr(рестг, exp);
                }
            else
                MessageBox.Show("Выберите экспонат");
        }

        private void bsmotr_Click(object sender, RoutedEventArgs e)
        {
            
            if (dgexpo.SelectedItems.Count >= 1)
                using (var context = new restovratc_museumEntities())
                {
                    var exp = dgexpo.SelectedItems.Cast<Экспонат>().ToList()[0];
                    this.NavigationService.Content = new smotrrestr(рестг, exp);
                }
            else
                MessageBox.Show("Выберите экспонат");
        }
    }
}
