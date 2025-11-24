namespace SistemaLibreria
{
    partial class GestionDePrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbUsuario = new ComboBox();
            cmbLibro = new ComboBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            dgvPrestamos = new DataGridView();
            dgvCodigo = new DataGridViewTextBoxColumn();
            dgvRutUsuario = new DataGridViewTextBoxColumn();
            dgvNombreUsuario = new DataGridViewTextBoxColumn();
            dgvCodigoLibro = new DataGridViewTextBoxColumn();
            dgvNombreLibro = new DataGridViewTextBoxColumn();
            dgvFechaPrestamo = new DataGridViewTextBoxColumn();
            dgvFechaDevolucion = new DataGridViewTextBoxColumn();
            dtpPrestamo = new DateTimePicker();
            dtpDevolucion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 26.25F);
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 42);
            label1.TabIndex = 0;
            label1.Text = "Préstamos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(323, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(325, 131);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Libro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(325, 216);
            label4.Name = "label4";
            label4.Size = new Size(175, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de devolución(estimada):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(323, 176);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de préstamo:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(379, 84);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(203, 23);
            cmbUsuario.TabIndex = 5;
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(368, 128);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(214, 23);
            cmbLibro.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(18, 18, 18);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.WhiteSmoke;
            btnAgregar.Location = new Point(221, 282);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(18, 18, 18);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.WhiteSmoke;
            btnModificar.Location = new Point(337, 282);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(18, 18, 18);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.WhiteSmoke;
            btnLimpiar.Location = new Point(596, 282);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(710, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Imprint MT Shadow", 12.25F);
            label6.Location = new Point(12, 329);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 13;
            label6.Text = "Registro";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { dgvCodigo, dgvRutUsuario, dgvNombreUsuario, dgvCodigoLibro, dgvNombreLibro, dgvFechaPrestamo, dgvFechaDevolucion });
            dgvPrestamos.Location = new Point(12, 352);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(974, 315);
            dgvPrestamos.TabIndex = 14;
            // 
            // dgvCodigo
            // 
            dgvCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigo.HeaderText = "Codigo Prestamo";
            dgvCodigo.Name = "dgvCodigo";
            dgvCodigo.ReadOnly = true;
            // 
            // dgvRutUsuario
            // 
            dgvRutUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRutUsuario.HeaderText = "Rut de usuario";
            dgvRutUsuario.Name = "dgvRutUsuario";
            dgvRutUsuario.ReadOnly = true;
            // 
            // dgvNombreUsuario
            // 
            dgvNombreUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNombreUsuario.HeaderText = "Nombre de usuario";
            dgvNombreUsuario.Name = "dgvNombreUsuario";
            dgvNombreUsuario.ReadOnly = true;
            // 
            // dgvCodigoLibro
            // 
            dgvCodigoLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigoLibro.HeaderText = "Codigo de libro";
            dgvCodigoLibro.Name = "dgvCodigoLibro";
            dgvCodigoLibro.ReadOnly = true;
            // 
            // dgvNombreLibro
            // 
            dgvNombreLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNombreLibro.HeaderText = "Nombre de libro";
            dgvNombreLibro.Name = "dgvNombreLibro";
            dgvNombreLibro.ReadOnly = true;
            // 
            // dgvFechaPrestamo
            // 
            dgvFechaPrestamo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFechaPrestamo.HeaderText = "Fecha de préstamo";
            dgvFechaPrestamo.Name = "dgvFechaPrestamo";
            dgvFechaPrestamo.ReadOnly = true;
            // 
            // dgvFechaDevolucion
            // 
            dgvFechaDevolucion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFechaDevolucion.HeaderText = "Fecha de devolución(estimada)";
            dgvFechaDevolucion.Name = "dgvFechaDevolucion";
            dgvFechaDevolucion.ReadOnly = true;
            // 
            // dtpPrestamo
            // 
            dtpPrestamo.Location = new Point(439, 170);
            dtpPrestamo.Name = "dtpPrestamo";
            dtpPrestamo.Size = new Size(200, 23);
            dtpPrestamo.TabIndex = 15;
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.Location = new Point(506, 210);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(200, 23);
            dtpDevolucion.TabIndex = 16;
            // 
            // GestionDePrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(998, 679);
            Controls.Add(dtpDevolucion);
            Controls.Add(dtpPrestamo);
            Controls.Add(dgvPrestamos);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbLibro);
            Controls.Add(cmbUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionDePrestamos";
            Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbUsuario;
        private ComboBox cmbDevolucion;
        private ComboBox cmbLibro;
        private ComboBox cmbPrestamo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Label label6;
        private DataGridView dgvPrestamos;
        private DateTimePicker dtpPrestamo;
        private DateTimePicker dtpDevolucion;
        private DataGridViewTextBoxColumn dgvCodigo;
        private DataGridViewTextBoxColumn dgvRutUsuario;
        private DataGridViewTextBoxColumn dgvNombreUsuario;
        private DataGridViewTextBoxColumn dgvCodigoLibro;
        private DataGridViewTextBoxColumn dgvNombreLibro;
        private DataGridViewTextBoxColumn dgvFechaPrestamo;
        private DataGridViewTextBoxColumn dgvFechaDevolucion;
    }
}