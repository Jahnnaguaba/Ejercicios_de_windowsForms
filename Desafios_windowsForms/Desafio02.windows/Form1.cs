namespace Ejercicio02.windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar notas
                double n1 = double.Parse(txtN1.Text);
                double n2 = double.Parse(txtN2.Text);
                double n3 = double.Parse(txtN3.Text);
                double n4 = double.Parse(txtN4.Text);

                // Calcular promedio
                double promedio = (n1 + n2 + n3 + n4) / 4;
                txtP.Text = promedio.ToString("F2");

                // Determinar estado según promedio
                if (promedio <= 70)
                {
                    txtEstatus.Text = "Mal";
                }
                else if (promedio >= 71 && promedio <= 79)
                {
                    txtEstatus.Text = "Puedes mejorar";
                }

                else if (promedio >= 80 && promedio <= 89)
                {
                    txtEstatus.Text = "Bien";
                }
                else if (promedio >= 90 && promedio <= 94)
                {
                    txtEstatus.Text = "Muy bien";
                }
                else if (promedio >= 95 && promedio <= 100)
                {
                    txtEstatus.Text = "Excelente";
                }
                else
                {
                    txtEstatus.Text = "Error en los valores";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en las notas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbCurso.SelectedIndex = -1;
            cmbSección.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            rdbMasculino.Checked = false;
            rdbFemenino.Checked = false;
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtP.Clear();
            txtEstatus.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }



}
