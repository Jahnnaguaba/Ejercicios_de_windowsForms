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
            string Telef�no = mtxtTelef�no.Text;
            string Correo = txtCorreo.Text;
            string C�dula = mtxtC�dula.Text;




            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(FechaNacimiento) ||
                 string.IsNullOrWhiteSpace(Telef�no) || string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(C�dula))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mtxtC�dula.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese una c�dula v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mtxtTelef�no.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese un Tele�no v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mtxtFechanacimiento.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese una c�dula v�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Usuario Registrado:\n" + $"Nombre: {Nombre}\n"
               + $"Fecha de Nacimiento: {FechaNacimiento:dd/MM/yyyy}\n"
               + $"Tel�fono: {Telef�no}\n" + $"Correo: {Correo}\n"
               + $"C�dula: {C�dula}", "Registro Exitoso",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtp.Value;
            mtxtFechanacimiento.Text = date.ToString("MM/dd/yyyy");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("�Est�s seguro de que deseas salir?", "Confirmaci�n de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
