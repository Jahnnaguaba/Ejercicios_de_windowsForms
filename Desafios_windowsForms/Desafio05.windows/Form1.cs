namespace Desafio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal totalGeneral = 0;

        private void btnCalcularSubtotal_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) ||
                string.IsNullOrWhiteSpace(txtITBIS.Text))
            {
                MessageBox.Show("Por favor, complete los campos: Cantidad, Precio Unitario e ITBIS.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            decimal itbisPorcentaje = decimal.Parse(txtITBIS.Text) / 100;


            decimal subtotal = (precioUnitario * cantidad) * (1 + itbisPorcentaje);


            txtSubtotal.Text = subtotal.ToString("F2");


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtITBIS.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) ||
                string.IsNullOrWhiteSpace(txtSubtotal.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.");
                return;
            }

            string articulo = txtArticulo.Text;
            string descripcion = txtDescripcion.Text;
            decimal itbis = decimal.Parse(txtITBIS.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            decimal subtotal = decimal.Parse(txtSubtotal.Text);


            dataGridView1.Rows.Add(articulo, descripcion, itbis, cantidad, subtotal);

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            txtArticulo.Clear();
            txtDescripcion.Clear();
            txtITBIS.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtSubtotal.Clear();

        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            totalGeneral = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["Subtotal"].Value != null &&
                    decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal Subtotal))
                {
                    totalGeneral += Subtotal;
                }
            }


            txtTotalPagar.Text = totalGeneral.ToString("F2");
            ;

        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            // Validar que el total esté calculado
            if (totalGeneral <= 0)
            {
                MessageBox.Show("No se ha calculado el total. Por favor, añada productos y calcule el total.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar efectivo ingresado
            if (string.IsNullOrWhiteSpace(txtEfectivo.Text) || decimal.Parse(txtEfectivo.Text) < totalGeneral)
            {
                MessageBox.Show("El efectivo ingresado es insuficiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal efectivo = decimal.Parse(txtEfectivo.Text);
            decimal cambio = efectivo - totalGeneral;

            // Crear la factura
            string factura = "NOMBRE COMERCIAL: Tienda Ejemplo S.A.\n";
            factura += "DIRECCIÓN: Calle Ficticia 123\n";
            factura += "TELÉFONO: 809-555-5555\n\n";
            factura += "------------------------------------------\n";
            factura += "ARTÍCULO    DESCRIPCIÓN     ITBIS   CANTIDAD    VALOR\n";
            // Agregar los datos de la tabla
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Articulo"].Value != null &&
                    row.Cells["Descripcion"].Value != null &&
                    row.Cells["ITBIS"].Value != null &&
                    row.Cells["Cantidad"].Value != null &&
                    row.Cells["Subtotal"].Value != null)
                {
                    factura += $"{(row.Cells["Articulo"].Value?.ToString() ?? "").PadRight(12)}" +
                               $"{(row.Cells["Descripcion"].Value?.ToString() ?? "").PadRight(15)}" +
                               $"{(row.Cells["ITBIS"].Value?.ToString() ?? "").PadRight(8)}" +
                               $"{(row.Cells["Cantidad"].Value?.ToString() ?? "").PadRight(10)}" +
                               $"{(row.Cells["Subtotal"].Value?.ToString() ?? "").PadRight(10)}\n";
                }
            }

            // Agregar totales
            factura += "------------------------------------------\n";
            factura += $"TOTAL A PAGAR:             {totalGeneral.ToString("F2")}\n";
            factura += $"EFECTIVO:                 {efectivo.ToString("F2")}\n";
            factura += $"CAMBIO:                   {cambio.ToString("F2")}\n";

            // Guardar la factura en un archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto (.txt)|.txt";
            saveFileDialog.Title = "Guardar Factura";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, factura);
                MessageBox.Show("Factura generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

