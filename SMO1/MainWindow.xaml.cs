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

namespace SMO1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Скрытые Label
            P0.Visibility = Visibility.Hidden;
            P1.Visibility = Visibility.Hidden;
            P2.Visibility = Visibility.Hidden;
            P3.Visibility = Visibility.Hidden;
            P4.Visibility = Visibility.Hidden;
            P5.Visibility = Visibility.Hidden;
            //Скрытые TextBox
            p0.Visibility = Visibility.Hidden;
            p1.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            p4.Visibility = Visibility.Hidden;
            p5.Visibility = Visibility.Hidden;
        }

        private void btn_odn_SMOn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(N_can.Text))
            {
                MessageBox.Show("Введите количесвто каналов!");
            }
            else
            {
                double n, a1, b1, c1, d1, f1, q1, Poz1, p_0, p_1, p_2, p_3, p_4, p_5, k;

                string n_can = N_can.Text;
                n = Convert.ToDouble(n_can);

                //Считывается значение Время заявок
                string tz1 = Tz1.Text;
                //Переводится в значение с плавающей точкой 
                a1 = Convert.ToDouble(tz1);

                c1 = 1 / a1;

                Lambda1.Text = string.Format("{0:N2}", c1);

                //Считывыется значение Время обслуживания
                string tob2 = Tob2.Text;
                //Переводится в значение с плавающей точкой
                b1 = Convert.ToDouble(tob2);

                d1 = 1 / b1;

                Mu2.Text = string.Format("{0:N2}", d1);
            
                //Для двух каналов
                if (n == 2)
                {
                    P0.Visibility = Visibility.Visible;
                    P1.Visibility = Visibility.Visible;
                    P2.Visibility = Visibility.Visible;
                    P3.Visibility = Visibility.Hidden;
                    P4.Visibility = Visibility.Hidden;
                    P5.Visibility = Visibility.Hidden;

                    p0.Visibility = Visibility.Visible;
                    p1.Visibility = Visibility.Visible;
                    p2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Hidden;
                    p4.Visibility = Visibility.Hidden;
                    p5.Visibility = Visibility.Hidden;

                    double x = 1 + (c1 / d1) + (Math.Pow(c1, 2) / (2 * (Math.Pow(d1, 2))));

                    p_0 = 1 / Math.Pow(x, 1);

                    p0.Text = string.Format("{0:N2}", p_0);

                    p_1 = (c1 / d1) * p_0;

                    p1.Text = string.Format("{0:N2}", p_1);

                    p_2 = (Math.Pow(c1, 2) / (2 * Math.Pow(d1, 2))) * p_0;

                    p2.Text = string.Format("{0:N2}", p_2);

                    f1 = c1 * (1 - Math.Pow(c1 / d1, 2) * (p_0 / (2)));

                    A1.Text = string.Format("{0:N2}", f1);

                    q1 = 1 - Math.Pow(c1 / d1, 2) * p_0 / (2);

                    Math.Round(q1);

                    Q1.Text = string.Format("{0:N2}", q1);

                    Poz1 = Math.Pow(c1 / d1, 2) * p_0 / (2);

                    Math.Round(Poz1);

                    P_1.Text = string.Format("{0:N2}", Poz1);

                    k = (c1 / d1) * q1;

                    Math.Round(k);

                    K.Text = string.Format("{0:N2}", k);
                }

                //Для трёх каналов
                if (n == 3)
                {
                    P0.Visibility = Visibility.Visible;
                    P1.Visibility = Visibility.Visible;
                    P2.Visibility = Visibility.Visible;
                    P3.Visibility = Visibility.Visible;

                    p0.Visibility = Visibility.Visible;
                    p1.Visibility = Visibility.Visible;
                    p2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Visible;

                    double x = 1 + (c1 / d1) + (Math.Pow(c1, 2) / (2 * (Math.Pow(d1, 2)))) + (Math.Pow(c1, 3) / (2 * 3 * (Math.Pow(d1, 3)))) + (Math.Pow(c1, 4) / (2 * 3 * 4 * (Math.Pow(d1, 4))));

                    p_0 = 1 / Math.Pow(x, 1);

                    Math.Round(p_0);

                    p0.Text = string.Format("{0:N2}", p_0);

                    p_1 = (c1 / d1) * p_0;

                    Math.Round(p_1);

                    p1.Text = string.Format("{0:N2}", p_1);

                    p_2 = (Math.Pow(c1, 2) / (2 * Math.Pow(d1, 2))) * p_0;

                    Math.Round(p_2);

                    p2.Text = string.Format("{0:N2}", p_2);

                    p_3 = (Math.Pow(c1, 3) / (2 * 3 * Math.Pow(d1, 3))) * p_0;

                    Math.Round(p_3);

                    p3.Text = string.Format("{0:N2}", p_3);

                    f1 = c1 * (1 - Math.Pow(c1 / d1, 3) * (p_0 / (2 * 3)));

                    Math.Round(f1);

                    A1.Text = string.Format("{0:N2}", f1);

                    q1 = 1 - Math.Pow(c1 / d1, 3) * p_0 / (2 * 3);

                    Math.Round(q1);

                    Q1.Text = string.Format("{0:N2}", q1);

                    Poz1 = Math.Pow(c1 / d1, 3) * p_0 / (2 * 3);

                    Math.Round(Poz1);

                    P_1.Text = string.Format("{0:N2}", Poz1);

                    k = (c1 / d1) * q1;

                    Math.Round(k);

                    K.Text = string.Format("{0:N2}", k);
                }

                //Для четырёх каналов
                if (n == 4)
                {
                    P0.Visibility = Visibility.Visible;
                    P1.Visibility = Visibility.Visible;
                    P2.Visibility = Visibility.Visible;
                    P3.Visibility = Visibility.Visible;
                    P4.Visibility = Visibility.Visible;

                    p0.Visibility = Visibility.Visible;
                    p1.Visibility = Visibility.Visible;
                    p2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Visible;
                    p4.Visibility = Visibility.Visible;

                    double x = 1 + (c1 / d1) + (Math.Pow(c1, 2) / (2 * (Math.Pow(d1, 2)))) + (Math.Pow(c1, 3) / (2 * 3 * (Math.Pow(d1, 3)))) + (Math.Pow(c1, 4) / (2 * 3 * 4 * (Math.Pow(d1, 4))));

                    p_0 = 1 / Math.Pow(x, 1);

                    Math.Round(p_0);

                    p0.Text = string.Format("{0:N2}", p_0);

                    p_1 = (c1 / d1) * p_0;

                    Math.Round(p_1);

                    p1.Text = string.Format("{0:N2}", p_1);

                    p_2 = (Math.Pow(c1, 2) / (2 * Math.Pow(d1, 2))) * p_0;

                    Math.Round(p_2);

                    p2.Text = string.Format("{0:N2}", p_2);

                    p_3 = (Math.Pow(c1, 3) / (2 * 3 * Math.Pow(d1, 3))) * p_0;

                    Math.Round(p_3);

                    p3.Text = string.Format("{0:N2}", p_3);

                    p_4 = (Math.Pow(c1, 4) / (2 * 3 * 4 * Math.Pow(d1, 4))) * p_0;

                    Math.Round(p_4);

                    p4.Text = string.Format("{0:N2}", p_4);

                    f1 = c1 * (1 - Math.Pow(c1 / d1, 4) * (p_0 / (2 * 3 * 4)));

                    Math.Round(f1);

                    A1.Text = string.Format("{0:N2}", f1);

                    q1 = 1 - Math.Pow(c1 / d1, 4) * p_0 / (2 * 3 * 4);

                    Math.Round(q1);

                    Q1.Text = string.Format("{0:N2}", q1);

                    Poz1 = Math.Pow(c1 / d1, 4) * p_0 / (2 * 3 * 4);

                    Math.Round(Poz1);

                    P_1.Text = string.Format("{0:N2}", Poz1);

                    k = (c1 / d1) * q1;

                    Math.Round(k);

                    K.Text = string.Format("{0:N2}", k);
                }

                //Для пяти каналов
                if (n == 5)
                {
                    P0.Visibility = Visibility.Visible;
                    P1.Visibility = Visibility.Visible;
                    P2.Visibility = Visibility.Visible;
                    P3.Visibility = Visibility.Visible;
                    P4.Visibility = Visibility.Visible;
                    P5.Visibility = Visibility.Visible;

                    p0.Visibility = Visibility.Visible;
                    p1.Visibility = Visibility.Visible;
                    p2.Visibility = Visibility.Visible;
                    p3.Visibility = Visibility.Visible;
                    p4.Visibility = Visibility.Visible;
                    p5.Visibility = Visibility.Visible;

                    double x = 1 + (c1 / d1) + (Math.Pow(c1, 2) / (2 * (Math.Pow(d1, 2)))) + (Math.Pow(c1, 3) / (2 * 3 * (Math.Pow(d1, 3)))) + (Math.Pow(c1, 4) / (2 * 3 * 4 * (Math.Pow(d1, 4)))) + (Math.Pow(c1, 5) / (2 * 3 * 4 * 5 * (Math.Pow(d1, 5))));

                    p_0 = 1 / Math.Pow(x, 1);

                    Math.Round(p_0);

                    p0.Text = string.Format("{0:N2}", p_0);

                    p_1 = (c1 / d1) * p_0;

                    Math.Round(p_1);

                    p1.Text = string.Format("{0:N2}", p_1);

                    p_2 = (Math.Pow(c1, 2) / (2 * Math.Pow(d1, 2))) * p_0;

                    Math.Round(p_2);

                    p2.Text = string.Format("{0:N2}", p_2);

                    p_3 = (Math.Pow(c1, 3) / (2 * 3 * Math.Pow(d1, 3))) * p_0;

                    Math.Round(p_3);

                    p3.Text = string.Format("{0:N2}", p_3);

                    p_4 = (Math.Pow(c1, 4) / (2 * 3 * 4 * Math.Pow(d1, 4))) * p_0;

                    Math.Round(p_4);

                    p4.Text = string.Format("{0:N2}", p_4);

                    p_5 = (Math.Pow(c1, 5) / (2 * 3 * 4 * 5 * Math.Pow(d1, 5))) * p_0;

                    Math.Round(p_5);

                    p5.Text = string.Format("{0:N2}", p_5);

                    f1 = c1 * (1 - Math.Pow(c1 / d1, 5) * (p_0 / (2 * 3 * 4 * 5)));

                    Math.Round(f1);

                    A1.Text = string.Format("{0:N2}", f1);

                    q1 = 1 - Math.Pow(c1 / d1, 5) * p_0 / (2 * 3 * 4 * 5);
                    
                    Math.Round(q1);

                    Q1.Text = string.Format("{0:N2}", q1);

                    Poz1 = Math.Pow(c1 / d1, 5) * p_0 / (2 * 3 * 4 * 5);

                    Math.Round(Poz1);

                    P_1.Text = string.Format("{0:N2}", Poz1);

                    k = (c1 / d1) * q1;

                    Math.Round(k);
                
                    K.Text = string.Format("{0:N2}", k);
                }
            }
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            Close();
        }
    }
}
