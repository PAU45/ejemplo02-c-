using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public partial class Conductores : Window
    {
        public ObservableCollection<Conductor> ConductoresLista { get; set; }

        public Conductores()
        {
            InitializeComponent();

            ConductoresLista = new ObservableCollection<Conductor>();
            dgConductores.ItemsSource = ConductoresLista;
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            ConductoresForm form = new ConductoresForm();
            if (form.ShowDialog() == true)
            {
                ConductoresLista.Add(form.ConductorActual);
            }
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (dgConductores.SelectedItem is Conductor seleccionado)
            {
                ConductoresForm form = new ConductoresForm(seleccionado);
                if (form.ShowDialog() == true)
                {
                    dgConductores.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un conductor para editar.");
            }
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgConductores.SelectedItem is Conductor seleccionado)
            {
                ConductoresLista.Remove(seleccionado);
            }
            else
            {
                MessageBox.Show("Selecciona un conductor para eliminar.");
            }
        }
    }
}
