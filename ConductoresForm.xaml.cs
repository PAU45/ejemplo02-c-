using System.Windows;

namespace WpfApp1
{
    public partial class ConductoresForm : Window
    {
        public Conductor ConductorActual { get; set; }

        // Constructor para crear nuevo
        public ConductoresForm()
        {
            InitializeComponent();
            ConductorActual = new Conductor();
        }

        // Constructor para editar existente
        public ConductoresForm(Conductor existente)
        {
            InitializeComponent();
            ConductorActual = existente;

            // Cargar datos en los TextBox
            txtNombre.Text = existente.Nombre;
            txtLicencia.Text = existente.Licencia;
            txtTransporte.Text = existente.Transporte;
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            ConductorActual.Nombre = txtNombre.Text;
            ConductorActual.Licencia = txtLicencia.Text;
            ConductorActual.Transporte = txtTransporte.Text;

            DialogResult = true; // devuelve el resultado a la ventana listado
            this.Close();
        }
    }
}
