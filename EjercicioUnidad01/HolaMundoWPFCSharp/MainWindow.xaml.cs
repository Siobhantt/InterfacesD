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
using Biblioteca;
namespace HolaMundoWPFCSharp
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

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            clsPersona nombre = new clsPersona();
            nombre.Nombre = txtnombre.Text;
            if (txtnombre.Text == "" ||  txtnombre.Text == " ")
            {
                advertencia.Content = "El nombre no puede estar vacio.";
            }
            else
            {
                MessageBox.Show("Hola " + nombre.Nombre + "!");
            }
        }
    }
}
