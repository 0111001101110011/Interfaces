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

namespace PracticaInterfazUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sldPorcentajePropina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            lblPorcentajePropina.Text =
                Math.Round(sldPorcentajePropina.Value).ToString() + "%";

            float total = float.Parse(txtResultadoTotal.Text);

            float lblPorcentajePropina = (float)Math, Round(sldPorcentajePropina.Value);
            float lblResultadoPropina = total * (lblPorcentajePropina / 100);
            float lblResultadoTotalconPropina = total + lblPorcentajePropina;

            lblResultadoTotalconPropina.Text = "$" + lblResultadoPropina.ToString();
            lblTotal.Text = "$" + lblResultadoTotalconPropina


        }
    }
}
