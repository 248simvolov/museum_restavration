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
    /// Логика взаимодействия для smotrrestr.xaml
    /// </summary>
    public partial class smotrrestr : Page
    {
        Реставратор реставраторг;
        public smotrrestr(Реставратор реставратор ,Экспонат экспонат)
        {
            InitializeComponent();
            реставраторг = реставратор;
            using(var context = new restovratc_museumEntities())
            {
                dgsmotr.ItemsSource = context.Растврация.Where(i=> i.Эксопнат.ToString().Contains(экспонат.Код_экспоната.ToString())).ToList();
            }
        }

        private void bnazad_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new eksponavti(реставраторг);
        }
    }
}
