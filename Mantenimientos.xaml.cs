using System.Windows;

namespace WpfApp1
{
    public partial class Mantenimientos : Window
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores win = new Conductores();
            win.ShowDialog();
        }
    }
}
