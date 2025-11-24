namespace SistemaLibreria
{
    partial class HistorialDeUsuarios
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
            cmbUsuario = new ComboBox();
            cmbLibro = new ComboBox();
            label4 = new Label();
            dtpDevolucion = new DateTimePicker();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvFechaDevolucion = new DataGridViewTextBoxColumn();
            dgvFechaPrestamo = new DataGridViewTextBoxColumn();
            dgvCodigoLibro = new DataGridViewTextBoxColumn();
            dgvLibro = new DataGridViewTextBoxColumn();
            dgvRutUsuario = new DataGridViewTextBoxColumn();
            dgvNombreUsuario = new DataGridViewTextBoxColumn();
            dgvCodigoDevolucion = new DataGridViewTextBoxColumn();
            dgvDevolucion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 26.25F);
            label1.ForeColor = Color.FromArgb(18, 18, 18);
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 42);
            label1.TabIndex = 0;
            label1.Text = "Devoluciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(18, 18, 18);
            label2.Location = new Point(333, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(18, 18, 18);
            label3.Location = new Point(333, 126);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Libro:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(386, 83);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(182, 23);
            cmbUsuario.TabIndex = 4;
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(376, 123);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(192, 23);
            cmbLibro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(18, 18, 18);
            label4.Location = new Point(333, 162);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de devolución:";
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.Location = new Point(458, 156);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(200, 23);
            dtpDevolucion.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(18, 18, 18);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.Transparent;
            btnAgregar.ImageAlign = ContentAlignment.BottomRight;
            btnAgregar.Location = new Point(333, 203);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(18, 18, 18);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(443, 203);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(549, 203);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvFechaDevolucion
            // 
            dgvFechaDevolucion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFechaDevolucion.HeaderText = "Fecha de devolución";
            dgvFechaDevolucion.Name = "dgvFechaDevolucion";
            dgvFechaDevolucion.ReadOnly = true;
            // 
            // dgvFechaPrestamo
            // 
            dgvFechaPrestamo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFechaPrestamo.HeaderText = "Fecha de préstamo";
            dgvFechaPrestamo.Name = "dgvFechaPrestamo";
            dgvFechaPrestamo.ReadOnly = true;
            // 
            // dgvCodigoLibro
            // 
            dgvCodigoLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigoLibro.HeaderText = "Codigo de libro";
            dgvCodigoLibro.Name = "dgvCodigoLibro";
            dgvCodigoLibro.ReadOnly = true;
            // 
            // dgvLibro
            // 
            dgvLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLibro.HeaderText = "Libro";
            dgvLibro.Name = "dgvLibro";
            dgvLibro.ReadOnly = true;
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
            // dgvCodigoDevolucion
            // 
            dgvCodigoDevolucion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigoDevolucion.HeaderText = "Codigo de devolución";
            dgvCodigoDevolucion.Name = "dgvCodigoDevolucion";
            dgvCodigoDevolucion.ReadOnly = true;
            // 
            // dgvDevolucion
            // 
            dgvDevolucion.AllowUserToAddRows = false;
            dgvDevolucion.AllowUserToDeleteRows = false;
            dgvDevolucion.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevolucion.Columns.AddRange(new DataGridViewColumn[] { dgvCodigoDevolucion, dgvNombreUsuario, dgvRutUsuario, dgvLibro, dgvCodigoLibro, dgvFechaPrestamo, dgvFechaDevolucion });
            dgvDevolucion.GridColor = SystemColors.InactiveBorder;
            dgvDevolucion.Location = new Point(51, 258);
            dgvDevolucion.MultiSelect = false;
            dgvDevolucion.Name = "dgvDevolucion";
            dgvDevolucion.ReadOnly = true;
            dgvDevolucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevolucion.Size = new Size(894, 273);
            dgvDevolucion.TabIndex = 8;
            // 
            // HistorialDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(986, 543);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpDevolucion);
            Controls.Add(dgvDevolucion);
            Controls.Add(label4);
            Controls.Add(cmbLibro);
            Controls.Add(cmbUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HistorialDeUsuarios";
            Text = "Gestion de devoluciones";
            ((System.ComponentModel.ISupportInitialize)dgvDevolucion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbUsuario;
        private ComboBox cmbLibro;
        private Label label4;
        private DateTimePicker dtpDevolucion;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn dgvFechaDevolucion;
        private DataGridViewTextBoxColumn dgvFechaPrestamo;
        private DataGridViewTextBoxColumn dgvCodigoLibro;
        private DataGridViewTextBoxColumn dgvLibro;
        private DataGridViewTextBoxColumn dgvRutUsuario;
        private DataGridViewTextBoxColumn dgvNombreUsuario;
        private DataGridViewTextBoxColumn dgvCodigoDevolucion;
        private DataGridView dgvDevolucion;
    }
}