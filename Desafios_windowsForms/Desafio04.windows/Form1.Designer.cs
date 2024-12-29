namespace Desafio01._3windows
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
            label1 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpFechaDesde = new DateTimePicker();
            label4 = new Label();
            dtpFechaHasta = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            panel1 = new Panel();
            lstReservas = new ListBox();
            panel2 = new Panel();
            cmbTipoHabitacion = new ComboBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            BtnEliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(230, 10);
            label1.Name = "label1";
            label1.Size = new Size(237, 35);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Reserva";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.MistyRose;
            txtCliente.Location = new Point(197, 111);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(123, 31);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 111);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 164);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 3;
            label3.Text = "Fecha_desde";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.CalendarMonthBackground = Color.MistyRose;
            dtpFechaDesde.CalendarTitleBackColor = Color.Snow;
            dtpFechaDesde.Location = new Point(197, 158);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(364, 31);
            dtpFechaDesde.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 217);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 5;
            label4.Text = "Fecha_hasta";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.CalendarMonthBackground = Color.MistyRose;
            dtpFechaHasta.CalendarTitleBackColor = Color.Snow;
            dtpFechaHasta.Location = new Point(197, 217);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(364, 31);
            dtpFechaHasta.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 273);
            label5.Name = "label5";
            label5.Size = new Size(146, 24);
            label5.TabIndex = 7;
            label5.Text = "Tipo_habitacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(84, 341);
            label6.Name = "label6";
            label6.Size = new Size(62, 24);
            label6.TabIndex = 9;
            label6.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.MistyRose;
            txtPrecio.Location = new Point(197, 337);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(123, 31);
            txtPrecio.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(lstReservas);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cmbTipoHabitacion);
            panel1.Controls.Add(txtCliente);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpFechaDesde);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpFechaHasta);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 594);
            panel1.TabIndex = 11;
            // 
            // lstReservas
            // 
            lstReservas.FormattingEnabled = true;
            lstReservas.ItemHeight = 25;
            lstReservas.Location = new Point(34, 429);
            lstReservas.Name = "lstReservas";
            lstReservas.Size = new Size(722, 129);
            lstReservas.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 51);
            panel2.TabIndex = 12;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.BackColor = Color.MistyRose;
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Doble", "Individual", "Triple", "Suite" });
            cmbTipoHabitacion.Location = new Point(197, 269);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(182, 33);
            cmbTipoHabitacion.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(46, 607);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(521, 607);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(357, 607);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(195, 607);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 34);
            BtnEliminar.TabIndex = 15;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 688);
            Controls.Add(BtnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaDesde;
        private Label label4;
        private DateTimePicker dtpFechaHasta;
        private Label label5;
        private Label label6;
        private TextBox txtPrecio;
        private Panel panel1;
        private ComboBox cmbTipoHabitacion;
        private Panel panel2;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button BtnEliminar;
        private ListBox lstReservas;
    }
}
