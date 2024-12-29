namespace Desafio3.windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            mtxtFechanacimiento = new MaskedTextBox();
            mtxtTelefóno = new MaskedTextBox();
            mtxtCédula = new MaskedTextBox();
            txtCorreo = new TextBox();
            btnRegistrar = new Button();
            dtp = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(276, 39);
            label1.TabIndex = 1;
            label1.Text = "Registro de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 150);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 377);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 2;
            label3.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(179, 324);
            label4.Name = "label4";
            label4.Size = new Size(75, 27);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(163, 260);
            label5.Name = "label5";
            label5.Size = new Size(91, 27);
            label5.TabIndex = 4;
            label5.Text = "Telefóno";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(73, 199);
            label6.Name = "label6";
            label6.Size = new Size(200, 27);
            label6.TabIndex = 5;
            label6.Text = "Fecha de nacimiento";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.AliceBlue;
            txtNombre.Location = new Point(292, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 31);
            txtNombre.TabIndex = 6;
            // 
            // mtxtFechanacimiento
            // 
            mtxtFechanacimiento.BackColor = Color.AliceBlue;
            mtxtFechanacimiento.Location = new Point(292, 199);
            mtxtFechanacimiento.Mask = "00/00/0000";
            mtxtFechanacimiento.Name = "mtxtFechanacimiento";
            mtxtFechanacimiento.Size = new Size(316, 31);
            mtxtFechanacimiento.TabIndex = 7;
            mtxtFechanacimiento.ValidatingType = typeof(DateTime);
            // 
            // mtxtTelefóno
            // 
            mtxtTelefóno.BackColor = Color.AliceBlue;
            mtxtTelefóno.Location = new Point(292, 260);
            mtxtTelefóno.Mask = "(999)000-0000";
            mtxtTelefóno.Name = "mtxtTelefóno";
            mtxtTelefóno.Size = new Size(316, 31);
            mtxtTelefóno.TabIndex = 8;
            // 
            // mtxtCédula
            // 
            mtxtCédula.BackColor = Color.AliceBlue;
            mtxtCédula.Location = new Point(292, 377);
            mtxtCédula.Mask = "000-0000000-0";
            mtxtCédula.Name = "mtxtCédula";
            mtxtCédula.Size = new Size(316, 31);
            mtxtCédula.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.AliceBlue;
            txtCorreo.Location = new Point(292, 324);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(316, 31);
            txtCorreo.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSkyBlue;
            btnRegistrar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.SteelBlue;
            btnRegistrar.Location = new Point(312, 500);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(146, 48);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtp
            // 
            dtp.Location = new Point(292, 199);
            dtp.Name = "dtp";
            dtp.Size = new Size(361, 31);
            dtp.TabIndex = 13;
            dtp.ValueChanged += dtp_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(773, 599);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCorreo);
            Controls.Add(mtxtCédula);
            Controls.Add(mtxtTelefóno);
            Controls.Add(mtxtFechanacimiento);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dtp);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private MaskedTextBox mtxtFechanacimiento;
        private MaskedTextBox mtxtTelefóno;
        private MaskedTextBox mtxtCédula;
        private TextBox txtCorreo;
        private Button btnRegistrar;
        private DateTimePicker dtp;
    }
}
