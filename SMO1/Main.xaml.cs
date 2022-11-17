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

namespace SMO1
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_theory(object sender, RoutedEventArgs e)
        {
            Theory th = new Theory();
            th.Show();
            Close();
        }

        private void NSMO_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void SMO_Checked(object sender, RoutedEventArgs e)
        {
            SMO smo = new SMO();
            smo.Show();
            Close();
        }
    }
}
