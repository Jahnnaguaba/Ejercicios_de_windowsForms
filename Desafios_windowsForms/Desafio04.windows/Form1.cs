

namespace Desafio01._3windows
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCliente.Text) ||
                string.IsNullOrEmpty(cmbTipoHabitacion.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string reserva = $"Cliente: {txtCliente.Text}, Desde: {dtpFechaDesde.Value.ToShortDateString()}, " +
                             $"Hasta: {dtpFechaHasta.Value.ToShortDateString()}, " +
                             $"Habitación: {cmbTipoHabitacion.Text}, Precio: {txtPrecio.Text}";

           
            lstReservas.Items.Add(reserva);

            
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (lstReservas.SelectedItem != null)
            {
                lstReservas.Items.Remove(lstReservas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            cmbTipoHabitacion.SelectedIndex = -1;
            txtPrecio.Clear();
        }
    }
}