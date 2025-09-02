using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Operaciones_Click(object sender, RoutedEventArgs e)
        {
            Operaciones op = new Operaciones();
            op.ShowDialog();
        }

        private void Mantenimientos_Click(object sender, RoutedEventArgs e)
        {
            Mantenimientos mt = new Mantenimientos();
            mt.ShowDialog();
        }

        private void Reportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes rp = new Reportes();
            rp.ShowDialog();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
