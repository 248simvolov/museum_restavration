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
    /// Логика взаимодействия для dobrestr.xaml
    /// </summary>
    public partial class dobrestr : Page
    {
        Реставратор реставраторг;
        Экспонат экспонатг;
        public dobrestr(Реставратор реставратор, Экспонат экспонат)
        {
            InitializeComponent();
            реставраторг = реставратор;
            экспонатг = экспонат;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new restovratc_museumEntities())
                {
                    StringBuilder sb = new StringBuilder();
                    if (dpnach.Text.Length == 0)
                        sb.Append("Введите дату начала реставрации\n");
                    if (dpcon.Text.Length == 0)
                        sb.Append("Введите дату окончания реставрации\n");
                    if (tbrab.Text == null)
                        sb.Append("Введите отчет о проделанной работе\n");
                    if (sb.Length == 0)
                    {
                        context.Растврация.Add(new Растврация() { Время_начала = dpnach.DisplayDate, Время_окончания = dpcon.DisplayDate, Проделанная_работа = tbrab.Text, Реставратор = реставраторг.Код_реставратора, Эксопнат = экспонатг.Код_экспоната });
                        context.SaveChanges();
                        MessageBox.Show("Данные успешно добавлены");
                        this.NavigationService.Content = new eksponavti(реставраторг);
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
