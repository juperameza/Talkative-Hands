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
            else if (comboxCatego.Text == "The five w's")
            {
                this.Hide();
                _5ws dobls = new _5ws();
                dobls.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Accesories")
            {
                this.Hide();
                Accesories acc = new Accesories();
                acc.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Animals")
            {
                this.Hide();
                Accesories acc = new Accesories();
                acc.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Clothing")
            {
                this.Hide();
                Clothing cloth = new Clothing();
                cloth.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Days")
            {
                this.Hide();
                Days D = new Days();
                D.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Family")
            {
                this.Hide();
                Family fam = new Family();
                fam.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Financial")
            {
                this.Hide();
                Financial fin = new Financial();
                fin.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Jobs")
            {
                this.Hide();
                Jobs jo = new Jobs();
                jo.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Medical")
            {
                this.Hide();
                Medical med = new Medical();
                med.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Name")
            {
                this.Hide();
                Name na = new Name();
                na.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Ocupations")
            {
                this.Hide();
                Ocupations ocu = new Ocupations();
                ocu.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Payments")
            {
                this.Hide();
                Payments pay = new Payments();
                pay.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Pronouns")
            {
                this.Hide();
                Pronouns pro = new Pronouns();
                pro.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Symptoms")
            {
                this.Hide();
                Symptoms sy = new Symptoms();
                sy.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Symptoms")
            {
                this.Hide();
                Symptoms sy = new Symptoms();
                sy.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Time")
            {
                this.Hide();
                Time ti = new Time();
                ti.Show();
                this.Close();
            }
            else if (comboxCatego.Text == "Verbs")
            {
                this.Hide();
                Verb ve = new Verb();
                ve.Show();
                this.Close();
            }
        }
    }
}
