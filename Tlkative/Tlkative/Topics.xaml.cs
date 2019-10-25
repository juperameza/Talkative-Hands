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

namespace Tlkative
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Topics : Window
    {
        public Topics()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comboxCatego.Text == "Colors")
            {
                this.Hide();
                Colors Colores = new Colors();
                Colores.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Alphabet")
            {
                this.Hide();
                Alphabet Alfabeto = new Alphabet();
                Alfabeto.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Numbers")
            {
                this.Hide();
                Numbers Numeros = new Numbers();
                Numeros.Show();
                this.Close();
            }


            }
    }
}
