namespace Ejercicio02.windows
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            cmbCurso = new ComboBox();
            cmbArea = new ComboBox();
            cmbSección = new ComboBox();
            label6 = new Label();
            rdbMasculino = new RadioButton();
            rdbFemenino = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtP = new TextBox();
            txtN4 = new TextBox();
            txtN3 = new TextBox();
            txtN2 = new TextBox();
            txtN1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            txtEstatus = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 101);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 149);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 194);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Sección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 238);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 4;
            label5.Text = "Area";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(129, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 31);
            txtNombre.TabIndex = 5;
            // 
            // cmbCurso
            // 
            cmbCurso.BackColor = SystemColors.InactiveCaption;
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cmbCurso.Location = new Point(129, 149);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(141, 33);
            cmbCurso.TabIndex = 6;
            // 
            // cmbArea
            // 
            cmbArea.BackColor = SystemColors.InactiveCaption;
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Enfermaria", "Contabilidad", "Gastronomia", "Informatica", "Eletricidad" });
            cmbArea.Location = new Point(129, 238);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(141, 33);
            cmbArea.TabIndex = 7;
            // 
            // cmbSección
            // 
            cmbSección.BackColor = SystemColors.InactiveCaption;
            cmbSección.FormattingEnabled = true;
            cmbSección.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "B", "C1", "C2", "D", "D1", "D2", "E" });
            cmbSección.Location = new Point(129, 194);
            cmbSección.Name = "cmbSección";
            cmbSección.Size = new Size(141, 33);
            cmbSección.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 308);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 9;
            label6.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbMasculino.Location = new Point(129, 307);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(50, 24);
            rdbMasculino.TabIndex = 10;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "M";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbFemenino.Location = new Point(244, 307);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(44, 24);
            rdbFemenino.TabIndex = 11;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "F";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 359);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 12;
            label7.Text = "N1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(268, 359);
            label8.Name = "label8";
            label8.Size = new Size(20, 20);
            label8.TabIndex = 13;
            label8.Text = "P";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(166, 416);
            label9.Name = "label9";
            label9.Size = new Size(29, 19);
            label9.TabIndex = 14;
            label9.Text = "N4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(166, 359);
            label10.Name = "label10";
            label10.Size = new Size(31, 20);
            label10.TabIndex = 15;
            label10.Text = "N3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(38, 403);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 16;
            label11.Text = "N2";
            // 
            // txtP
            // 
            txtP.Location = new Point(294, 359);
            txtP.Name = "txtP";
            txtP.Size = new Size(40, 31);
            txtP.TabIndex = 17;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(211, 416);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(40, 31);
            txtN4.TabIndex = 18;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(211, 352);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(38, 31);
            txtN3.TabIndex = 19;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(83, 403);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(40, 31);
            txtN2.TabIndex = 20;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(83, 352);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(40, 31);
            txtN1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(0, 1);
            button1.Name = "button1";
            button1.Size = new Size(545, 70);
            button1.TabIndex = 22;
            button1.Text = "Registro de calificaciones";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(305, 185);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 23;
            button2.Text = "Estatus";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(166, 466);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(217, 31);
            txtEstatus.TabIndex = 24;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(211, 524);
            button3.Name = "button3";
            button3.Size = new Size(42, 34);
            button3.TabIndex = 28;
            button3.Text = "L";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(132, 524);
            button4.Name = "button4";
            button4.Size = new Size(47, 34);
            button4.TabIndex = 29;
            button4.Text = "C";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(287, 524);
            button5.Name = "button5";
            button5.Size = new Size(47, 34);
            button5.TabIndex = 30;
            button5.Text = "S";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(83, 472);
            label1.Name = "label1";
            label1.Size = new Size(66, 22);
            label1.TabIndex = 31;
            label1.Text = "Estatus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 567);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtEstatus);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtN1);
            Controls.Add(txtN2);
            Controls.Add(txtN3);
            Controls.Add(txtN4);
            Controls.Add(txtP);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(rdbFemenino);
            Controls.Add(rdbMasculino);
            Controls.Add(label6);
            Controls.Add(cmbSección);
            Controls.Add(cmbArea);
            Controls.Add(cmbCurso);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private ComboBox cmbCurso;
        private ComboBox cmbArea;
        private ComboBox cmbSección;
        private Label label6;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtP;
        private TextBox txtN4;
        private TextBox txtN3;
        private TextBox txtN2;
        private TextBox txtN1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private TextBox txtEstatus;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
