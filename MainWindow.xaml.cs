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

namespace AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numero;

        public MainWindow()
        {
            InitializeComponent();

            numero = GeneraAleatorio(100);
        }


        public int GeneraAleatorio(int maximo)
        {
            Random rnd = new Random();
            return rnd.Next(maximo+1);
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numero = GeneraAleatorio(100);
            NumeroTextBox.Text = "";
            ResultadoTextBlock.Text = "";
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse(NumeroTextBox.Text) < numero)
            {
                ResultadoTextBlock.Text = "Te has quedado corto";
            }
            else if (Int32.Parse(NumeroTextBox.Text) > numero)
            {
                ResultadoTextBlock.Text = "Te has pasado";
            }
            else
            {
                ResultadoTextBlock.Text = "¡Has acertado!";
            }
        }
    }
}
