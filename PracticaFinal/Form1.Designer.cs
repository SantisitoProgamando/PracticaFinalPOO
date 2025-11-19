namespace PracticaFinal
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
            dgvClientes = new DataGridView();
            dgvPendientes = new DataGridView();
            dgvPagados = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregarCobro = new Button();
            btnPagarCobro = new Button();
            rbNormal = new RadioButton();
            rbEspecial = new RadioButton();
            dtpVencimiento = new DateTimePicker();
            nudImporte = new NumericUpDown();
            rbMayorMenor = new RadioButton();
            rbMenorMayor = new RadioButton();
            btnOrdenar = new Button();
            dgvOrdenados = new DataGridView();
            dgvResumen = new DataGridView();
            btnPruebaGit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudImporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(0, 18);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(300, 170);
            dgvClientes.TabIndex = 0;
            // 
            // dgvPendientes
            // 
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientes.Location = new Point(414, 18);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.RowHeadersWidth = 51;
            dgvPendientes.Size = new Size(287, 170);
            dgvPendientes.TabIndex = 1;
            // 
            // dgvPagados
            // 
            dgvPagados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagados.Location = new Point(751, 18);
            dgvPagados.Name = "dgvPagados";
            dgvPagados.RowHeadersWidth = 51;
            dgvPagados.Size = new Size(289, 170);
            dgvPagados.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1046, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 76);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1046, 163);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 50);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Clientes";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1046, 94);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(145, 63);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregarCobro
            // 
            btnAgregarCobro.Location = new Point(0, 238);
            btnAgregarCobro.Name = "btnAgregarCobro";
            btnAgregarCobro.Size = new Size(160, 65);
            btnAgregarCobro.TabIndex = 6;
            btnAgregarCobro.Text = "Agregar Cobro";
            btnAgregarCobro.UseVisualStyleBackColor = true;
            btnAgregarCobro.Click += btnAgregarCobro_Click;
            // 
            // btnPagarCobro
            // 
            btnPagarCobro.Location = new Point(0, 323);
            btnPagarCobro.Name = "btnPagarCobro";
            btnPagarCobro.Size = new Size(160, 69);
            btnPagarCobro.TabIndex = 7;
            btnPagarCobro.Text = "PagarCobro";
            btnPagarCobro.UseVisualStyleBackColor = true;
            btnPagarCobro.Click += btnPagarCobro_Click;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(194, 258);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(80, 24);
            rbNormal.TabIndex = 8;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbEspecial
            // 
            rbEspecial.AutoSize = true;
            rbEspecial.Location = new Point(304, 258);
            rbEspecial.Name = "rbEspecial";
            rbEspecial.Size = new Size(84, 24);
            rbEspecial.TabIndex = 9;
            rbEspecial.TabStop = true;
            rbEspecial.Text = "Especial";
            rbEspecial.UseVisualStyleBackColor = true;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(182, 342);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(233, 27);
            dtpVencimiento.TabIndex = 10;
            // 
            // nudImporte
            // 
            nudImporte.Location = new Point(320, 211);
            nudImporte.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            nudImporte.Name = "nudImporte";
            nudImporte.Size = new Size(161, 27);
            nudImporte.TabIndex = 11;
            // 
            // rbMayorMenor
            // 
            rbMayorMenor.AutoSize = true;
            rbMayorMenor.Location = new Point(698, 386);
            rbMayorMenor.Name = "rbMayorMenor";
            rbMayorMenor.Size = new Size(131, 24);
            rbMayorMenor.TabIndex = 12;
            rbMayorMenor.TabStop = true;
            rbMayorMenor.Text = "Mayor a Menor";
            rbMayorMenor.UseVisualStyleBackColor = true;
            // 
            // rbMenorMayor
            // 
            rbMenorMayor.AutoSize = true;
            rbMenorMayor.Location = new Point(698, 430);
            rbMenorMayor.Name = "rbMenorMayor";
            rbMenorMayor.Size = new Size(131, 24);
            rbMenorMayor.TabIndex = 13;
            rbMenorMayor.TabStop = true;
            rbMenorMayor.Text = "Menor a Mayor";
            rbMenorMayor.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(539, 386);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(131, 68);
            btnOrdenar.TabIndex = 14;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // dgvOrdenados
            // 
            dgvOrdenados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenados.Location = new Point(553, 277);
            dgvOrdenados.Name = "dgvOrdenados";
            dgvOrdenados.RowHeadersWidth = 51;
            dgvOrdenados.Size = new Size(228, 103);
            dgvOrdenados.TabIndex = 15;
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(1020, 276);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 51;
            dgvResumen.Size = new Size(242, 134);
            dgvResumen.TabIndex = 16;
            // 
            // btnPruebaGit
            // 
            btnPruebaGit.Location = new Point(810, 241);
            btnPruebaGit.Name = "btnPruebaGit";
            btnPruebaGit.Size = new Size(129, 69);
            btnPruebaGit.TabIndex = 17;
            btnPruebaGit.Text = "Prueba Git";
            btnPruebaGit.UseVisualStyleBackColor = true;
            btnPruebaGit.Click += btnPruebaGit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 483);
            Controls.Add(btnPruebaGit);
            Controls.Add(dgvResumen);
            Controls.Add(dgvOrdenados);
            Controls.Add(btnOrdenar);
            Controls.Add(rbMenorMayor);
            Controls.Add(rbMayorMenor);
            Controls.Add(nudImporte);
            Controls.Add(dtpVencimiento);
            Controls.Add(rbEspecial);
            Controls.Add(rbNormal);
            Controls.Add(btnPagarCobro);
            Controls.Add(btnAgregarCobro);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPagados);
            Controls.Add(dgvPendientes);
            Controls.Add(dgvClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudImporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridView dgvPendientes;
        private DataGridView dgvPagados;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregarCobro;
        private Button btnPagarCobro;
        private RadioButton rbNormal;
        private RadioButton rbEspecial;
        private DateTimePicker dtpVencimiento;
        private NumericUpDown nudImporte;
        private RadioButton rbMayorMenor;
        private RadioButton rbMenorMayor;
        private Button btnOrdenar;
        private DataGridView dgvOrdenados;
        private DataGridView dgvResumen;
        private Button btnPruebaGit;
    }
}
