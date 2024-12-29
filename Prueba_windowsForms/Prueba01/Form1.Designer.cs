namespace Desafio._05
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtAFP = new TextBox();
            txtSFS = new TextBox();
            txtSueldo = new TextBox();
            txtHijos = new TextBox();
            txtOtros = new TextBox();
            txtISR = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtSueldoIngreso = new TextBox();
            txtTotal_descuentos = new TextBox();
            txtSueldo_neto = new TextBox();
            cmbCargo = new ComboBox();
            button1 = new Button();
            bntSalir = new Button();
            bntEditar = new Button();
            bntEliminar = new Button();
            bntGuardar = new Button();
            bntLimpiar = new Button();
            Empleados = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            tabPage2 = new TabPage();
            dtgInfo = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            cargo = new DataGridViewTextBoxColumn();
            Hijos = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Sueldo_Neto = new DataGridViewTextBoxColumn();
            Impuestos = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            Empleados.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Cargo";
         
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 167);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 231);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 3;
            label4.Text = "Hijos";
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(238, 17);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 8;
            label5.Text = "Ingreso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 36);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 9;
            label6.Text = "AFP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 81);
            label7.Name = "label7";
            label7.Size = new Size(41, 25);
            label7.TabIndex = 10;
            label7.Text = "SFS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 129);
            label8.Name = "label8";
            label8.Size = new Size(38, 25);
            label8.TabIndex = 11;
            label8.Text = "ISR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 191);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 12;
            label9.Text = "Otros";
            
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(812, 17);
            label10.Name = "label10";
            label10.Size = new Size(137, 32);
            label10.TabIndex = 17;
            label10.Text = "Descuento";
            // 
            // txtAFP
            // 
            txtAFP.Location = new Point(104, 33);
            txtAFP.Name = "txtAFP";
            txtAFP.Size = new Size(150, 31);
            txtAFP.TabIndex = 18;
            // 
            // txtSFS
            // 
            txtSFS.Location = new Point(104, 81);
            txtSFS.Name = "txtSFS";
            txtSFS.Size = new Size(150, 31);
            txtSFS.TabIndex = 19;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(114, 164);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(150, 31);
            txtSueldo.TabIndex = 20;
            // 
            // txtHijos
            // 
            txtHijos.Location = new Point(114, 231);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(150, 31);
            txtHijos.TabIndex = 21;
            // 
            // txtOtros
            // 
            txtOtros.Location = new Point(104, 185);
            txtOtros.Name = "txtOtros";
            txtOtros.Size = new Size(150, 31);
            txtOtros.TabIndex = 23;
            // 
            // txtISR
            // 
            txtISR.Location = new Point(104, 129);
            txtISR.Name = "txtISR";
            txtISR.Size = new Size(150, 31);
            txtISR.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 300);
            label11.Name = "label11";
            label11.Size = new Size(180, 25);
            label11.TabIndex = 26;
            label11.Text = "Total_sueldo+ingreso";
          
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 238);
            label12.Name = "label12";
            label12.Size = new Size(146, 25);
            label12.TabIndex = 27;
            label12.Text = "Total_descuentos";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 286);
            label13.Name = "label13";
            label13.Size = new Size(110, 25);
            label13.TabIndex = 28;
            label13.Text = "Sueldo_neto";
            // 
            // txtSueldoIngreso
            // 
            txtSueldoIngreso.Location = new Point(204, 297);
            txtSueldoIngreso.Name = "txtSueldoIngreso";
            txtSueldoIngreso.Size = new Size(150, 31);
            txtSueldoIngreso.TabIndex = 29;
            // 
            // txtTotal_descuentos
            // 
            txtTotal_descuentos.Location = new Point(152, 232);
            txtTotal_descuentos.Name = "txtTotal_descuentos";
            txtTotal_descuentos.Size = new Size(150, 31);
            txtTotal_descuentos.TabIndex = 30;
            // 
            // txtSueldo_neto
            // 
            txtSueldo_neto.Location = new Point(152, 286);
            txtSueldo_neto.Name = "txtSueldo_neto";
            txtSueldo_neto.Size = new Size(150, 31);
            txtSueldo_neto.TabIndex = 31;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Gerente", "Analista de datos", "Desarrollador de software", "Operador" });
            cmbCargo.Location = new Point(114, 102);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(182, 33);
            cmbCargo.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(177, 402);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 33;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // bntSalir
            // 
            bntSalir.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSalir.Location = new Point(932, 561);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(115, 43);
            bntSalir.TabIndex = 34;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // bntEditar
            // 
            bntEditar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntEditar.Location = new Point(351, 561);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(131, 43);
            bntEditar.TabIndex = 35;
            bntEditar.Text = "Editar";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntEliminar.Location = new Point(670, 562);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(111, 43);
            bntEliminar.TabIndex = 36;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += button4_Click;
            // 
            // bntGuardar
            // 
            bntGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntGuardar.Location = new Point(67, 561);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(128, 43);
            bntGuardar.TabIndex = 37;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = true;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // bntLimpiar
            // 
            bntLimpiar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntLimpiar.Location = new Point(795, 561);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(119, 43);
            bntLimpiar.TabIndex = 38;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = true;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // Empleados
            // 
            Empleados.Controls.Add(tabPage1);
            Empleados.Controls.Add(tabPage2);
            Empleados.Location = new Point(-7, 26);
            Empleados.Name = "Empleados";
            Empleados.SelectedIndex = 0;
            Empleados.Size = new Size(1252, 508);
            Empleados.TabIndex = 39;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1244, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Empleado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAFP);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtSFS);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtOtros);
            groupBox2.Controls.Add(txtTotal_descuentos);
            groupBox2.Controls.Add(txtSueldo_neto);
            groupBox2.Controls.Add(txtISR);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(708, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 385);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbCargo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHijos);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSueldoIngreso);
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Location = new Point(113, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 386);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 34;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgInfo);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1244, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Columns.AddRange(new DataGridViewColumn[] { Nombre, cargo, Hijos, Sueldo, Sueldo_Neto, Impuestos });
            dtgInfo.Location = new Point(136, 28);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 62;
            dtgInfo.Size = new Size(962, 405);
            dtgInfo.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // cargo
            // 
            cargo.HeaderText = "Cargo";
            cargo.MinimumWidth = 8;
            cargo.Name = "cargo";
            cargo.Width = 150;
            // 
            // Hijos
            // 
            Hijos.HeaderText = "Hijos";
            Hijos.MinimumWidth = 8;
            Hijos.Name = "Hijos";
            Hijos.Width = 150;
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.MinimumWidth = 8;
            Sueldo.Name = "Sueldo";
            Sueldo.Width = 150;
            // 
            // Sueldo_Neto
            // 
            Sueldo_Neto.HeaderText = "Sueldo_Neto";
            Sueldo_Neto.MinimumWidth = 8;
            Sueldo_Neto.Name = "Sueldo_Neto";
            Sueldo_Neto.Width = 150;
            // 
            // Impuestos
            // 
            Impuestos.HeaderText = "Total de deduciones";
            Impuestos.MinimumWidth = 8;
            Impuestos.Name = "Impuestos";
            Impuestos.Width = 150;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(209, 562);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 43);
            btnCalcular.TabIndex = 40;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 665);
            Controls.Add(btnCalcular);
            Controls.Add(Empleados);
            Controls.Add(bntSalir);
            Controls.Add(bntGuardar);
            Controls.Add(bntLimpiar);
            Controls.Add(bntEditar);
            Controls.Add(bntEliminar);
            Name = "Form1";
            Text = "Form1";
            Empleados.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtAFP;
        private TextBox txtSFS;
        private TextBox txtSueldo;
        private TextBox txtHijos;
        private TextBox txtOtros;
        private TextBox txtISR;
        private TextBox textBox8;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSueldoIngreso;
        private TextBox txtTotal_descuentos;
        private TextBox txtSueldo_neto;
        private ComboBox cmbCargo;
        private Button button1;
        private Button bntSalir;
        private Button bntEditar;
        private Button bntEliminar;
        private Button bntGuardar;
        private Button bntLimpiar;
        private TabControl Empleados;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNombre;
        private DataGridView dtgInfo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn cargo;
        private DataGridViewTextBoxColumn Hijos;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Sueldo_Neto;
        private DataGridViewTextBoxColumn Impuestos;
        private Button btnCalcular;
    }
}
