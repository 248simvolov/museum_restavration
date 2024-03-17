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

namespace museum_restavration.Window_
{
    /// <summary>
    /// Логика взаимодействия для restaveacia.xaml
    /// </summary>
    public partial class restaveacia : Window
    {
        public restaveacia()
        {
            InitializeComponent();
            frfr.Content = new Page_.vhod();
        }
    }
}
