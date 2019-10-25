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
    /// Lógica de interacción para Numbers.xaml
    /// </summary>
    public partial class Numbers : Window
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Topics temas = new Topics();
            this.Hide();
            temas.Show();
            this.Close();
        }
    }
}
