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
    /// Логика взаимодействия для SMO.xaml
    /// </summary>
    public partial class SMO : Window
    {
        public SMO()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            Close();
        }

        private void btn_odn_SMO_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tz.Text))
            {
                if(string.IsNullOrEmpty(Tob.Text))
                {
                    MessageBox.Show("Введите данные для вычесления!");
                }
            }
            else
            {

                double a, b, c, d, f, q, p;

                //Считывыется значение Время заявок
                string tz = Tz.Text;
                //Переводится в значенеи с плавающей точкой 
                a = Convert.ToDouble(tz);

                c = 1 / a;

                Lambda.Text = string.Format("{0:N2}", c);

                //Считывыется значение Время обслуживания
                string tob = Tob.Text;
                //Переводится в значенеи с плавающей точкой
                b = Convert.ToDouble(tob);

                d = 1 / b;

                Mu.Text = string.Format("{0:N2}", d);

                f = (c * d) / (c + d);

                A.Text = string.Format("{0:N2}", f);

                q = d / (c + d);

                Q.Text = string.Format("{0:N2}", q);

                p = c / (c + d);

                P.Text = string.Format("{0:N2}", p);
            }
        }
    }
}
