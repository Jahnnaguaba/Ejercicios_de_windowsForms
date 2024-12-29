using System.Windows.Forms;

namespace Desafio._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            dtgInfo.Rows.Add(txtNombre.Text, cmbCargo.Text, txtHijos.Text, txtSueldo.Text,
               txtSueldo_neto.Text, txtTotal_descuentos.Text);

            
            LimpiarCampos();
        }
       

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if (dtgInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgInfo.SelectedRows[0];

                
                filaSeleccionada.Cells[0].Value = txtNombre.Text;
                filaSeleccionada.Cells[1].Value = cmbCargo.Text;
                filaSeleccionada.Cells[2].Value = txtHijos.Text;
                filaSeleccionada.Cells[3].Value = txtSueldo.Text;
                filaSeleccionada.Cells[4].Value = txtSueldo_neto.Text;
                filaSeleccionada.Cells[5].Value = txtTotal_descuentos.Text;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }
        private void CalcularDescuentos()
        {
           
            decimal sueldo = 0;
            if (decimal.TryParse(txtSueldo.Text, out sueldo))
            {
               
                decimal afp = sueldo * 0.0287m;
                decimal sfs = sueldo * 0.0304m; 

                
                decimal isr = 0;
                if (sueldo > 867123)
                {
                    isr = 79776 + (sueldo - 867123) * 0.25m;
                }
                else if (sueldo > 624329)
                {
                    isr = 31216 + (sueldo - 624329) * 0.20m;
                }
                else if (sueldo > 416220)
                {
                    isr = (sueldo - 416220) * 0.15m;
                }

               
                decimal totalDescuentos = afp + sfs + isr;

                
                decimal sueldoNeto = sueldo - totalDescuentos;

                
                txtAFP.Text = afp.ToString("F2");
                txtSFS.Text = sfs.ToString("F2");
                txtISR.Text = isr.ToString("F2");
                txtTotal_descuentos.Text = totalDescuentos.ToString("F2");
                txtSueldo_neto.Text = sueldoNeto.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un sueldo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularDescuentos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();            
            cmbCargo.SelectedIndex = -1;  
            txtSueldo.Clear();            
            txtHijos.Clear();             
            txtSueldo_neto.Clear();        
            txtTotal_descuentos.Clear();   
        }
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dtgInfo.SelectedRows.Count > 0)
            {
                dtgInfo.Rows.RemoveAt(dtgInfo.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
        private void bntSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
