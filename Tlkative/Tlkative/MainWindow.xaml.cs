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
using System.Data.OleDb;//Agregamos libreria OleDB
using System.Data; //Agregamos System.Data

namespace Tlkative
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection con; //Agregamos la conexión
        DataTable dt;   //Agregamos la tabla
        public MainWindow()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\Tlktive.mdb";
        }

        private void BtnSignin_Click(object sender, RoutedEventArgs e)
        {

            if(txtUser.Text=="juperameza" && txtPass.Password == "tonicol" || txtUser.Text == "cori" && txtPass.Password == "sanchez" || txtUser.Text == "juana" && txtPass.Password == "sibe" || txtUser.Text == "Toño" && txtPass.Password == "disney")
            {
                
                this.Hide();
                Topics Ventanatopcs = new Topics();
                Ventanatopcs.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please sign up");
            }
        }

        private void BtnSignup_Click(object sender, RoutedEventArgs e)
        {
     
            this.Hide();
            SUP Ventanasup = new SUP();
            Ventanasup.Show();
            this.Close();
        }
    }
}
