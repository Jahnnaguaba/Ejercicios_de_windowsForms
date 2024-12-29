namespace Desafio04
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
            txtArticulo = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtITBIS = new TextBox();
            txtCantidad = new TextBox();
            txtDescripcion = new TextBox();
            btnCalcularSubtotal = new Button();
            bntLimpiar = new Button();
            label7 = new Label();
            txtSubtotal = new TextBox();
            btnAgregarProducto = new Button();
            dataGridView1 = new DataGridView();
            Articulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ITBIS = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lblTotalAPagar = new Label();
            txtTotalPagar = new TextBox();
            label9 = new Label();
            txtEfectivo = new TextBox();
            txtCambio = new TextBox();
            label10 = new Label();
            button4 = new Button();
            btnGenerarFactura = new Button();
            btnCalcularTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 42);
            label1.Name = "label1";
            label1.Size = new Size(205, 45);
            label1.TabIndex = 0;
            label1.Text = "Comercial JJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 174);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 1;
            label2.Text = "Articulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 330);
            label3.Name = "label3";
            label3.Size = new Size(59, 29);
            label3.TabIndex = 2;
            label3.Text = "ITBIS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 280);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 221);
            label5.Name = "label5";
            label5.Size = new Size(116, 29);
            label5.TabIndex = 4;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 381);
            label6.Name = "label6";
            label6.Size = new Size(141, 29);
            label6.TabIndex = 5;
            label6.Text = "Precio Unitario";
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(232, 174);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(150, 31);
            txtArticulo.TabIndex = 6;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(232, 379);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(150, 31);
            txtPrecioUnitario.TabIndex = 7;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(232, 330);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(150, 31);
            txtITBIS.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(232, 280);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(232, 221);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 10;
            // 
            // btnCalcularSubtotal
            // 
            btnCalcularSubtotal.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcularSubtotal.Location = new Point(97, 459);
            btnCalcularSubtotal.Name = "btnCalcularSubtotal";
            btnCalcularSubtotal.Size = new Size(178, 34);
            btnCalcularSubtotal.TabIndex = 11;
            btnCalcularSubtotal.Text = "Calcular Subtotal";
            btnCalcularSubtotal.UseVisualStyleBackColor = true;
            btnCalcularSubtotal.Click += btnCalcularSubtotal_Click;
            // 
            // bntLimpiar
            // 
            bntLimpiar.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntLimpiar.Location = new Point(510, 459);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(112, 34);
            bntLimpiar.TabIndex = 12;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = true;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 529);
            label7.Name = "label7";
            label7.Size = new Size(84, 29);
            label7.TabIndex = 13;
            label7.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(197, 527);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 14;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.Location = new Point(305, 459);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(183, 34);
            btnAgregarProducto.TabIndex = 15;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Articulo, Descripcion, ITBIS, Cantidad, Subtotal });
            dataGridView1.Location = new Point(85, 624);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(814, 197);
            dataGridView1.TabIndex = 16;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.MinimumWidth = 8;
            Articulo.Name = "Articulo";
            Articulo.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 150;
            // 
            // ITBIS
            // 
            ITBIS.HeaderText = "ITBIS";
            ITBIS.MinimumWidth = 8;
            ITBIS.Name = "ITBIS";
            ITBIS.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 8;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 150;
            // 
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAPagar.Location = new Point(107, 886);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(128, 29);
            lblTotalAPagar.TabIndex = 17;
            lblTotalAPagar.Text = "Total a pagar";
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(254, 886);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(150, 31);
            txtTotalPagar.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(144, 932);
            label9.Name = "label9";
            label9.Size = new Size(82, 29);
            label9.TabIndex = 19;
            label9.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(254, 932);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(150, 31);
            txtEfectivo.TabIndex = 20;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(516, 883);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(150, 31);
            txtCambio.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(430, 883);
            label10.Name = "label10";
            label10.Size = new Size(80, 29);
            label10.TabIndex = 22;
            label10.Text = "Cambio";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(651, 932);
            button4.Name = "button4";
            button4.Size = new Size(109, 34);
            button4.TabIndex = 23;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarFactura.Location = new Point(682, 881);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(183, 34);
            btnGenerarFactura.TabIndex = 24;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcularTotal.Location = new Point(444, 932);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(178, 34);
            btnCalcularTotal.TabIndex = 25;
            btnCalcularTotal.Text = "Calcular Total";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 1050);
            Controls.Add(btnCalcularTotal);
            Controls.Add(btnGenerarFactura);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(txtCambio);
            Controls.Add(txtEfectivo);
            Controls.Add(label9);
            Controls.Add(txtTotalPagar);
            Controls.Add(lblTotalAPagar);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtSubtotal);
            Controls.Add(label7);
            Controls.Add(bntLimpiar);
            Controls.Add(btnCalcularSubtotal);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCantidad);
            Controls.Add(txtITBIS);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtArticulo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtArticulo;
        private TextBox txtPrecioUnitario;
        private TextBox txtITBIS;
        private TextBox txtCantidad;
        private TextBox txtDescripcion;
        private Button btnCalcularSubtotal;
        private Button bntLimpiar;
        private Label label7;
        private TextBox txtSubtotal;
        private Button btnAgregarProducto;
        private DataGridView dataGridView1;
        private Label lblTotalAPagar;
        private TextBox txtTotalPagar;
        private Label label9;
        private TextBox txtEfectivo;
        private TextBox txtCambio;
        private Label label10;
        private Button button4;
        private Button btnGenerarFactura;
        private Button btnCalcularTotal;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn ITBIS;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}
