using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathServiceWpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Convertir el valor del TextBox a un número entero
            if (int.TryParse(Valor.Text, out int iValue))
            {
                // De momento, establecer un resultado de prueba
                Resultado.Content = "quien sabe";
            }
            else
            {
                // Si la conversión falla, mostrar un mensaje de error
                Resultado.Content = "Ingrese un número válido";
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}