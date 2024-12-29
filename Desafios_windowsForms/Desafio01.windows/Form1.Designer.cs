namespace Ejercicio01.windows
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
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            txtSueldobruto = new TextBox();
            txtHijos = new TextBox();
            txtAFP = new TextBox();
            txtSFS = new TextBox();
            txtISR = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblotros = new Label();
            label12 = new Label();
            txtSueldoneto = new TextBox();
            txtTotalDecuentos = new TextBox();
            label10 = new Label();
            txtotros = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 61);
            label1.Name = "label1";
            label1.Size = new Size(401, 29);
            label1.TabIndex = 0;
            label1.Text = "Calcula el sueldo de un empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(714, 61);
            label2.Name = "label2";
            label2.Size = new Size(196, 29);
            label2.TabIndex = 1;
            label2.Text = "Total del sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 131);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 181);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 3;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 231);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 4;
            label5.Text = "Sueldo bruto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(134, 274);
            label6.Name = "label6";
            label6.Size = new Size(52, 23);
            label6.TabIndex = 5;
            label6.Text = "Hijos";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(237, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = SystemColors.InactiveCaption;
            txtCargo.Location = new Point(237, 177);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(171, 31);
            txtCargo.TabIndex = 7;
            // 
            // txtSueldobruto
            // 
            txtSueldobruto.BackColor = SystemColors.InactiveCaption;
            txtSueldobruto.Location = new Point(237, 225);
            txtSueldobruto.Name = "txtSueldobruto";
            txtSueldobruto.Size = new Size(171, 31);
            txtSueldobruto.TabIndex = 8;
            // 
            // txtHijos
            // 
            txtHijos.BackColor = SystemColors.InactiveCaption;
            txtHijos.Location = new Point(237, 276);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(171, 31);
            txtHijos.TabIndex = 9;
            // 
            // txtAFP
            // 
            txtAFP.BackColor = SystemColors.InactiveCaption;
            txtAFP.Location = new Point(778, 127);
            txtAFP.Name = "txtAFP";
            txtAFP.Size = new Size(166, 31);
            txtAFP.TabIndex = 10;
            // 
            // txtSFS
            // 
            txtSFS.BackColor = SystemColors.InactiveCaption;
            txtSFS.Location = new Point(778, 177);
            txtSFS.Name = "txtSFS";
            txtSFS.Size = new Size(166, 31);
            txtSFS.TabIndex = 11;
            // 
            // txtISR
            // 
            txtISR.BackColor = SystemColors.InactiveCaption;
            txtISR.Location = new Point(778, 229);
            txtISR.Name = "txtISR";
            txtISR.Size = new Size(166, 31);
            txtISR.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(714, 131);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 14;
            label7.Text = "AFP\r\n";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(713, 181);
            label8.Name = "label8";
            label8.Size = new Size(48, 23);
            label8.TabIndex = 15;
            label8.Text = "SFS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(713, 229);
            label9.Name = "label9";
            label9.Size = new Size(43, 23);
            label9.TabIndex = 16;
            label9.Text = "ISR";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(89, 511);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(126, 34);
            btnCalcular.TabIndex = 18;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(345, 511);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(559, 511);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblotros
            // 
            lblotros.AutoSize = true;
            lblotros.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblotros.Location = new Point(696, 284);
            lblotros.Name = "lblotros";
            lblotros.Size = new Size(60, 23);
            lblotros.TabIndex = 21;
            lblotros.Text = "Otros";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(647, 372);
            label12.Name = "label12";
            label12.Size = new Size(114, 23);
            label12.TabIndex = 22;
            label12.Text = "Sueldo neto";
            // 
            // txtSueldoneto
            // 
            txtSueldoneto.BackColor = SystemColors.InactiveCaption;
            txtSueldoneto.Location = new Point(778, 364);
            txtSueldoneto.Name = "txtSueldoneto";
            txtSueldoneto.Size = new Size(166, 31);
            txtSueldoneto.TabIndex = 23;
            // 
            // txtTotalDecuentos
            // 
            txtTotalDecuentos.BackColor = SystemColors.InactiveCaption;
            txtTotalDecuentos.Location = new Point(778, 323);
            txtTotalDecuentos.Name = "txtTotalDecuentos";
            txtTotalDecuentos.Size = new Size(166, 31);
            txtTotalDecuentos.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(617, 331);
            label10.Name = "label10";
            label10.Size = new Size(145, 23);
            label10.TabIndex = 25;
            label10.Text = "TotalDecuentos";
            // 
            // txtotros
            // 
            txtotros.BackColor = SystemColors.InactiveCaption;
            txtotros.Location = new Point(778, 274);
            txtotros.Name = "txtotros";
            txtotros.Size = new Size(166, 31);
            txtotros.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 580);
            Controls.Add(txtotros);
            Controls.Add(label10);
            Controls.Add(txtTotalDecuentos);
            Controls.Add(txtSueldoneto);
            Controls.Add(label12);
            Controls.Add(lblotros);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtISR);
            Controls.Add(txtSFS);
            Controls.Add(txtAFP);
            Controls.Add(txtHijos);
            Controls.Add(txtSueldobruto);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private TextBox txtSueldobruto;
        private TextBox txtHijos;
        private TextBox txtAFP;
        private TextBox txtSFS;
        private TextBox txtISR;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblotros;
        private Label label12;
        private TextBox txtSueldoneto;
        private TextBox txtTotalDecuentos;
        private Label label10;
        private TextBox txtotros;
    }
}
