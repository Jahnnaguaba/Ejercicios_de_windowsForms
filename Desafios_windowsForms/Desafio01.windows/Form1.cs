namespace Ejercicio01.windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (!decimal.TryParse(txtSueldobruto.Text, out decimal sueldoBruto))
            {
                MessageBox.Show("Por favor, introduce un sueldo bruto válido.");
                return;
            }

            if (!int.TryParse(txtHijos.Text, out int cantidadHijos))
            {
                MessageBox.Show("Por favor, introduce un número válido de hijos.");
                return;
            }

            // Valores de las deducciones
            decimal afp = sueldoBruto * 0.0287m; // 2.87% AFP
            decimal sfs = sueldoBruto * 0.0304m; // 3.04% SFS
            decimal isr = CalcularISR(sueldoBruto); // ISR calculado mensual
            decimal Otros = 0;


            // Calcular total de deducciones y sueldo neto
            decimal totalDeducciones = afp + sfs + isr + Otros;
            decimal sueldoNeto = sueldoBruto - totalDeducciones;

            // Mostrar los resultados
            txtAFP.Text = afp.ToString("F2");
            txtSFS.Text = sfs.ToString("F2");
            txtISR.Text = isr.ToString("F2");
            txtotros.Text = Otros.ToString("F2");
            txtTotalDecuentos.Text = totalDeducciones.ToString("F2");
            txtSueldoneto.Text = sueldoNeto.ToString("F2");
        }

        private decimal CalcularISR(decimal sueldoBrutoMensual)
        {
            // Tramos mensuales de ISR para República Dominicana (2024)
            decimal sueldoMensual = sueldoBrutoMensual;
            if (sueldoMensual <= 34685) // Hasta RD$34,685.00: Exento
                return 0;
            if (sueldoMensual <= 52027) // De RD$34,685.01 a RD$52,027.00: 15% del excedente
                return (sueldoMensual - 34685) * 0.15m;
            if (sueldoMensual <= 72260) // De RD$52,027.01 a RD$72,260.00: 20% + cuota fija
                return (sueldoMensual - 52027) * 0.20m + 2601.30m; // Cuota fija de RD$2,601.30
            return (sueldoMensual - 72260) * 0.25m + 6647.38m; // 25% + cuota fija de RD$6,647.38
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtNombre.Clear();
            txtCargo.Clear();
            txtSueldobruto.Clear();
            txtHijos.Clear();
            txtAFP.Clear();
            txtSFS.Clear();
            txtISR.Clear();
            txtotros.Clear();
            txtTotalDecuentos.Clear();
            txtSueldoneto.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

