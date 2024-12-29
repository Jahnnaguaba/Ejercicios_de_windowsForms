using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Desafio3.windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string FechaNacimiento = mtxtFechanacimiento.Text;
            string Telefóno = mtxtTelefóno.Text;
            string Correo = txtCorreo.Text;
            string Cédula = mtxtCédula.Text;




            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(FechaNacimiento) ||
                 string.IsNullOrWhiteSpace(Telefóno) || string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(Cédula))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mtxtCédula.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mtxtTelefóno.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese un Teleóno válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mtxtFechanacimiento.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Usuario Registrado:\n" + $"Nombre: {Nombre}\n"
               + $"Fecha de Nacimiento: {FechaNacimiento:dd/MM/yyyy}\n"
               + $"Teléfono: {Telefóno}\n" + $"Correo: {Correo}\n"
               + $"Cédula: {Cédula}", "Registro Exitoso",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtp.Value;
            mtxtFechanacimiento.Text = date.ToString("MM/dd/yyyy");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
