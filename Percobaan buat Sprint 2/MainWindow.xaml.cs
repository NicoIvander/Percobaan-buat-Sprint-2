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

namespace Percobaan_buat_Sprint_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_berechnen_Click(object sender, RoutedEventArgs e)
        {
            double kopfdiameter = Convert.ToDouble(tb_kopfdiameter.Text);
            double silinderdiameter = Convert.ToDouble(tb_silinderdiameter.Text);
            double silinderhoehe = Convert.ToDouble(tb_silinderhoehe.Text);
            double kopfhoehe = Convert.ToDouble(tb_kopfhoehe.Text);
            double dichte = Convert.ToDouble(tb_dichte.Text);

            tb_volume.Text = Convert.ToString(2 * Math.PI * silinderhoehe * Math.Pow(silinderdiameter/2, 2) + (Math.PI * Math.Pow(kopfdiameter/2, 2) * kopfhoehe));
            tb_oberflaesche.Text = Convert.ToString((Math.PI * 2 * (silinderdiameter/2) * ((silinderdiameter/2) + silinderhoehe)) + (2 * Math.PI * Math.Pow(((Math.Pow((silinderdiameter/2), 32) + 2 * Math.Pow((kopfdiameter/2) * kopfhoehe, 16)) / 3), (1 / 16))));
            tb_gewicht.Text = Convert.ToString (Convert.ToDouble (tb_volume) * dichte);

            tb_answer.Text = ("Volume = " + tb_volume + " mm3") \n ("Fläsche = " + tb_oberflaesche + "mm2") \n ("Gewicht = " + tb_gewicht + " Kg");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
